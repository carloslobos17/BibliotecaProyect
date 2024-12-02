using CapaEntidad.Entidades;
using CapaNegocios.Servicios.CategoriaServicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using CapaPresentacion.Validaciones;

namespace CapaPresentacion.Formularios.BibliotecarioForms.Modal
{
    public partial class CategoriaForm : Form
    {
        private readonly ICategoriaServicios _categoriaServicios;
        public CategoriaForm(ICategoriaServicios categoriaServicios)
        {
            InitializeComponent();
            _categoriaServicios = categoriaServicios;
            CargarCategoríasDatos();
            CategoriadataGridView.CellClick += CategoriadataGridView_CellClick;
        }

        private void CategoriadataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                nombreCategoriaTextBox.Text = CategoriadataGridView.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        public void CargarCategoríasDatos()
        {
            if (_categoriaServicios != null)
            {
                var categorias = _categoriaServicios.ObtenerCategorias();
                if (categorias != null)
                {
                    CategoriadataGridView.DataSource = categorias;

                }
                else
                {
                    MessageBox.Show("No se encontraron categorías.");
                }
            }
            else
            {
                MessageBox.Show("El servicio de categorías no está inicializado.");
            }
        }

        private void agregarCategoriaButton_Click(object sender, EventArgs e)
        {
            var categoria = new Categoria
            {
                Nombre = nombreCategoriaTextBox.Text
            };

            ValidacionCategoria validacionCategoria = new ValidacionCategoria();
            ValidationResult result = validacionCategoria.Validate(categoria);

            if (!result.IsValid)
            {
                MostrarErroresValidacion(result);
            }
            else
            {
                _categoriaServicios.AgregarCategoria(categoria);
                CargarCategoríasDatos();
            }

        }

        private void editarCategoriaButton_Click(object sender, EventArgs e)
        {
            var categoria = new Categoria
            {
                Id = Convert.ToInt32(CategoriadataGridView.CurrentRow.Cells[0].Value.ToString()),
                Nombre = nombreCategoriaTextBox.Text
            };

            ValidacionCategoria validacionCategoria = new ValidacionCategoria();
            ValidationResult result = validacionCategoria.Validate(categoria);

            if (!result.IsValid)
            {
                MostrarErroresValidacion(result);
            }
            else
            {
                _categoriaServicios.EditarCategoria(categoria);
                CargarCategoríasDatos();
            }

        }

        private void eliminarCategoriaButton_Click(object sender, EventArgs e)
        {
            if (CategoriadataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debes seleccionar", "cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                var deleteConfirm = new DialogResult();

                deleteConfirm = MessageBox.Show("Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(CategoriadataGridView.CurrentRow.Cells[0].Value);
                    _categoriaServicios.EliminarCategoria(id);
                    CargarCategoríasDatos();
                }
            }
        }

        private void MostrarErroresValidacion(ValidationResult result)
        {
            validacionErrorProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Categoria.Nombre):
                        validacionErrorProvider.SetError(nombreCategoriaTextBox, error.ErrorMessage);
                        break;

                }
            }
        }

        private void cerrarIconButton_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
