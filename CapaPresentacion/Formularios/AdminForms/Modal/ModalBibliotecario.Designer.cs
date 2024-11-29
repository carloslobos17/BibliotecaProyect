namespace CapaPresentacion.Formularios.AdminForms.Modal
{
    partial class ModalBibliotecario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalBibliotecario));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tituloModalLabel = new Label();
            correoLabel = new Label();
            correoTextBox = new TextBox();
            telefonoLabel = new Label();
            telefonoTextBox = new TextBox();
            claveLabel = new Label();
            claveTextBox = new TextBox();
            edadLabel = new Label();
            apellidoLabel = new Label();
            apellidoTextBox = new TextBox();
            nombreLabel = new Label();
            nombreTextBox = new TextBox();
            guardarBibliotecarioButton = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cancelarButton = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            validacionErrorProvider = new ErrorProvider(components);
            edadNumericUpDown = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validacionErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edadNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tituloModalLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 105);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tituloModalLabel
            // 
            tituloModalLabel.AutoSize = true;
            tituloModalLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloModalLabel.ForeColor = Color.White;
            tituloModalLabel.Location = new Point(161, 35);
            tituloModalLabel.Name = "tituloModalLabel";
            tituloModalLabel.Size = new Size(294, 36);
            tituloModalLabel.TabIndex = 0;
            tituloModalLabel.Text = "Agregar Bibliotecario";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.BackColor = Color.Transparent;
            correoLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            correoLabel.ForeColor = Color.FromArgb(74, 74, 74);
            correoLabel.Location = new Point(134, 497);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new Size(71, 22);
            correoLabel.TabIndex = 25;
            correoLabel.Text = "Correo";
            // 
            // correoTextBox
            // 
            correoTextBox.Location = new Point(242, 493);
            correoTextBox.Name = "correoTextBox";
            correoTextBox.Size = new Size(186, 27);
            correoTextBox.TabIndex = 24;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.BackColor = Color.Transparent;
            telefonoLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            telefonoLabel.ForeColor = Color.FromArgb(74, 74, 74);
            telefonoLabel.Location = new Point(116, 421);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(89, 22);
            telefonoLabel.TabIndex = 23;
            telefonoLabel.Text = "Telefono";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(242, 419);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(186, 27);
            telefonoTextBox.TabIndex = 22;
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.BackColor = Color.Transparent;
            claveLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            claveLabel.ForeColor = Color.FromArgb(74, 74, 74);
            claveLabel.Location = new Point(142, 348);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new Size(61, 22);
            claveLabel.TabIndex = 21;
            claveLabel.Text = "Clave";
            // 
            // claveTextBox
            // 
            claveTextBox.Location = new Point(242, 345);
            claveTextBox.Name = "claveTextBox";
            claveTextBox.Size = new Size(186, 27);
            claveTextBox.TabIndex = 20;
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.BackColor = Color.Transparent;
            edadLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            edadLabel.ForeColor = Color.FromArgb(74, 74, 74);
            edadLabel.Location = new Point(142, 277);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new Size(56, 22);
            edadLabel.TabIndex = 19;
            edadLabel.Text = "Edad";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.BackColor = Color.Transparent;
            apellidoLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            apellidoLabel.ForeColor = Color.FromArgb(74, 74, 74);
            apellidoLabel.Location = new Point(126, 205);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(82, 22);
            apellidoLabel.TabIndex = 17;
            apellidoLabel.Text = "Apellido";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(242, 203);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(186, 27);
            apellidoTextBox.TabIndex = 16;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = Color.Transparent;
            nombreLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            nombreLabel.ForeColor = Color.FromArgb(74, 74, 74);
            nombreLabel.Location = new Point(126, 137);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(79, 22);
            nombreLabel.TabIndex = 15;
            nombreLabel.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(242, 133);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(186, 27);
            nombreTextBox.TabIndex = 14;
            // 
            // guardarBibliotecarioButton
            // 
            guardarBibliotecarioButton.BackColor = Color.FromArgb(58, 157, 35);
            guardarBibliotecarioButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guardarBibliotecarioButton.ForeColor = Color.White;
            guardarBibliotecarioButton.Location = new Point(110, 587);
            guardarBibliotecarioButton.Name = "guardarBibliotecarioButton";
            guardarBibliotecarioButton.Size = new Size(123, 43);
            guardarBibliotecarioButton.TabIndex = 26;
            guardarBibliotecarioButton.Text = "Guardar";
            guardarBibliotecarioButton.UseVisualStyleBackColor = false;
            guardarBibliotecarioButton.Click += guardarBibliotecarioButton_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cancelarButton
            // 
            cancelarButton.BackColor = Color.DarkRed;
            cancelarButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelarButton.ForeColor = Color.White;
            cancelarButton.Location = new Point(279, 587);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(123, 43);
            cancelarButton.TabIndex = 27;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = false;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 62, 80);
            panel2.Location = new Point(0, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 581);
            panel2.TabIndex = 28;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 62, 80);
            panel3.Location = new Point(522, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(13, 581);
            panel3.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(44, 62, 80);
            panel4.Location = new Point(0, 677);
            panel4.Name = "panel4";
            panel4.Size = new Size(535, 11);
            panel4.TabIndex = 30;
            // 
            // validacionErrorProvider
            // 
            validacionErrorProvider.ContainerControl = this;
            // 
            // edadNumericUpDown
            // 
            edadNumericUpDown.Location = new Point(242, 277);
            edadNumericUpDown.Name = "edadNumericUpDown";
            edadNumericUpDown.Size = new Size(186, 27);
            edadNumericUpDown.TabIndex = 31;
            // 
            // ModalBibliotecario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(535, 688);
            Controls.Add(edadNumericUpDown);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(cancelarButton);
            Controls.Add(guardarBibliotecarioButton);
            Controls.Add(correoLabel);
            Controls.Add(correoTextBox);
            Controls.Add(telefonoLabel);
            Controls.Add(telefonoTextBox);
            Controls.Add(claveLabel);
            Controls.Add(claveTextBox);
            Controls.Add(edadLabel);
            Controls.Add(apellidoLabel);
            Controls.Add(apellidoTextBox);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModalBibliotecario";
            Text = "ModalBibliotecario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)validacionErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)edadNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label tituloModalLabel;
        private Label correoLabel;
        private Label telefonoLabel;
        private Label claveLabel;
        private Label edadLabel;
        private Label apellidoLabel;
        private Label nombreLabel;
        private Button guardarBibliotecarioButton;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button cancelarButton;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        public TextBox correoTextBox;
        public TextBox telefonoTextBox;
        public TextBox claveTextBox;
        public TextBox apellidoTextBox;
        public TextBox nombreTextBox;
        private ErrorProvider validacionErrorProvider;
        public NumericUpDown edadNumericUpDown;
    }
}