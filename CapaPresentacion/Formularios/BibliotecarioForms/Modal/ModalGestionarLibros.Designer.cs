namespace CapaPresentacion.Formularios.BibliotecarioForms.Modal
{
    partial class ModalGestionarLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalGestionarLibros));
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            cancelarLibroButton = new Button();
            tituloModalLabel = new Label();
            agregarLibroModalButton = new Button();
            categoriaLibroLabel = new Label();
            copiasDisponiblesLabel = new Label();
            copiasDisponiblesTextBox = new TextBox();
            fechaPublicacionLabel = new Label();
            autorLabel = new Label();
            autorTextBox = new TextBox();
            tituloLabel = new Label();
            tituloTextBox = new TextBox();
            panel1 = new Panel();
            fechaPublicacionDateTimePicker = new DateTimePicker();
            categoriaComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(44, 62, 80);
            panel4.Location = new Point(0, 677);
            panel4.Name = "panel4";
            panel4.Size = new Size(554, 11);
            panel4.TabIndex = 48;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 62, 80);
            panel3.Location = new Point(553, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(13, 585);
            panel3.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 62, 80);
            panel2.Location = new Point(0, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 582);
            panel2.TabIndex = 46;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // cancelarLibroButton
            // 
            cancelarLibroButton.BackColor = Color.DarkRed;
            cancelarLibroButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelarLibroButton.ForeColor = Color.White;
            cancelarLibroButton.Location = new Point(306, 558);
            cancelarLibroButton.Name = "cancelarLibroButton";
            cancelarLibroButton.Size = new Size(124, 43);
            cancelarLibroButton.TabIndex = 45;
            cancelarLibroButton.Text = "Cancelar";
            cancelarLibroButton.UseVisualStyleBackColor = false;
            // 
            // tituloModalLabel
            // 
            tituloModalLabel.AutoSize = true;
            tituloModalLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloModalLabel.ForeColor = Color.White;
            tituloModalLabel.Location = new Point(184, 37);
            tituloModalLabel.Name = "tituloModalLabel";
            tituloModalLabel.Size = new Size(188, 36);
            tituloModalLabel.TabIndex = 0;
            tituloModalLabel.Text = "Agregar libro";
            // 
            // agregarLibroModalButton
            // 
            agregarLibroModalButton.BackColor = Color.FromArgb(58, 157, 35);
            agregarLibroModalButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarLibroModalButton.ForeColor = Color.White;
            agregarLibroModalButton.Location = new Point(123, 558);
            agregarLibroModalButton.Name = "agregarLibroModalButton";
            agregarLibroModalButton.Size = new Size(124, 43);
            agregarLibroModalButton.TabIndex = 44;
            agregarLibroModalButton.Text = "Agregar";
            agregarLibroModalButton.UseVisualStyleBackColor = false;
            agregarLibroModalButton.Click += agregarLibroModalButton_Click;
            // 
            // categoriaLibroLabel
            // 
            categoriaLibroLabel.AutoSize = true;
            categoriaLibroLabel.BackColor = Color.Transparent;
            categoriaLibroLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            categoriaLibroLabel.ForeColor = Color.FromArgb(74, 74, 74);
            categoriaLibroLabel.Location = new Point(146, 467);
            categoriaLibroLabel.Name = "categoriaLibroLabel";
            categoriaLibroLabel.Size = new Size(97, 22);
            categoriaLibroLabel.TabIndex = 43;
            categoriaLibroLabel.Text = "Categoria";
            // 
            // copiasDisponiblesLabel
            // 
            copiasDisponiblesLabel.AutoSize = true;
            copiasDisponiblesLabel.BackColor = Color.Transparent;
            copiasDisponiblesLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            copiasDisponiblesLabel.ForeColor = Color.FromArgb(74, 74, 74);
            copiasDisponiblesLabel.Location = new Point(68, 393);
            copiasDisponiblesLabel.Name = "copiasDisponiblesLabel";
            copiasDisponiblesLabel.Size = new Size(179, 22);
            copiasDisponiblesLabel.TabIndex = 39;
            copiasDisponiblesLabel.Text = "Copias disponibles";
            // 
            // copiasDisponiblesTextBox
            // 
            copiasDisponiblesTextBox.Location = new Point(262, 388);
            copiasDisponiblesTextBox.Name = "copiasDisponiblesTextBox";
            copiasDisponiblesTextBox.Size = new Size(250, 27);
            copiasDisponiblesTextBox.TabIndex = 38;
            // 
            // fechaPublicacionLabel
            // 
            fechaPublicacionLabel.AutoSize = true;
            fechaPublicacionLabel.BackColor = Color.Transparent;
            fechaPublicacionLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            fechaPublicacionLabel.ForeColor = Color.FromArgb(74, 74, 74);
            fechaPublicacionLabel.Location = new Point(47, 316);
            fechaPublicacionLabel.Name = "fechaPublicacionLabel";
            fechaPublicacionLabel.Size = new Size(200, 22);
            fechaPublicacionLabel.TabIndex = 37;
            fechaPublicacionLabel.Text = "Fecha de publicación";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.BackColor = Color.Transparent;
            autorLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            autorLabel.ForeColor = Color.FromArgb(74, 74, 74);
            autorLabel.Location = new Point(111, 240);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new Size(136, 22);
            autorLabel.TabIndex = 35;
            autorLabel.Text = "Autor del libro";
            // 
            // autorTextBox
            // 
            autorTextBox.Location = new Point(262, 240);
            autorTextBox.Name = "autorTextBox";
            autorTextBox.Size = new Size(250, 27);
            autorTextBox.TabIndex = 34;
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.BackColor = Color.Transparent;
            tituloLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            tituloLabel.ForeColor = Color.FromArgb(74, 74, 74);
            tituloLabel.Location = new Point(104, 162);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(139, 22);
            tituloLabel.TabIndex = 33;
            tituloLabel.Text = "Titulo del libro";
            // 
            // tituloTextBox
            // 
            tituloTextBox.Location = new Point(262, 162);
            tituloTextBox.Name = "tituloTextBox";
            tituloTextBox.Size = new Size(250, 27);
            tituloTextBox.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tituloModalLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 105);
            panel1.TabIndex = 31;
            // 
            // fechaPublicacionDateTimePicker
            // 
            fechaPublicacionDateTimePicker.Location = new Point(262, 316);
            fechaPublicacionDateTimePicker.Name = "fechaPublicacionDateTimePicker";
            fechaPublicacionDateTimePicker.Size = new Size(250, 27);
            fechaPublicacionDateTimePicker.TabIndex = 49;
            // 
            // categoriaComboBox
            // 
            categoriaComboBox.FormattingEnabled = true;
            categoriaComboBox.Location = new Point(262, 469);
            categoriaComboBox.Name = "categoriaComboBox";
            categoriaComboBox.Size = new Size(250, 28);
            categoriaComboBox.TabIndex = 50;
            // 
            // ModalGestionarLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(566, 686);
            Controls.Add(categoriaComboBox);
            Controls.Add(fechaPublicacionDateTimePicker);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(cancelarLibroButton);
            Controls.Add(agregarLibroModalButton);
            Controls.Add(categoriaLibroLabel);
            Controls.Add(copiasDisponiblesLabel);
            Controls.Add(copiasDisponiblesTextBox);
            Controls.Add(fechaPublicacionLabel);
            Controls.Add(autorLabel);
            Controls.Add(autorTextBox);
            Controls.Add(tituloLabel);
            Controls.Add(tituloTextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModalGestionarLibros";
            Text = "ModalGestionarLibros";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button cancelarLibroButton;
        private Label tituloModalLabel;
        private Button agregarLibroModalButton;
        private Label categoriaLibroLabel;
        private Label copiasDisponiblesLabel;
        private Label fechaPublicacionLabel;
        private Label autorLabel;
        private Label tituloLabel;
        private Panel panel1;
        public TextBox copiasDisponiblesTextBox;
        public TextBox autorTextBox;
        public TextBox tituloTextBox;
        public DateTimePicker fechaPublicacionDateTimePicker;
        public ComboBox categoriaComboBox;
    }
}