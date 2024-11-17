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
using Microsoft.Extensions.DependencyInjection;

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
        }

        private void agregarLibroModalButton_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                int id = idLibro;
                string titulo = tituloTextBox.Text;
                string autor = autorTextBox.Text;
                DateTime fechaDePublicacion = DateTime.Parse(fechaPublicacionDateTimePicker.Value.ToString());
                int copiasDisponibles = Convert.ToInt32(copiasDisponiblesTextBox.Text);

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
                    CopiasDisponibles = Convert.ToInt32(copiasDisponiblesTextBox.Text),
                    IdCategoria = 1
                };

                _libroServicio.AgregarLibro(libro);

                _gestionarLibrosForm.CargarLibros();
                this.Close();

            }

        }

    }
}
