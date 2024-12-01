using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad.Entidades;
using CapaNegocios.Servicios.PrestamoServicios;
using CapaPresentacion.Validaciones;
using FluentValidation.Results;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using CapaNegocios.Notificaciones;

namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    public partial class PrestamosForm : Form
    {
        private readonly IPrestamoServicio _prestamoServicio;
        private readonly IEmailNotificacion _emailNotificacion;
        public PrestamosForm(IPrestamoServicio prestamoServicio,
                             IEmailNotificacion emailNotificacion)
        {
            InitializeComponent();
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
            _prestamoServicio = prestamoServicio;
            _emailNotificacion = emailNotificacion;
            CargarEstudiantes();
            CargarLibros();
        }

        private void CargarEstudiantes()
        {
            Usuario usuario = new Usuario { Id = 0, Nombre = "Seleccione un estudiante" };
            List<Usuario> usuarios = _prestamoServicio.ObtenerEstudiantes().ToList();
            usuarios.Insert(0, usuario);
            estudiantesComboBox.DataSource = usuarios;
            estudiantesComboBox.DisplayMember = "Nombre";
            estudiantesComboBox.ValueMember = "Id";

        }

        private void CargarLibros()
        {
            Libro libro = new Libro { Id = 0, Titulo = "Seleccione un libro" };
            List<Libro> libros = _prestamoServicio.ObtenerLibros().ToList();
            libros.Insert(0, libro);
            librosComboBox.DataSource = libros;
            librosComboBox.DisplayMember = "Titulo";
            librosComboBox.ValueMember = "Id";

        }
        private void prestarLibroButton_Click(object sender, EventArgs e)
        {
            int idEstudiante = int.Parse(estudiantesComboBox.SelectedValue.ToString());
            int idLibro = int.Parse(librosComboBox.SelectedValue.ToString());
            //string nombreEstudiante = estudiantesComboBox.SelectedItem.ToString(); 
            //string nombreLibro = librosComboBox.SelectedItem.ToString();
            DateTime fechaPrestamo = fechaPrestamoDateTimePicker.Value;
            DateTime fechaDevolucion = fechaDevolucionDateTimePicker.Value;
            bool Estado = true;


            var prestamo = new Prestamo
            {
                IdUsuario = idEstudiante,
                IdLibro = idLibro,
                FechaPrestamo = fechaPrestamo,
                FechaDevolucion = fechaDevolucion,
                Activo = Estado
            };
            ValidacionPrestamo validacionPrestamo = new ValidacionPrestamo();
            ValidationResult result = validacionPrestamo.Validate(prestamo);

            if (!result.IsValid)
            {
                MostrarErroresValidacion(result);
            }
            else
            {

                string nombreEstudiante = estudiantesComboBox.Text;
                string tituloLibro = librosComboBox.Text;
                _prestamoServicio.AgregarPrestamo(prestamo);

                Console.WriteLine($"Estudiante: {nombreEstudiante}, Libro: {tituloLibro}");



                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Margin(1, Unit.Centimetre);

                        page.Header().Height(35).Background(Colors.Grey.Lighten1).Text("Comprobante de el prestamo")
                        .Bold().AlignCenter().FontSize(20).FontColor(Colors.White);

                        page.Content()
                            .Column(column =>
                            {

                                column.Item().PaddingLeft(1, Unit.Centimetre).PaddingTop(1, Unit.Centimetre).Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn();
                                        columns.RelativeColumn();
                                        columns.RelativeColumn();
                                        columns.RelativeColumn(); ;
                                    });

                                    table.Header(header =>
                                    {
                                        header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1)
                                            .Text("Nombre").Bold().FontColor(Colors.White);

                                        header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1)
                                            .Text("Nombre del libro").Bold().FontColor(Colors.White);

                                        header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1)
                                            .Text("Fecha del prestamo").Bold().FontColor(Colors.White);

                                        header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1)
                                            .Text("Fecha de devolucion").Bold().FontColor(Colors.White);
                                    });

                                    {
                                        var backgroundColor = Colors.White;

                                        table.Cell().Element(CellStyle).Background(backgroundColor).Text(nombreEstudiante);
                                        table.Cell().Element(CellStyle).Background(backgroundColor).Text(tituloLibro);
                                        table.Cell().Element(CellStyle).Background(backgroundColor).Text(prestamo.FechaPrestamo);
                                        table.Cell().Element(CellStyle).Background(backgroundColor).Text(prestamo.FechaDevolucion);
                                    }

                                    QuestPDF.Infrastructure.IContainer CellStyle(QuestPDF.Infrastructure.IContainer container) => container
                                        .Border(1)
                                        .BorderColor(Colors.Grey.Darken1);
                                });
                            });
                    });
                }).GeneratePdfAndShow();
                MessageBox.Show("Reporte PDF generado exitosamente!");
                var email = new EmailAjustes
                {
                    EmailPara = "bidubiduelgato@gmail.com",
                    DestinatarioNombre = "Don prueba",
                    Encabezado = $"Felicidades este es el mmm si creo",
                };

                _emailNotificacion.EnviarEmail(
                    email,
                    nombreEstudiante,
                    tituloLibro,
                    prestamo.FechaPrestamo,
                    prestamo.FechaDevolucion
                );
            }



        }

        private void MostrarErroresValidacion(ValidationResult result)
        {
            validacionErrorProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Prestamo.IdUsuario):
                        validacionErrorProvider.SetError(estudiantesComboBox, error.ErrorMessage);
                        break;
                    case nameof(Prestamo.IdLibro):
                        validacionErrorProvider.SetError(librosComboBox, error.ErrorMessage);
                        break;
                    case nameof(Prestamo.FechaPrestamo):
                        validacionErrorProvider.SetError(fechaPrestamoDateTimePicker, error.ErrorMessage);
                        break;
                    case nameof(Prestamo.FechaDevolucion):
                        validacionErrorProvider.SetError(fechaDevolucionDateTimePicker, error.ErrorMessage);
                        break;
                }
            }
        }
    }
}
