using CapaNegocios.Servicios.AdministradorServicios;
using CapaNegocios.Servicios.GestionUsuarioServicios;
using CapaPresentacion.Formularios.AdminForms.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.AdminForms
{
    public partial class AdministradorForm : Form
    {
        private readonly IAdministradorServicio _administradorServicio;
        public AdministradorForm(IAdministradorServicio administradorServicio)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _administradorServicio = administradorServicio;
            CargarAdministrador();
        }
        public void CargarAdministrador()
        {
            administradorDataGridView.DataSource = _administradorServicio.ObtenerAdministrador();
            administradorDataGridView.Refresh();
        }

        private void agregarAdministradorButton_Click(object sender, EventArgs e)
        {
            ModalAdministrador modalAdministrador = new ModalAdministrador(_administradorServicio, this);
            modalAdministrador.StartPosition = FormStartPosition.CenterScreen;
            modalAdministrador.ShowDialog();
        }

        private void editarAdministradorButton_Click(object sender, EventArgs e)
        {
            ModalAdministrador modalAdministrador = new ModalAdministrador(_administradorServicio, this);
            modalAdministrador.StartPosition = FormStartPosition.CenterScreen;
            if (administradorDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debes seleccionar", "cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                modalAdministrador.idUsuario = Convert.ToInt32(administradorDataGridView.CurrentRow.Cells[0].Value);
                modalAdministrador.nombreTextBox.Text = administradorDataGridView.CurrentRow.Cells[1].Value.ToString();
                modalAdministrador.apellidoTextBox.Text = administradorDataGridView.CurrentRow.Cells[2].Value.ToString();
                modalAdministrador.edadTextBox.Text = administradorDataGridView.CurrentRow.Cells[3].Value.ToString();
                modalAdministrador.claveTextBox.Text = administradorDataGridView.CurrentRow.Cells[4].Value.ToString();
                modalAdministrador.telefonoTextBox.Text = administradorDataGridView.CurrentRow.Cells[5].Value.ToString();
                modalAdministrador.correoTextBox.Text = administradorDataGridView.CurrentRow.Cells[6].Value.ToString();
                modalAdministrador.editMode = true;
                if (modalAdministrador.ShowDialog() == DialogResult.OK)
                {
                    CargarAdministrador();
                }
            }
        }

        private void eliminarAdministradorButton_Click(object sender, EventArgs e)
        {
            if (administradorDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debes seleccionar", "cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var deleteConfirm = new DialogResult();

                deleteConfirm = MessageBox.Show("Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(administradorDataGridView.CurrentRow.Cells[0].Value);
                    _administradorServicio.EliminarAdministrador(id);
                    CargarAdministrador();
                }
            }
        }
    }
}
