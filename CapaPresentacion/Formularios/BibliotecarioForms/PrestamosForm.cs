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

namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    public partial class PrestamosForm : Form
    {
        private readonly IPrestamoServicio _prestamoServicio;
        public PrestamosForm(IPrestamoServicio prestamoServicio)
        {
            InitializeComponent();
            _prestamoServicio = prestamoServicio;
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
                _prestamoServicio.AgregarPrestamo(prestamo);
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
