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
using CapaNegocios.Servicios.DevolucionServicios;

namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    public partial class DevolucionesForm : Form
    {
        private readonly IDevolucionServicio _devolucionServicio;
        public DevolucionesForm(IDevolucionServicio devolucionServicio)
        {
            InitializeComponent();
            _devolucionServicio = devolucionServicio;
            CargarEstudiantes();
            CargarLibros();
        }

        private void CargarEstudiantes()
        {
            estudiantesComboBox.DataSource = _devolucionServicio.ObtenerEstudiantes();
            estudiantesComboBox.ValueMember = "Id";
            estudiantesComboBox.DisplayMember = "Nombre";
        }

        private void CargarLibros()
        {
            librosComboBox.DataSource = _devolucionServicio.ObtenerLibros();
            librosComboBox.ValueMember = "Id";
            librosComboBox.DisplayMember = "Titulo";
        }
        private void devolverButton_Click(object sender, EventArgs e)
        {
            int idEstudiante = int.Parse(estudiantesComboBox.SelectedValue.ToString());
            int idLibro = int.Parse(librosComboBox.SelectedValue.ToString());
            bool estado = false;

            int idPrestamo = _devolucionServicio.ObtenerIdPrestamo(idEstudiante, idLibro);
            DateTime fechaDevolucion = fechaDevolucionDateTimePicker.Value;
            string observaciones = observacionesTextBox.Text;
            
            var devolucion = new Devolucion
            {
               FechaDevolucion = fechaDevolucion,
               Observaciones = observaciones,
               IdPrestamo = idPrestamo
            };

            _devolucionServicio.AgregarDevolucion(devolucion, idLibro, estado);

        }
    }
}
