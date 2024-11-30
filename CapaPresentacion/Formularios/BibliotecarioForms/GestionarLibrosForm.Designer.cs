namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    partial class GestionarLibrosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarLibrosForm));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            eliminarLibroButton = new FontAwesome.Sharp.IconButton();
            agregarLibroButton = new FontAwesome.Sharp.IconButton();
            editarLibroButton = new FontAwesome.Sharp.IconButton();
            librosDataGridView = new DataGridView();
            pictureBox2 = new PictureBox();
            categoriasButton = new FontAwesome.Sharp.IconButton();
            iniciarDateTimePicker = new DateTimePicker();
            finalizarDateTimePicker = new DateTimePicker();
            filtrarButton = new Button();
            cargarLibrosButton = new Button();
            groupBox1 = new GroupBox();
            fechaInicioLabel = new Label();
            fechaLimiteLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)librosDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.ForeColor = Color.FromArgb(162, 129, 112);
            panel1.Location = new Point(220, 99);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 9);
            panel1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(277, 65);
            label2.Name = "label2";
            label2.Size = new Size(257, 36);
            label2.TabIndex = 24;
            label2.Text = "Gestión de libros";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 56);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // eliminarLibroButton
            // 
            eliminarLibroButton.BackColor = Color.DarkRed;
            eliminarLibroButton.FlatStyle = FlatStyle.Flat;
            eliminarLibroButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminarLibroButton.ForeColor = SystemColors.MenuBar;
            eliminarLibroButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            eliminarLibroButton.IconColor = SystemColors.MenuBar;
            eliminarLibroButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarLibroButton.IconSize = 40;
            eliminarLibroButton.ImageAlign = ContentAlignment.MiddleLeft;
            eliminarLibroButton.Location = new Point(699, 279);
            eliminarLibroButton.Margin = new Padding(0);
            eliminarLibroButton.Name = "eliminarLibroButton";
            eliminarLibroButton.Size = new Size(126, 37);
            eliminarLibroButton.TabIndex = 21;
            eliminarLibroButton.Text = "Eliminar";
            eliminarLibroButton.TextAlign = ContentAlignment.MiddleRight;
            eliminarLibroButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            eliminarLibroButton.UseVisualStyleBackColor = false;
            eliminarLibroButton.Click += eliminarLibroButton_Click;
            // 
            // agregarLibroButton
            // 
            agregarLibroButton.BackColor = Color.FromArgb(58, 157, 35);
            agregarLibroButton.FlatStyle = FlatStyle.Flat;
            agregarLibroButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarLibroButton.ForeColor = SystemColors.MenuBar;
            agregarLibroButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            agregarLibroButton.IconColor = SystemColors.MenuBar;
            agregarLibroButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            agregarLibroButton.IconSize = 40;
            agregarLibroButton.ImageAlign = ContentAlignment.MiddleLeft;
            agregarLibroButton.Location = new Point(699, 177);
            agregarLibroButton.Margin = new Padding(0);
            agregarLibroButton.Name = "agregarLibroButton";
            agregarLibroButton.Size = new Size(126, 36);
            agregarLibroButton.TabIndex = 19;
            agregarLibroButton.Text = "Agregar";
            agregarLibroButton.TextAlign = ContentAlignment.MiddleRight;
            agregarLibroButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            agregarLibroButton.UseVisualStyleBackColor = false;
            agregarLibroButton.Click += agregarLibroButton_Click;
            // 
            // editarLibroButton
            // 
            editarLibroButton.BackColor = Color.SteelBlue;
            editarLibroButton.FlatStyle = FlatStyle.Flat;
            editarLibroButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editarLibroButton.ForeColor = SystemColors.MenuBar;
            editarLibroButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editarLibroButton.IconColor = SystemColors.MenuBar;
            editarLibroButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editarLibroButton.IconSize = 40;
            editarLibroButton.ImageAlign = ContentAlignment.MiddleLeft;
            editarLibroButton.Location = new Point(699, 226);
            editarLibroButton.Margin = new Padding(0);
            editarLibroButton.Name = "editarLibroButton";
            editarLibroButton.Size = new Size(126, 36);
            editarLibroButton.TabIndex = 20;
            editarLibroButton.Text = "Editar";
            editarLibroButton.TextAlign = ContentAlignment.MiddleRight;
            editarLibroButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            editarLibroButton.UseVisualStyleBackColor = false;
            editarLibroButton.Click += editarLibroButton_Click;
            // 
            // librosDataGridView
            // 
            librosDataGridView.AllowUserToAddRows = false;
            librosDataGridView.AllowUserToDeleteRows = false;
            librosDataGridView.AllowUserToResizeColumns = false;
            librosDataGridView.AllowUserToResizeRows = false;
            librosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            librosDataGridView.Location = new Point(113, 141);
            librosDataGridView.Margin = new Padding(3, 2, 3, 2);
            librosDataGridView.Name = "librosDataGridView";
            librosDataGridView.RowHeadersWidth = 51;
            librosDataGridView.Size = new Size(564, 333);
            librosDataGridView.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(699, 56);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // categoriasButton
            // 
            categoriasButton.BackColor = Color.FromArgb(128, 64, 0);
            categoriasButton.FlatStyle = FlatStyle.Flat;
            categoriasButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoriasButton.ForeColor = SystemColors.MenuBar;
            categoriasButton.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            categoriasButton.IconColor = SystemColors.MenuBar;
            categoriasButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            categoriasButton.IconSize = 40;
            categoriasButton.ImageAlign = ContentAlignment.MiddleLeft;
            categoriasButton.Location = new Point(699, 330);
            categoriasButton.Margin = new Padding(0);
            categoriasButton.Name = "categoriasButton";
            categoriasButton.Size = new Size(126, 36);
            categoriasButton.TabIndex = 27;
            categoriasButton.Text = "Categorias";
            categoriasButton.TextAlign = ContentAlignment.MiddleRight;
            categoriasButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            categoriasButton.UseVisualStyleBackColor = false;
            categoriasButton.Click += categoriasButton_Click;
            // 
            // iniciarDateTimePicker
            // 
            iniciarDateTimePicker.Location = new Point(83, 32);
            iniciarDateTimePicker.Name = "iniciarDateTimePicker";
            iniciarDateTimePicker.Size = new Size(244, 25);
            iniciarDateTimePicker.TabIndex = 28;
            // 
            // finalizarDateTimePicker
            // 
            finalizarDateTimePicker.Location = new Point(83, 79);
            finalizarDateTimePicker.Name = "finalizarDateTimePicker";
            finalizarDateTimePicker.Size = new Size(244, 25);
            finalizarDateTimePicker.TabIndex = 29;
            // 
            // filtrarButton
            // 
            filtrarButton.Location = new Point(426, 32);
            filtrarButton.Name = "filtrarButton";
            filtrarButton.Size = new Size(108, 27);
            filtrarButton.TabIndex = 30;
            filtrarButton.Text = "Filtrar Libros";
            filtrarButton.UseVisualStyleBackColor = true;
            filtrarButton.Click += filtrarButton_Click;
            // 
            // cargarLibrosButton
            // 
            cargarLibrosButton.Location = new Point(426, 74);
            cargarLibrosButton.Name = "cargarLibrosButton";
            cargarLibrosButton.Size = new Size(108, 27);
            cargarLibrosButton.TabIndex = 31;
            cargarLibrosButton.Text = "Cargar Libros";
            cargarLibrosButton.UseVisualStyleBackColor = true;
            cargarLibrosButton.Click += cargarLibrosButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fechaLimiteLabel);
            groupBox1.Controls.Add(fechaInicioLabel);
            groupBox1.Controls.Add(iniciarDateTimePicker);
            groupBox1.Controls.Add(cargarLibrosButton);
            groupBox1.Controls.Add(finalizarDateTimePicker);
            groupBox1.Controls.Add(filtrarButton);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(113, 479);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 124);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Libros Por Fecha de Lanzamiento";
            // 
            // fechaInicioLabel
            // 
            fechaInicioLabel.AutoSize = true;
            fechaInicioLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fechaInicioLabel.Location = new Point(16, 37);
            fechaInicioLabel.Name = "fechaInicioLabel";
            fechaInicioLabel.Size = new Size(46, 17);
            fechaInicioLabel.TabIndex = 32;
            fechaInicioLabel.Text = "Desde";
            // 
            // fechaLimiteLabel
            // 
            fechaLimiteLabel.AutoSize = true;
            fechaLimiteLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fechaLimiteLabel.Location = new Point(16, 84);
            fechaLimiteLabel.Name = "fechaLimiteLabel";
            fechaLimiteLabel.Size = new Size(43, 17);
            fechaLimiteLabel.TabIndex = 33;
            fechaLimiteLabel.Text = "Hasta";
            // 
            // GestionarLibrosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 626);
            Controls.Add(groupBox1);
            Controls.Add(categoriasButton);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(eliminarLibroButton);
            Controls.Add(agregarLibroButton);
            Controls.Add(editarLibroButton);
            Controls.Add(librosDataGridView);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GestionarLibrosForm";
            Text = "GestionarLibrosForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)librosDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton eliminarLibroButton;
        private FontAwesome.Sharp.IconButton agregarLibroButton;
        private FontAwesome.Sharp.IconButton editarLibroButton;
        private PictureBox pictureBox2;
        public DataGridView librosDataGridView;
        private FontAwesome.Sharp.IconButton categoriasButton;
        private DateTimePicker iniciarDateTimePicker;
        private DateTimePicker finalizarDateTimePicker;
        private Button filtrarButton;
        private Button cargarLibrosButton;
        private GroupBox groupBox1;
        private Label fechaLimiteLabel;
        private Label fechaInicioLabel;
    }
}