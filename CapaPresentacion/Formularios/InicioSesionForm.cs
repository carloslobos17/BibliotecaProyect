using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios.Servicios;
namespace CapaPresentacion.Formulario
{
    public partial class LoginFormulario : Form
    {
        private UsuarioServicio _usuarioServicio;

        public LoginFormulario()
        {
            InitializeComponent();
            _usuarioServicio = new UsuarioServicio();
        }

        private void iniciarBtn_Click(object sender, EventArgs e)
        {
            string usuario = usuarioLoginTextBox.Text;
            string clave = claveLoginTextBox.Text;
            int autenticar = _usuarioServicio.AutenticarUsuario(usuario, clave);

            if (autenticar == 0)
            {
                errorLoginLabel.Text = "Usuario o contraseña incorrecta";
            }
            else
            {
                string rol = _usuarioServicio.ObtenerRol(autenticar);

                PrincipalForm principalForm = new PrincipalForm(rol);
                principalForm.Show();
                this.Hide();
            }


        }

        
    }
}

