using CapaEntidad.Entidades;
using CapaEntidad.Enums;
using CapaNegocios.Servicios.GestionUsuarioServicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.AdminForms.Modal
{
    public partial class ModalBibliotecario : Form
    {

        private readonly IGestionUsuarioServicio _gestionUsuarioServicio;

        private readonly BibliotecariosForm _bibliotecariosForm;

        public bool editMode = false;

        public int idUsuario = 0;

        public ModalBibliotecario(IGestionUsuarioServicio gestionUsuarioServicio, BibliotecariosForm bibliotecariosForm)
        {
            InitializeComponent();
            _gestionUsuarioServicio = gestionUsuarioServicio;
            _bibliotecariosForm = bibliotecariosForm;
        }

        private void guardarBibliotecarioButton_Click(object sender, EventArgs e)
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

                _gestionUsuarioServicio.EditarUsuario(usuario);
                _bibliotecariosForm.CargarBibliotecarios();
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
                    IdRol = (int)RolEnum.Bibliotecario
                };

                _gestionUsuarioServicio.AgregarUsuario(usuario);

                _bibliotecariosForm.CargarBibliotecarios();
                this.Close();
            }
        }
    }
}
