using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoDatos.Repositorios.GestionUsuarioRepositorios;
using CapaNegocios.Servicios.GestionUsuarioServicios;
using CapaPresentacion.Formularios.AdminForms.Modal;

namespace CapaPresentacion.Formularios.AdminForms
{
    public partial class BibliotecariosForm : Form
    {
        private readonly IGestionUsuarioServicio _gestionUsuarioServicio;

        public BibliotecariosForm(IGestionUsuarioServicio gestionUsuarioServicio)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _gestionUsuarioServicio = gestionUsuarioServicio;
            CargarBibliotecarios();
        }

        private void agregarBibliotecarioButton_Click(object sender, EventArgs e)
        {
            ModalBibliotecario modalBibliotecario = new ModalBibliotecario(_gestionUsuarioServicio, this);
            modalBibliotecario.StartPosition = FormStartPosition.CenterScreen;
            modalBibliotecario.Show();
        }

        public void CargarBibliotecarios()
        {
            bibliotecariosDataGridView.DataSource = _gestionUsuarioServicio.ObtenerUsuarios();
            bibliotecariosDataGridView.Refresh();
        }
        private void editarBibliotecarioButton_Click(object sender, EventArgs e)
        {
            ModalBibliotecario modalBibliotecario = new ModalBibliotecario(_gestionUsuarioServicio, this);
            modalBibliotecario.StartPosition = FormStartPosition.CenterScreen;
            if (bibliotecariosDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debes seleccionar", "cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                modalBibliotecario.idUsuario = Convert.ToInt32(bibliotecariosDataGridView.CurrentRow.Cells[0].Value);
                modalBibliotecario.nombreTextBox.Text = bibliotecariosDataGridView.CurrentRow.Cells[1].Value.ToString();
                modalBibliotecario.apellidoTextBox.Text = bibliotecariosDataGridView.CurrentRow.Cells[2].Value.ToString();
                modalBibliotecario.edadTextBox.Text = bibliotecariosDataGridView.CurrentRow.Cells[3].Value.ToString();
                modalBibliotecario.claveTextBox.Text = bibliotecariosDataGridView.CurrentRow.Cells[4].Value.ToString();
                modalBibliotecario.telefonoTextBox.Text = bibliotecariosDataGridView.CurrentRow.Cells[5].Value.ToString();
                modalBibliotecario.correoTextBox.Text = bibliotecariosDataGridView.CurrentRow.Cells[6].Value.ToString();
                modalBibliotecario.editMode = true;
                if (modalBibliotecario.ShowDialog() == DialogResult.OK)
                {
                    CargarBibliotecarios();
                }
            }
        }

        private void eliminarBibliotecarioButton_Click(object sender, EventArgs e)
        {
            if (bibliotecariosDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debes seleccionar", "cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var deleteConfirm = new DialogResult();

                deleteConfirm = MessageBox.Show("Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(bibliotecariosDataGridView.CurrentRow.Cells[0].Value);
                    _gestionUsuarioServicio.EliminarUsuario(id);
                    CargarBibliotecarios();
                }
            }
        }
    }
}
