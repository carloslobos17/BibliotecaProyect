﻿using System;
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
using CapaPresentacion.Validaciones;
using FluentValidation.Results;
using Microsoft.IdentityModel.Tokens;

namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    public partial class DevolucionesForm : Form
    {
        private readonly IDevolucionServicio _devolucionServicio;
        public DevolucionesForm(IDevolucionServicio devolucionServicio)
        {
            InitializeComponent();
            _devolucionServicio = devolucionServicio;
        }

        private void devolverButton_Click(object sender, EventArgs e)
        {
            if (prestamosDataGridView.CurrentRow != null)
            {
                bool estado = false;
                int idLibro = Convert.ToInt32(prestamosDataGridView.CurrentRow.Cells[4].Value);
                DateTime fechaDevolucion = fechaDevolucionDateTimePicker.Value;
                string observaciones = observacionesTextBox.Text;
                int idPrestamo = Convert.ToInt32(prestamosDataGridView.CurrentRow.Cells[0].Value);

                var devolucion = new Devolucion
                {
                    FechaDevolucion = fechaDevolucion,
                    Observaciones = observaciones,
                    IdPrestamo = idPrestamo

                };

                ValidacionDevolucion validacionDevolucion = new ValidacionDevolucion();
                ValidationResult result = validacionDevolucion.Validate(devolucion);

                if (!result.IsValid)
                {
                    MostrarErroresValidacion(result);
                }
                else
                {
                    _devolucionServicio.DevolverLibro(idLibro, estado, devolucion);
                    CargarPrestamosDatos();
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila en el DataGridView.");
            }

        }
        private void CargarPrestamosDatos()
        {
            prestamosDataGridView.DataSource = _devolucionServicio.ObtenerPrestamos();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            if (buscarTextBox.Text.IsNullOrEmpty())
            {
                CargarPrestamosDatos();
            }
            else
            {
                string busqueda = buscarTextBox.Text;
                var categories = _devolucionServicio.BuscarPrestamos(busqueda);
                prestamosDataGridView.DataSource = categories;
            }
        }

        private void MostrarErroresValidacion(ValidationResult result)
        {
            validacionErrorProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Devolucion.FechaDevolucion):
                        validacionErrorProvider.SetError(fechaDevolucionDateTimePicker, error.ErrorMessage);
                        break;
                    case nameof(Devolucion.Observaciones):
                        validacionErrorProvider.SetError(observacionesTextBox, error.ErrorMessage);
                        break;
                    
                }
            }
        }
    }
}
