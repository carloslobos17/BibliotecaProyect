﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Formularios.AdminForms;
using CapaPresentacion.Formularios.BibliotecarioForms;
using CapaPresentacion.Formularios.EstudianteForms;

namespace CapaPresentacion
{
    public partial class PrincipalForm : Form
    {
        public string Rol { get; private set; }
        public PrincipalForm()
        {
            InitializeComponent();
        }

        public PrincipalForm(string rol) : this()
        {
            Rol = rol;
        }



        private void cerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            if (Rol == "Administrador")
            {
                gestionarLibrosButton.Visible = false;
                prestamosButton.Visible = false;
                devolucionesButton.Visible = false;
                librosButton.Visible = false;
                historialButton.Visible = false;
            }
            else if (Rol == "Bibliotecario")
            {
                panelControlButton.Visible = false;
                bibliotecariosButton.Visible = false;
                librosButton.Visible = false;
                historialButton.Visible = false;

                gestionarLibrosButton.Location = panelControlButton.Location;
                prestamosButton.Location = bibliotecariosButton.Location;
            }
            else if (Rol == "Estudiante")
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
            AbrirFormHijo(new BibliotecariosForm());
        }

        private void gestionarLibrosButton_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new GestionarLibrosForm());
        }

        private void prestamosButton_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new PrestamosForm());
        }

        private void devolucionesButton_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new DevolucionesForm());
        }

        private void librosButton_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new GestionarLibrosForm());
        }

        private void historialButton_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new HistorialForm());
        }
    }
}
