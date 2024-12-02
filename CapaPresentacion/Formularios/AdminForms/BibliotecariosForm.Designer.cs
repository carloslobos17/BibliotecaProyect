namespace CapaPresentacion.Formularios.AdminForms
{
    partial class BibliotecariosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BibliotecariosForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            eliminarBibliotecarioButton = new FontAwesome.Sharp.IconButton();
            agregarBibliotecarioButton = new FontAwesome.Sharp.IconButton();
            editarBibliotecarioButton = new FontAwesome.Sharp.IconButton();
            bibliotecariosDataGridView = new DataGridView();
            menuBibliotecariosGroupBox = new GroupBox();
            cargarBibliotecariosButton = new Button();
            filtrarBibliotecariosButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bibliotecariosDataGridView).BeginInit();
            menuBibliotecariosGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.ForeColor = Color.FromArgb(162, 129, 112);
            panel1.Location = new Point(298, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 12);
            panel1.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(317, 54);
            label2.Name = "label2";
            label2.Size = new Size(452, 42);
            label2.TabIndex = 32;
            label2.Text = "Gestión de bibliotecarios";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // eliminarBibliotecarioButton
            // 
            eliminarBibliotecarioButton.BackColor = Color.DarkRed;
            eliminarBibliotecarioButton.FlatStyle = FlatStyle.Flat;
            eliminarBibliotecarioButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminarBibliotecarioButton.ForeColor = SystemColors.MenuBar;
            eliminarBibliotecarioButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            eliminarBibliotecarioButton.IconColor = SystemColors.MenuBar;
            eliminarBibliotecarioButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarBibliotecarioButton.IconSize = 40;
            eliminarBibliotecarioButton.ImageAlign = ContentAlignment.MiddleLeft;
            eliminarBibliotecarioButton.Location = new Point(816, 363);
            eliminarBibliotecarioButton.Margin = new Padding(0);
            eliminarBibliotecarioButton.Name = "eliminarBibliotecarioButton";
            eliminarBibliotecarioButton.Size = new Size(144, 49);
            eliminarBibliotecarioButton.TabIndex = 30;
            eliminarBibliotecarioButton.Text = "Eliminar";
            eliminarBibliotecarioButton.TextAlign = ContentAlignment.MiddleRight;
            eliminarBibliotecarioButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            eliminarBibliotecarioButton.UseVisualStyleBackColor = false;
            eliminarBibliotecarioButton.Click += eliminarBibliotecarioButton_Click;
            // 
            // agregarBibliotecarioButton
            // 
            agregarBibliotecarioButton.BackColor = Color.FromArgb(58, 157, 35);
            agregarBibliotecarioButton.FlatStyle = FlatStyle.Flat;
            agregarBibliotecarioButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarBibliotecarioButton.ForeColor = SystemColors.MenuBar;
            agregarBibliotecarioButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            agregarBibliotecarioButton.IconColor = SystemColors.MenuBar;
            agregarBibliotecarioButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            agregarBibliotecarioButton.IconSize = 40;
            agregarBibliotecarioButton.ImageAlign = ContentAlignment.MiddleLeft;
            agregarBibliotecarioButton.Location = new Point(816, 243);
            agregarBibliotecarioButton.Margin = new Padding(0);
            agregarBibliotecarioButton.Name = "agregarBibliotecarioButton";
            agregarBibliotecarioButton.Size = new Size(144, 48);
            agregarBibliotecarioButton.TabIndex = 28;
            agregarBibliotecarioButton.Text = "Agregar";
            agregarBibliotecarioButton.TextAlign = ContentAlignment.MiddleRight;
            agregarBibliotecarioButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            agregarBibliotecarioButton.UseVisualStyleBackColor = false;
            agregarBibliotecarioButton.Click += agregarBibliotecarioButton_Click;
            // 
            // editarBibliotecarioButton
            // 
            editarBibliotecarioButton.BackColor = Color.SteelBlue;
            editarBibliotecarioButton.FlatStyle = FlatStyle.Flat;
            editarBibliotecarioButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editarBibliotecarioButton.ForeColor = SystemColors.MenuBar;
            editarBibliotecarioButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editarBibliotecarioButton.IconColor = SystemColors.MenuBar;
            editarBibliotecarioButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editarBibliotecarioButton.IconSize = 40;
            editarBibliotecarioButton.ImageAlign = ContentAlignment.MiddleLeft;
            editarBibliotecarioButton.Location = new Point(816, 299);
            editarBibliotecarioButton.Margin = new Padding(0);
            editarBibliotecarioButton.Name = "editarBibliotecarioButton";
            editarBibliotecarioButton.Size = new Size(144, 48);
            editarBibliotecarioButton.TabIndex = 29;
            editarBibliotecarioButton.Text = "Editar";
            editarBibliotecarioButton.TextAlign = ContentAlignment.MiddleRight;
            editarBibliotecarioButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            editarBibliotecarioButton.UseVisualStyleBackColor = false;
            editarBibliotecarioButton.Click += editarBibliotecarioButton_Click;
            // 
            // bibliotecariosDataGridView
            // 
            bibliotecariosDataGridView.AllowUserToAddRows = false;
            bibliotecariosDataGridView.AllowUserToDeleteRows = false;
            bibliotecariosDataGridView.AllowUserToResizeColumns = false;
            bibliotecariosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            bibliotecariosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            bibliotecariosDataGridView.BackgroundColor = SystemColors.ControlLight;
            bibliotecariosDataGridView.BorderStyle = BorderStyle.None;
            bibliotecariosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            bibliotecariosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            bibliotecariosDataGridView.Location = new Point(80, 243);
            bibliotecariosDataGridView.Name = "bibliotecariosDataGridView";
            bibliotecariosDataGridView.RowHeadersWidth = 51;
            bibliotecariosDataGridView.Size = new Size(719, 471);
            bibliotecariosDataGridView.TabIndex = 27;
            // 
            // menuBibliotecariosGroupBox
            // 
            menuBibliotecariosGroupBox.Controls.Add(cargarBibliotecariosButton);
            menuBibliotecariosGroupBox.Controls.Add(filtrarBibliotecariosButton);
            menuBibliotecariosGroupBox.Location = new Point(80, 144);
            menuBibliotecariosGroupBox.Margin = new Padding(3, 4, 3, 4);
            menuBibliotecariosGroupBox.Name = "menuBibliotecariosGroupBox";
            menuBibliotecariosGroupBox.Padding = new Padding(3, 4, 3, 4);
            menuBibliotecariosGroupBox.Size = new Size(719, 81);
            menuBibliotecariosGroupBox.TabIndex = 43;
            menuBibliotecariosGroupBox.TabStop = false;
            menuBibliotecariosGroupBox.Text = "Ordenar A-z";
            // 
            // cargarBibliotecariosButton
            // 
            cargarBibliotecariosButton.BackColor = SystemColors.ActiveBorder;
            cargarBibliotecariosButton.Location = new Point(134, 27);
            cargarBibliotecariosButton.Margin = new Padding(3, 4, 3, 4);
            cargarBibliotecariosButton.Name = "cargarBibliotecariosButton";
            cargarBibliotecariosButton.Size = new Size(104, 46);
            cargarBibliotecariosButton.TabIndex = 1;
            cargarBibliotecariosButton.Text = "Cargar";
            cargarBibliotecariosButton.UseVisualStyleBackColor = false;
            cargarBibliotecariosButton.Click += cargarBibliotecariosButton_Click;
            // 
            // filtrarBibliotecariosButton
            // 
            filtrarBibliotecariosButton.BackColor = Color.FromArgb(128, 64, 0);
            filtrarBibliotecariosButton.ForeColor = SystemColors.ButtonFace;
            filtrarBibliotecariosButton.Location = new Point(23, 28);
            filtrarBibliotecariosButton.Margin = new Padding(3, 4, 3, 4);
            filtrarBibliotecariosButton.Name = "filtrarBibliotecariosButton";
            filtrarBibliotecariosButton.Size = new Size(85, 45);
            filtrarBibliotecariosButton.TabIndex = 0;
            filtrarBibliotecariosButton.Text = "Filtrar";
            filtrarBibliotecariosButton.UseVisualStyleBackColor = false;
            filtrarBibliotecariosButton.Click += filtrarBibliotecariosButton_Click;
            // 
            // BibliotecariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1080, 780);
            Controls.Add(menuBibliotecariosGroupBox);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(eliminarBibliotecarioButton);
            Controls.Add(agregarBibliotecarioButton);
            Controls.Add(editarBibliotecarioButton);
            Controls.Add(bibliotecariosDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BibliotecariosForm";
            Text = "BibliotecariosForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bibliotecariosDataGridView).EndInit();
            menuBibliotecariosGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton eliminarBibliotecarioButton;
        private FontAwesome.Sharp.IconButton agregarBibliotecarioButton;
        private FontAwesome.Sharp.IconButton editarBibliotecarioButton;
        private DataGridView bibliotecariosDataGridView;
        private GroupBox menuBibliotecariosGroupBox;
        private Button cargarBibliotecariosButton;
        private Button filtrarBibliotecariosButton;
    }
}