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
using CapaEntidad.Enums;
using CapaPresentacion.Formulario;
using CapaPresentacion.Formularios.AdminForms;
using CapaPresentacion.Formularios.BibliotecarioForms;
using CapaPresentacion.Formularios.EstudianteForms;
using Microsoft.Extensions.DependencyInjection;

namespace CapaPresentacion
{
    public partial class PrincipalForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public string Rol { get; private set; }
        public PrincipalForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            EstablecerPermisos();
            _serviceProvider = serviceProvider;
        }

        private void EstablecerPermisos()
        {
            if (UsuarioVerificado.RolId == (int)RolEnum.Admin)
            {
                gestionarLibrosButton.Visible = false;
                prestamosButton.Visible = false;
                devolucionesButton.Visible = false;
                librosButton.Visible = false;
                historialButton.Visible = false;
            }

            if (UsuarioVerificado.RolId == (int)RolEnum.Bibliotecario)
            {
                panelControlButton.Visible = false;
                bibliotecariosButton.Visible = false;
                librosButton.Visible = false;
                historialButton.Visible = false;

                gestionarLibrosButton.Location = panelControlButton.Location;
                prestamosButton.Location = bibliotecariosButton.Location;
            }

            if (UsuarioVerificado.RolId == (int)RolEnum.Estudiante)
            {
                panelControlButton.Visible = false;
                bibliotecariosButton.Visible = false;
                gestionarLibrosButton.Visible = false;
                prestamosButton.Visible = false;
                devolucionesButton.Visible = false;

                librosButton.Location = panelControlButton.Location;
                historialButton.Location = bibliotecariosButton.Location;
            }
        }


        private void AbrirFormHijo(object formHijo)
        {
            if (this.contenedorPanel.Controls.Count > 0)
                this.contenedorPanel.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenedorPanel.Controls.Add(fh);
            this.contenedorPanel.Tag = fh;
            fh.Show();
        }

        private void panelControlButton_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new PanelForm());
        }

        private void bibliotecariosButton_Click(object sender, EventArgs e)
        {
            var bibliotecariosForm = _serviceProvider.GetRequiredService<BibliotecariosForm>();
            AbrirFormHijo(bibliotecariosForm);
        }

        private void gestionarLibrosButton_Click(object sender, EventArgs e)
        {
            var gestionarLibrosForm = _serviceProvider.GetRequiredService<GestionarLibrosForm>();
            AbrirFormHijo(gestionarLibrosForm);
        }

        private void prestamosButton_Click(object sender, EventArgs e)
        {
            var prestamosForm = _serviceProvider.GetRequiredService<PrestamosForm>();
            AbrirFormHijo(prestamosForm);
        }

        private void devolucionesButton_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new DevolucionesForm());
        }

        private void librosButton_Click(object sender, EventArgs e)
        {
            var gestionarLibrosForm = _serviceProvider.GetRequiredService<GestionarLibrosForm>();
            AbrirFormHijo(gestionarLibrosForm);
        }

        private void historialButton_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new HistorialForm());
        }

        private void salirIconPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PrincipalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var loginForm = _serviceProvider.GetRequiredService<LoginFormulario>();
            loginForm.ShowDialog();
        }

        private void estudiantesButton_Click(object sender, EventArgs e)
        {
            var estudiantesForm = _serviceProvider.GetRequiredService<EstudiantesForm>();
            AbrirFormHijo(estudiantesForm);
        }
    }
}
