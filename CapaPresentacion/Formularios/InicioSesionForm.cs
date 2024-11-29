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
using CapaNegocios.Servicios;
using CapaNegocios.Servicios.UsuarioServicios;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.Results;
using CapaPresentacion.Formularios.BibliotecarioForms;
using CapaPresentacion.Validaciones;
using CapaEntidad.Enums;

namespace CapaPresentacion.Formulario
{
    public partial class LoginFormulario : Form
    {
        private readonly IUsuarioServicio _usuarioServicio;
        private readonly IServiceProvider _serviceProvider;

        public LoginFormulario(IUsuarioServicio usuarioServicio, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _usuarioServicio = usuarioServicio;
            _serviceProvider = serviceProvider;
        }

        private void iniciarBtn_Click(object sender, EventArgs e)
        {

            var usuarioValidacion = new Usuario
            {
                Clave = claveSesionTextBox.Text,
                Correo = correoSesionTextBox.Text,
            };

            ValidacionInicioSesion validacionInicioSesion = new ValidacionInicioSesion();
            ValidationResult result = validacionInicioSesion.Validate(usuarioValidacion);

            if (!result.IsValid)
            {
                MostrarErroresValidacion(result);
            }
            else
            {
                var usuario = _usuarioServicio.Inicio(correoSesionTextBox.Text, claveSesionTextBox.Text);

                if (usuario != null)
                {
                    UsuarioVerificado.Id = usuario.Id;
                    UsuarioVerificado.Correo = usuario.Correo;
                    UsuarioVerificado.RolId = usuario.IdRol;
                    MessageBox.Show($"el id usuario es {UsuarioVerificado.Id}");

                    var principalForm = _serviceProvider.GetRequiredService<PrincipalForm>();
                    principalForm.ShowDialog();
                    this.Hide();


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
                    case nameof(Usuario.Correo):
                        validacionErrorProvider.SetError(correoSesionTextBox, error.ErrorMessage);
                        break;
                    case nameof(Usuario.Clave):
                        validacionErrorProvider.SetError(claveSesionTextBox, error.ErrorMessage);
                        break;
                }
            }
        }

    }
}

