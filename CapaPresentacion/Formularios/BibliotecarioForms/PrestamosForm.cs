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
using CapaNegocios.Servicios.PrestamoServicios;

namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    public partial class PrestamosForm : Form
    {
        private readonly IPrestamoServicio _prestamoServicio;
        public PrestamosForm(IPrestamoServicio prestamoServicio)
        {
            InitializeComponent();
            _prestamoServicio = prestamoServicio;
        }

        private void prestarLibroButton_Click(object sender, EventArgs e)
        {
            int idEstudiante = 4;
            int idLibro = 5;
            DateTime fechaPrestamo = fechaPrestamoDateTimePicker.Value;
            DateTime fechaDevolucion = fechaDevolucionDateTimePicker.Value;
            bool Estado = true;

            var prestamo = new Prestamo
            {
                IdUsuario = idEstudiante,
                IdLibro = idLibro,
                FechaPrestamo = fechaPrestamo,
                FechaDevolucion = fechaDevolucion,
                Activo = Estado
            };

            _prestamoServicio.AgregarPrestamo(prestamo);
        }
    }
}
