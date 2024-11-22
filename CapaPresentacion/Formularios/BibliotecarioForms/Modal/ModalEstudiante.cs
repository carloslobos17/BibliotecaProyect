using CapaEntidad.Entidades;
using CapaEntidad.Enums;
using CapaNegocios.Servicios.EstudianteServicios;
using CapaNegocios.Servicios.GestionUsuarioServicios;
using CapaPresentacion.Formularios.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.BibliotecarioForms.Modal
{
    public partial class ModalEstudiante : Form
    {
        private readonly IEstudianteServicio _estudianteServicio;

        private readonly EstudiantesForm _estudiantesForm;

        public bool editMode = false;

        public int idUsuario = 0;
        public ModalEstudiante(IEstudianteServicio estudianteServicio, EstudiantesForm estudiantesForm)
        {
            InitializeComponent();
            _estudianteServicio = estudianteServicio;
            _estudiantesForm = estudiantesForm;
        }

        private void guardarEstudianteButton_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                int id = idUsuario;
                string nombre = nombreTextBox.Text;
                string apellido = apellidoTextBox.Text;
                int edad = Convert.ToInt32(edadTextBox.Text);
                string clave = claveTextBox.Text;
                string telefono = telefonoTextBox.Text;
                string correo = correoTextBox.Text;

                var usuario = new Usuario
                {
                    Id = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Edad = edad,
                    Clave = clave,
                    Telefono = telefono,
                    Correo = correo
                };

                _estudianteServicio.EditarEstudiante(usuario);
                _estudiantesForm.CargarEstudiantes();
                this.Close();
                editMode = false;
            }
            else
            {
                var usuario = new Usuario
                {
                    Nombre = nombreTextBox.Text,
                    Apellido = apellidoTextBox.Text,
                    Edad = Convert.ToInt32(edadTextBox.Text),
                    Clave = claveTextBox.Text,
                    Telefono = telefonoTextBox.Text,
                    Correo = correoTextBox.Text,
                    IdRol = (int)RolEnum.Estudiante
                };

                _estudianteServicio.AgregarEstudiante(usuario);

                _estudiantesForm.CargarEstudiantes();
                this.Close();
            }
        }
    }
}
