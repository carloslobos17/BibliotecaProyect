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

                switch (rol)
                {
                    case "Administrador":
                        AdminForm adminForm = new AdminForm();
                        adminForm.ShowDialog();
                        break;

                    case "Bibliotecario":
                        BibliotecarioForm bibliotecarioForm = new BibliotecarioForm();
                        bibliotecarioForm.ShowDialog();
                        break;

                    case "Estudiante":
                        EstudianteForm estudianteForm = new EstudianteForm();
                        estudianteForm.ShowDialog();
                        break;

                    default:
                        break;


                }
            }


        }
    }
}

