﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios.Servicios.LibroServicios;
using CapaPresentacion.Formularios.AdminForms.Modal;
using CapaPresentacion.Formularios.BibliotecarioForms.Modal;

namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    public partial class GestionarLibrosForm : Form
    {
        private readonly ILibroServicio _libroServicio;
        public GestionarLibrosForm(ILibroServicio libroServicio)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _libroServicio = libroServicio;
            CargarLibros();
        }

        private void agregarLibroButton_Click(object sender, EventArgs e)
        {
            ModalGestionarLibros modalGestionarLibros = new ModalGestionarLibros(_libroServicio, this);
            modalGestionarLibros.StartPosition = FormStartPosition.CenterScreen;

            modalGestionarLibros.ShowDialog();
        }

        public void CargarLibros()
        {
            librosDataGridView.DataSource = _libroServicio.ObtenerLibros();
            librosDataGridView.Refresh();
        }

        private void editarLibroButton_Click(object sender, EventArgs e)
        {

            ModalGestionarLibros modalGestionarLibros = new ModalGestionarLibros(_libroServicio, this);
            modalGestionarLibros.StartPosition = FormStartPosition.CenterScreen;
            if (librosDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debes seleccionar","cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                modalGestionarLibros.idLibro = Convert.ToInt32(librosDataGridView.CurrentRow.Cells[0].Value);
                modalGestionarLibros.tituloTextBox.Text = librosDataGridView.CurrentRow.Cells[1].Value.ToString();
                modalGestionarLibros.autorTextBox.Text = librosDataGridView.CurrentRow.Cells[2].Value.ToString();
                modalGestionarLibros.fechaPublicacionDateTimePicker.Text = librosDataGridView.CurrentRow.Cells[3].Value.ToString();
                modalGestionarLibros.copiasDisponiblesTextBox.Text = librosDataGridView.CurrentRow.Cells[4].Value.ToString();
                modalGestionarLibros.editMode = true;
                if (modalGestionarLibros.ShowDialog() == DialogResult.OK)
                {
                    CargarLibros();
                }
            }

        }

        private void eliminarLibroButton_Click(object sender, EventArgs e)
        {
            if (librosDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debes seleccionar", "cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                var deleteConfirm = new DialogResult();

                deleteConfirm = MessageBox.Show("Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(librosDataGridView.CurrentRow.Cells[0].Value);
                    _libroServicio.EliminarLibro(id);
                    CargarLibros();
                }
            }

        }
    }
}
