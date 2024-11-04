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

namespace CapaPresentacion.Formularios.AdminForms
{
    public partial class BibliotecariosForm : Form
    {
        public BibliotecariosForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

       

        private void agregarLibroButton_Click(object sender, EventArgs e)
        {
            ModalBibliotecario modalBibliotecario = new ModalBibliotecario();
            modalBibliotecario.StartPosition = FormStartPosition.CenterScreen;
            modalBibliotecario.Show();
        }
    }
}
