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
           
            var usuario = _usuarioServicio.Inicio(correoLoginTextBox.Text, claveLoginTextBox.Text);

            if (usuario != null)
            {
                UsuarioVerificado.Correo = usuario.Correo;
                UsuarioVerificado.RolId = usuario.Id;

                var principalForm = _serviceProvider.GetRequiredService<PrincipalForm>();   
                principalForm.ShowDialog();
                this.Hide();

               
            }


        }

        
    }
}

