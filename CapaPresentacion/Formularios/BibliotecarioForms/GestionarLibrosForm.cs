using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Formularios.AdminForms.Modal;
using CapaPresentacion.Formularios.BibliotecarioForms.Modal;

namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    public partial class GestionarLibrosForm : Form
    {
        public GestionarLibrosForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

       
        private void agregarLibroButton_Click(object sender, EventArgs e)
        {
            ModalGestionarLibros modalGestionarLibros = new ModalGestionarLibros();
            modalGestionarLibros.StartPosition = FormStartPosition.CenterScreen;

            modalGestionarLibros.Show();
        }
    }
}
