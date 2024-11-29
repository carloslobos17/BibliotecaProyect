namespace CapaPresentacion.Formularios.AdminForms.Modal
{
    partial class ModalAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalAdministrador));
            cancelarButton = new Button();
            guardarAdministradorButton = new Button();
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tituloModalLabel = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            validacionErrorProvider = new ErrorProvider(components);
            edadNumericUpDown = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validacionErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edadNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.BackColor = Color.DarkRed;
            cancelarButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelarButton.ForeColor = Color.White;
            cancelarButton.Location = new Point(273, 556);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(123, 43);
            cancelarButton.TabIndex = 70;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = false;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // guardarAdministradorButton
            // 
            guardarAdministradorButton.BackColor = Color.FromArgb(58, 157, 35);
            guardarAdministradorButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guardarAdministradorButton.ForeColor = Color.White;
            guardarAdministradorButton.Location = new Point(104, 556);
            guardarAdministradorButton.Name = "guardarAdministradorButton";
            guardarAdministradorButton.Size = new Size(123, 43);
            guardarAdministradorButton.TabIndex = 69;
            guardarAdministradorButton.Text = "Guardar";
            guardarAdministradorButton.UseVisualStyleBackColor = false;
            guardarAdministradorButton.Click += guardarAdministradorButton_Click;
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.BackColor = Color.Transparent;
            correoLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            correoLabel.ForeColor = Color.FromArgb(74, 74, 74);
            correoLabel.Location = new Point(134, 487);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new Size(71, 22);
            correoLabel.TabIndex = 68;
            correoLabel.Text = "Correo";
            // 
            // correoTextBox
            // 
            correoTextBox.Location = new Point(243, 485);
            correoTextBox.Name = "correoTextBox";
            correoTextBox.Size = new Size(186, 27);
            correoTextBox.TabIndex = 67;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.BackColor = Color.Transparent;
            telefonoLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            telefonoLabel.ForeColor = Color.FromArgb(74, 74, 74);
            telefonoLabel.Location = new Point(118, 412);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(89, 22);
            telefonoLabel.TabIndex = 66;
            telefonoLabel.Text = "Telefono";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(243, 411);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(186, 27);
            telefonoTextBox.TabIndex = 65;
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.BackColor = Color.Transparent;
            claveLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            claveLabel.ForeColor = Color.FromArgb(74, 74, 74);
            claveLabel.Location = new Point(143, 340);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new Size(61, 22);
            claveLabel.TabIndex = 64;
            claveLabel.Text = "Clave";
            // 
            // claveTextBox
            // 
            claveTextBox.Location = new Point(243, 339);
            claveTextBox.Name = "claveTextBox";
            claveTextBox.Size = new Size(186, 27);
            claveTextBox.TabIndex = 63;
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.BackColor = Color.Transparent;
            edadLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            edadLabel.ForeColor = Color.FromArgb(74, 74, 74);
            edadLabel.Location = new Point(143, 271);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new Size(56, 22);
            edadLabel.TabIndex = 62;
            edadLabel.Text = "Edad";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.BackColor = Color.Transparent;
            apellidoLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            apellidoLabel.ForeColor = Color.FromArgb(74, 74, 74);
            apellidoLabel.Location = new Point(127, 211);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(82, 22);
            apellidoLabel.TabIndex = 60;
            apellidoLabel.Text = "Apellido";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(243, 209);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(186, 27);
            apellidoTextBox.TabIndex = 59;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = Color.Transparent;
            nombreLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            nombreLabel.ForeColor = Color.FromArgb(74, 74, 74);
            nombreLabel.Location = new Point(126, 151);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(79, 22);
            nombreLabel.TabIndex = 58;
            nombreLabel.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(243, 149);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(186, 27);
            nombreTextBox.TabIndex = 57;
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
            panel1.TabIndex = 71;
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
            tituloModalLabel.Size = new Size(315, 36);
            tituloModalLabel.TabIndex = 0;
            tituloModalLabel.Text = "Agregar Administrador";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 62, 80);
            panel3.Location = new Point(520, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(15, 573);
            panel3.TabIndex = 72;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 62, 80);
            panel2.Location = new Point(0, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 576);
            panel2.TabIndex = 73;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(44, 62, 80);
            panel4.Location = new Point(0, 667);
            panel4.Name = "panel4";
            panel4.Size = new Size(541, 25);
            panel4.TabIndex = 74;
            // 
            // validacionErrorProvider
            // 
            validacionErrorProvider.ContainerControl = this;
            // 
            // edadNumericUpDown
            // 
            edadNumericUpDown.Location = new Point(243, 271);
            edadNumericUpDown.Name = "edadNumericUpDown";
            edadNumericUpDown.Size = new Size(186, 27);
            edadNumericUpDown.TabIndex = 75;
            // 
            // ModalAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(535, 688);
            Controls.Add(edadNumericUpDown);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(cancelarButton);
            Controls.Add(guardarAdministradorButton);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModalAdministrador";
            Text = "ModalAdministrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)validacionErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)edadNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancelarButton;
        private Button guardarAdministradorButton;
        private Label correoLabel;
        public TextBox correoTextBox;
        private Label telefonoLabel;
        public TextBox telefonoTextBox;
        private Label claveLabel;
        public TextBox claveTextBox;
        private Label edadLabel;
        private Label apellidoLabel;
        public TextBox apellidoTextBox;
        private Label nombreLabel;
        public TextBox nombreTextBox;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label tituloModalLabel;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private ErrorProvider validacionErrorProvider;
        public NumericUpDown edadNumericUpDown;
    }
}