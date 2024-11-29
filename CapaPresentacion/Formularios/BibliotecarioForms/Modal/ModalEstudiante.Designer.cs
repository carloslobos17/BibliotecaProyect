namespace CapaPresentacion.Formularios.BibliotecarioForms.Modal
{
    partial class ModalEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalEstudiante));
            cancelarButton = new Button();
            guardarEstudianteButton = new Button();
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
            panel4 = new Panel();
            pictureBox = new PictureBox();
            tituloModalLabel = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            validacionErrorProvider = new ErrorProvider(components);
            edadNumericUpDown = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validacionErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edadNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.BackColor = Color.DarkRed;
            cancelarButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelarButton.ForeColor = Color.White;
            cancelarButton.Location = new Point(286, 565);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(123, 43);
            cancelarButton.TabIndex = 55;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = false;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // guardarEstudianteButton
            // 
            guardarEstudianteButton.BackColor = Color.FromArgb(58, 157, 35);
            guardarEstudianteButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guardarEstudianteButton.ForeColor = Color.White;
            guardarEstudianteButton.Location = new Point(117, 565);
            guardarEstudianteButton.Name = "guardarEstudianteButton";
            guardarEstudianteButton.Size = new Size(123, 43);
            guardarEstudianteButton.TabIndex = 54;
            guardarEstudianteButton.Text = "Guardar";
            guardarEstudianteButton.UseVisualStyleBackColor = false;
            guardarEstudianteButton.Click += guardarEstudianteButton_Click;
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.BackColor = Color.Transparent;
            correoLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            correoLabel.ForeColor = Color.FromArgb(74, 74, 74);
            correoLabel.Location = new Point(147, 496);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new Size(71, 22);
            correoLabel.TabIndex = 53;
            correoLabel.Text = "Correo";
            // 
            // correoTextBox
            // 
            correoTextBox.Location = new Point(256, 494);
            correoTextBox.Name = "correoTextBox";
            correoTextBox.Size = new Size(186, 27);
            correoTextBox.TabIndex = 52;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.BackColor = Color.Transparent;
            telefonoLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            telefonoLabel.ForeColor = Color.FromArgb(74, 74, 74);
            telefonoLabel.Location = new Point(131, 421);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(89, 22);
            telefonoLabel.TabIndex = 51;
            telefonoLabel.Text = "Telefono";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(256, 420);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(186, 27);
            telefonoTextBox.TabIndex = 50;
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.BackColor = Color.Transparent;
            claveLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            claveLabel.ForeColor = Color.FromArgb(74, 74, 74);
            claveLabel.Location = new Point(156, 349);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new Size(61, 22);
            claveLabel.TabIndex = 49;
            claveLabel.Text = "Clave";
            // 
            // claveTextBox
            // 
            claveTextBox.Location = new Point(256, 348);
            claveTextBox.Name = "claveTextBox";
            claveTextBox.Size = new Size(186, 27);
            claveTextBox.TabIndex = 48;
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.BackColor = Color.Transparent;
            edadLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            edadLabel.ForeColor = Color.FromArgb(74, 74, 74);
            edadLabel.Location = new Point(156, 280);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new Size(56, 22);
            edadLabel.TabIndex = 47;
            edadLabel.Text = "Edad";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.BackColor = Color.Transparent;
            apellidoLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            apellidoLabel.ForeColor = Color.FromArgb(74, 74, 74);
            apellidoLabel.Location = new Point(140, 220);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(82, 22);
            apellidoLabel.TabIndex = 45;
            apellidoLabel.Text = "Apellido";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(256, 218);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(186, 27);
            apellidoTextBox.TabIndex = 44;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = Color.Transparent;
            nombreLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            nombreLabel.ForeColor = Color.FromArgb(74, 74, 74);
            nombreLabel.Location = new Point(139, 160);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(79, 22);
            nombreLabel.TabIndex = 43;
            nombreLabel.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(256, 158);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(186, 27);
            nombreTextBox.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(tituloModalLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 105);
            panel1.TabIndex = 56;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(44, 62, 80);
            panel4.Location = new Point(48, 658);
            panel4.Name = "panel4";
            panel4.Size = new Size(427, 23);
            panel4.TabIndex = 59;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(30, 21);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(125, 62);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // tituloModalLabel
            // 
            tituloModalLabel.AutoSize = true;
            tituloModalLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloModalLabel.ForeColor = Color.White;
            tituloModalLabel.Location = new Point(184, 37);
            tituloModalLabel.Name = "tituloModalLabel";
            tituloModalLabel.Size = new Size(271, 36);
            tituloModalLabel.TabIndex = 0;
            tituloModalLabel.Text = "Agregar Estudiante";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 62, 80);
            panel3.Location = new Point(0, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(14, 592);
            panel3.TabIndex = 57;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 62, 80);
            panel2.Location = new Point(534, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(14, 592);
            panel2.TabIndex = 58;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(44, 62, 80);
            panel5.Location = new Point(12, 674);
            panel5.Name = "panel5";
            panel5.Size = new Size(524, 19);
            panel5.TabIndex = 59;
            // 
            // validacionErrorProvider
            // 
            validacionErrorProvider.ContainerControl = this;
            // 
            // edadNumericUpDown
            // 
            edadNumericUpDown.Location = new Point(256, 280);
            edadNumericUpDown.Name = "edadNumericUpDown";
            edadNumericUpDown.Size = new Size(186, 27);
            edadNumericUpDown.TabIndex = 32;
            // 
            // ModalEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(548, 693);
            Controls.Add(edadNumericUpDown);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(cancelarButton);
            Controls.Add(guardarEstudianteButton);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModalEstudiante";
            Text = "ModalEstudiante";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)validacionErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)edadNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelarButton;
        private Button guardarEstudianteButton;
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
        private PictureBox pictureBox;
        private Label tituloModalLabel;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
        private ErrorProvider validacionErrorProvider;
        public NumericUpDown edadNumericUpDown;
    }
}