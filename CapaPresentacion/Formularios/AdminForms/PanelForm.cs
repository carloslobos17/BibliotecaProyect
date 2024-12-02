using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Drawing;
using CapaNegocios.Servicios.PanelServicios;
using System.Collections;

namespace CapaPresentacion.Formularios.AdminForms
{
    public partial class PanelForm : Form
    {
        private readonly IPanelServicio _panelServicio;
        public PanelForm(IPanelServicio panelServicio)
        {
            InitializeComponent();
            bibliotecariosPanel.MouseEnter += bibliotecariosPanel_MouseEnter;
            bibliotecariosPanel.MouseEnter += bibliotecariosPanel_MouseEnter;
            _panelServicio = panelServicio;
            CargarDatosPanel();
            GraficarLibrosPopulares();
            categoriaLibros();


        }

        public void CargarDatosPanel()
        {
            cantidadBibliotecarioLabel.Text = _panelServicio.BibliotecariosRegistrados().ToString();
            cantidadLibrosLabel.Text = _panelServicio.CantidadLibros().ToString();
            cantidadPrestamosLabel.Text = _panelServicio.CantidadPrestamos().ToString();
            cantidadDevolucionesLabel.Text = _panelServicio.CantidadDevoluciones().ToString();

        }
        private void bibliotecariosPanel_MouseEnter(object sender, EventArgs e)
        {
            bibliotecariosPanel.BackColor = Color.FromArgb(37, 53, 68);
            tituloBibliotecariosLabel.ForeColor = Color.White;
            cantidadBibliotecarioLabel.ForeColor = Color.White;
            bibliotecarioIconPictureBox.IconColor = Color.White;
        }

        private void bibliotecariosPanel_MouseLeave(object sender, EventArgs e)
        {
            bibliotecariosPanel.BackColor = Color.White;
            tituloBibliotecariosLabel.ForeColor = Color.Black;
            cantidadBibliotecarioLabel.ForeColor = Color.Black;
            bibliotecarioIconPictureBox.IconColor = Color.Black;
        }

        private void librosPanel_MouseEnter(object sender, EventArgs e)
        {
            librosPanel.BackColor = Color.FromArgb(37, 53, 68);
            tituloLibrosLabel.ForeColor = Color.White;
            cantidadLibrosLabel.ForeColor = Color.White;
            librosIconPictureBox.IconColor = Color.White;

        }

        private void librosPanel_MouseLeave(object sender, EventArgs e)
        {
            librosPanel.BackColor = Color.White;
            tituloLibrosLabel.ForeColor = Color.Black;
            cantidadLibrosLabel.ForeColor = Color.Black;
            librosIconPictureBox.IconColor = Color.Black;
        }

        private void prestamosPanel_MouseEnter(object sender, EventArgs e)
        {
            prestamosPanel.BackColor = Color.FromArgb(37, 53, 68);
            tituloPrestamosLabel.ForeColor = Color.White;
            cantidadPrestamosLabel.ForeColor = Color.White;
            prestamosIconPictureBox.IconColor = Color.White;
        }

        private void prestamosPanel_MouseLeave(object sender, EventArgs e)
        {
            prestamosPanel.BackColor = Color.White;
            tituloPrestamosLabel.ForeColor = Color.Black;
            cantidadPrestamosLabel.ForeColor = Color.Black;
            prestamosIconPictureBox.IconColor = Color.Black;
        }

        private void devolucionesPanel_MouseLeave(object sender, EventArgs e)
        {
            devolucionesPanel.BackColor = Color.White;
            tituloDevolucionesLabel.ForeColor = Color.Black;
            cantidadDevolucionesLabel.ForeColor = Color.Black;
            devolucionesIconPictureBox.IconColor = Color.Black;
        }

        private void devolucionesPanel_MouseEnter(object sender, EventArgs e)
        {
            devolucionesPanel.BackColor = Color.FromArgb(37, 53, 68);
            tituloDevolucionesLabel.ForeColor = Color.White;
            cantidadDevolucionesLabel.ForeColor = Color.White;
            devolucionesIconPictureBox.IconColor = Color.White;
        }

        private void GraficarLibrosPopulares()
        {

            var librosPopulares = _panelServicio.ObtenerLibrosMasPrestados();

           
            ArrayList libros = new ArrayList();
            ArrayList cantidades = new ArrayList();

            
            foreach (var libro in librosPopulares)
            {
                libros.Add(libro.Libro);      
                cantidades.Add(libro.Cantidad); 
            }

            librosPopularesChart.Series[0].Points.DataBindXY(libros, cantidades);

        }

        private void categoriaLibros()
        {
            var categoriaLibros = _panelServicio.ObtenerCantidadCategorias();


            ArrayList categoria = new ArrayList();
            ArrayList cantidades = new ArrayList();


            foreach (var c in categoriaLibros)
            {
                categoria.Add(c.Categoria);
                cantidades.Add(c.Cantidad);
            }

            cantidadCategoriaChart.Series[0].Points.DataBindXY(categoria, cantidades);
        }
    }
}
