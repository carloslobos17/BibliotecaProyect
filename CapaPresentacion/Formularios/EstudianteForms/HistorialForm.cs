using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios.Servicios.HistorialServicios;
using CapaEntidad.Entidades;

namespace CapaPresentacion.Formularios.EstudianteForms
{
    public partial class HistorialForm : Form
    {
        private readonly IHistorialServicio _historialServicio;
        public HistorialForm(IHistorialServicio historialServicio)
        {
            InitializeComponent();
            _historialServicio = historialServicio;
            historialDataGridView.DataSource = _historialServicio.ObtenerPrestamos(UsuarioVerificado.Id);
            historialDataGridView.Columns["Clave"].Visible = false;
        }

        private void prestamoHistorialButton_Click(object sender, EventArgs e)
        {
            historialDataGridView.DataSource = _historialServicio.ObtenerPrestamos(UsuarioVerificado.Id);
        }

        private void devolucionesHistorialButton_Click(object sender, EventArgs e)
        {
            historialDataGridView.DataSource = _historialServicio.ObtenerDevoluciones(UsuarioVerificado.Id);
        }
    }
}
