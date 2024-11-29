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
using FluentValidation.Results;
using CapaPresentacion.Validaciones;

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
                int edad = Convert.ToInt32(edadNumericUpDown.Text);
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
                    Edad = int.Parse(edadNumericUpDown.Text),
                    Clave = claveTextBox.Text,
                    Telefono = telefonoTextBox.Text,
                    Correo = correoTextBox.Text,
                    IdRol = (int)RolEnum.Bibliotecario
                };


                ValidacionUsuario validacionUsuario = new ValidacionUsuario();
                ValidationResult result = validacionUsuario.Validate(usuario);

                if (!result.IsValid)
                {
                    MostrarErroresValidacion(result);
                }
                else
                {
                    _gestionUsuarioServicio.AgregarUsuario(usuario);
                    _bibliotecariosForm.CargarBibliotecarios();
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
                    case nameof(Usuario.Nombre):
                        validacionErrorProvider.SetError(nombreTextBox, error.ErrorMessage);
                        break;
                    case nameof(Usuario.Apellido):
                        validacionErrorProvider.SetError(apellidoTextBox, error.ErrorMessage);
                        break;
                    case nameof(Usuario.Edad):
                        validacionErrorProvider.SetError(edadNumericUpDown, error.ErrorMessage);
                        break;
                    case nameof(Usuario.Clave):
                        validacionErrorProvider.SetError(claveTextBox, error.ErrorMessage);
                        break;
                    case nameof(Usuario.Telefono):
                        validacionErrorProvider.SetError(telefonoTextBox, error.ErrorMessage);
                        break;
                    case nameof(Usuario.Correo):
                        validacionErrorProvider.SetError(correoTextBox, error.ErrorMessage);
                        break;
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
