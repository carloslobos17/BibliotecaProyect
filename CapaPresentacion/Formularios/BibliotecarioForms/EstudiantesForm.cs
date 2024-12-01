
using CapaNegocios.Servicios.GestionUsuarioServicios;
using CapaPresentacion.Formularios.AdminForms.Modal;
using CapaPresentacion.Formularios.BibliotecarioForms.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    public partial class EstudiantesForm : Form
    {
        private readonly IGestionUsuarioServicio _gestionUsuarioServicio;
        public EstudiantesForm(IGestionUsuarioServicio gestionUsuarioServicio)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _gestionUsuarioServicio = gestionUsuarioServicio;
            CargarEstudiantes();
        }

        public void CargarEstudiantes()
        {
            estudiantesDataGridView.DataSource = _gestionUsuarioServicio.ObtenerEstudiantes();
            estudiantesDataGridView.Refresh();
            estudiantesDataGridView.Columns["Clave"].Visible = false;
        }

        private void agregarEstudianteButton_Click(object sender, EventArgs e)
        {
            ModalEstudiante modalEstudiante = new ModalEstudiante(_gestionUsuarioServicio, this);
            modalEstudiante.StartPosition = FormStartPosition.CenterScreen;
            modalEstudiante.ShowDialog();
        }

        private void editarEstudianteButton_Click(object sender, EventArgs e)
        {
            ModalEstudiante modalEstudiante = new ModalEstudiante(_gestionUsuarioServicio, this);
            modalEstudiante.StartPosition = FormStartPosition.CenterScreen;
            if (estudiantesDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debes seleccionar", "cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                modalEstudiante.idUsuario = Convert.ToInt32(estudiantesDataGridView.CurrentRow.Cells[0].Value);
                modalEstudiante.nombreTextBox.Text = estudiantesDataGridView.CurrentRow.Cells[1].Value.ToString();
                modalEstudiante.apellidoTextBox.Text = estudiantesDataGridView.CurrentRow.Cells[2].Value.ToString();
                modalEstudiante.edadNumericUpDown.Text = estudiantesDataGridView.CurrentRow.Cells[3].Value.ToString();
                modalEstudiante.claveTextBox.Text = estudiantesDataGridView.CurrentRow.Cells[4].Value.ToString();
                modalEstudiante.telefonoTextBox.Text = estudiantesDataGridView.CurrentRow.Cells[5].Value.ToString();
                modalEstudiante.correoTextBox.Text = estudiantesDataGridView.CurrentRow.Cells[6].Value.ToString();
                modalEstudiante.editMode = true;
                if (modalEstudiante.ShowDialog() == DialogResult.OK)
                {
                    CargarEstudiantes();
                }
            }
        }

        private void eliminarEstudianteButton_Click(object sender, EventArgs e)
        {
            if (estudiantesDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debes seleccionar", "cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var deleteConfirm = new DialogResult();

                deleteConfirm = MessageBox.Show("Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(estudiantesDataGridView.CurrentRow.Cells[0].Value);
                    _gestionUsuarioServicio.EliminarUsuario(id);
                    CargarEstudiantes();
                }
            }
        }

        private void filtrarEstudiantesButton_Click(object sender, EventArgs e)
        {

            var usuarios = _gestionUsuarioServicio.ObtenerUsuariosFiltrados();
            estudiantesDataGridView.DataSource = usuarios;
        }

        private void cargarEstudiantesButton_Click(object sender, EventArgs e)
        {
            CargarEstudiantes();
        }
    }
}
