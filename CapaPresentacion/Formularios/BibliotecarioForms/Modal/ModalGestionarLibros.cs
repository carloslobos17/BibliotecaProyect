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
using CapaNegocios.Servicios.LibroServicios;
using CapaPresentacion.Formularios.AdminForms;
using CapaPresentacion.Validaciones;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.Results;

namespace CapaPresentacion.Formularios.BibliotecarioForms.Modal
{
    public partial class ModalGestionarLibros : Form
    {
        private readonly ILibroServicio _libroServicio;
        private readonly GestionarLibrosForm _gestionarLibrosForm;
        public bool editMode = false;
        public int idLibro = 0;
        public ModalGestionarLibros(ILibroServicio libroServicio, GestionarLibrosForm gestionarLibrosForm)
        {
            InitializeComponent();
            _libroServicio = libroServicio;
            _gestionarLibrosForm = gestionarLibrosForm;
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            Categoria categoria = new Categoria { Id = 0, Nombre = "Seleccione una categoría" };
            List<Categoria> categorias = _libroServicio.ObtenerCategorias().ToList();
            categorias.Insert(0, categoria);
            categoriaComboBox.DataSource = categorias;
            categoriaComboBox.ValueMember = "ID";
            categoriaComboBox.DisplayMember = "Nombre";
        }

        private void agregarLibroModalButton_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                int id = idLibro;
                string titulo = tituloTextBox.Text;
                string autor = autorTextBox.Text;
                DateTime fechaDePublicacion = DateTime.Parse(fechaPublicacionDateTimePicker.Value.ToString());
                int copiasDisponibles = Convert.ToInt32(copiasDisponiblesNumericUpDown.Text);

                var libro = new Libro
                {
                    Id = id,
                    Titulo = titulo,
                    Autor = autor,
                    FechaPublicacion = fechaDePublicacion,
                    CopiasDisponibles = copiasDisponibles,
                    IdCategoria = 1
                };

                _libroServicio.EditarLibro(libro);
                _gestionarLibrosForm.CargarLibros();
                this.Close();
                editMode = false;
            }
            else
            {
                var libro = new Libro
                {
                    Titulo = tituloTextBox.Text,
                    Autor = autorTextBox.Text,
                    FechaPublicacion = fechaPublicacionDateTimePicker.Value,
                    CopiasDisponibles = Convert.ToInt32(copiasDisponiblesNumericUpDown.Text),
                    IdCategoria = 1
                };

                ValidacionLibro validacionLibro = new ValidacionLibro();
                ValidationResult result = validacionLibro.Validate(libro);

                if (!result.IsValid)
                {
                    MostrarErroresValidacion(result);
                }
                else
                {
                    _libroServicio.AgregarLibro(libro);

                    _gestionarLibrosForm.CargarLibros();
                    this.Close();
                }

            }

        }
        private void MostrarErroresValidacion(ValidationResult result)
        {
            validacionErrorProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Libro.Titulo):
                        validacionErrorProvider.SetError(tituloTextBox, error.ErrorMessage);
                        break;
                    case nameof(Libro.Autor):
                        validacionErrorProvider.SetError(autorTextBox, error.ErrorMessage);
                        break;
                    case nameof(Libro.FechaPublicacion):
                        validacionErrorProvider.SetError(fechaPublicacionDateTimePicker, error.ErrorMessage);
                        break;
                    case nameof(Libro.CopiasDisponibles):
                        validacionErrorProvider.SetError(copiasDisponiblesNumericUpDown, error.ErrorMessage);
                        break;
                    case nameof(Libro.IdCategoria):
                        validacionErrorProvider.SetError(categoriaComboBox, error.ErrorMessage);
                        break;

                }
            }

        }

        
    }
}
