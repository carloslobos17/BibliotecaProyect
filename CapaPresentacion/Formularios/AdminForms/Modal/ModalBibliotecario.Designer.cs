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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalBibliotecario));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tituloModalLabel = new Label();
            label5 = new Label();
            correoTextBox = new TextBox();
            label4 = new Label();
            telefonoTextBox = new TextBox();
            label3 = new Label();
            claveTextBox = new TextBox();
            label2 = new Label();
            edadTextBox = new TextBox();
            label1 = new Label();
            apellidoTextBox = new TextBox();
            nombreLabel = new Label();
            nombreTextBox = new TextBox();
            guardarBibliotecarioButton = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tituloModalLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 79);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tituloModalLabel
            // 
            tituloModalLabel.AutoSize = true;
            tituloModalLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloModalLabel.ForeColor = Color.White;
            tituloModalLabel.Location = new Point(141, 26);
            tituloModalLabel.Name = "tituloModalLabel";
            tituloModalLabel.Size = new Size(240, 29);
            tituloModalLabel.TabIndex = 0;
            tituloModalLabel.Text = "Agregar Bibliotecario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(74, 74, 74);
            label5.Location = new Point(123, 373);
            label5.Name = "label5";
            label5.Size = new Size(61, 18);
            label5.TabIndex = 25;
            label5.Text = "Correo";
            // 
            // correoTextBox
            // 
            correoTextBox.Location = new Point(218, 370);
            correoTextBox.Margin = new Padding(3, 2, 3, 2);
            correoTextBox.Name = "correoTextBox";
            correoTextBox.Size = new Size(163, 23);
            correoTextBox.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(74, 74, 74);
            label4.Location = new Point(108, 316);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 23;
            label4.Text = "Telefono";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(218, 314);
            telefonoTextBox.Margin = new Padding(3, 2, 3, 2);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(163, 23);
            telefonoTextBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(74, 74, 74);
            label3.Location = new Point(130, 261);
            label3.Name = "label3";
            label3.Size = new Size(50, 18);
            label3.TabIndex = 21;
            label3.Text = "Clave";
            // 
            // claveTextBox
            // 
            claveTextBox.Location = new Point(218, 259);
            claveTextBox.Margin = new Padding(3, 2, 3, 2);
            claveTextBox.Name = "claveTextBox";
            claveTextBox.Size = new Size(163, 23);
            claveTextBox.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(74, 74, 74);
            label2.Location = new Point(130, 208);
            label2.Name = "label2";
            label2.Size = new Size(46, 18);
            label2.TabIndex = 19;
            label2.Text = "Edad";
            // 
            // edadTextBox
            // 
            edadTextBox.Location = new Point(218, 206);
            edadTextBox.Margin = new Padding(3, 2, 3, 2);
            edadTextBox.Name = "edadTextBox";
            edadTextBox.Size = new Size(163, 23);
            edadTextBox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(74, 74, 74);
            label1.Location = new Point(116, 154);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 17;
            label1.Text = "Apellido";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(218, 152);
            apellidoTextBox.Margin = new Padding(3, 2, 3, 2);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(163, 23);
            apellidoTextBox.TabIndex = 16;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = Color.Transparent;
            nombreLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            nombreLabel.ForeColor = Color.FromArgb(74, 74, 74);
            nombreLabel.Location = new Point(116, 103);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(68, 18);
            nombreLabel.TabIndex = 15;
            nombreLabel.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(218, 100);
            nombreTextBox.Margin = new Padding(3, 2, 3, 2);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(163, 23);
            nombreTextBox.TabIndex = 14;
            // 
            // guardarBibliotecarioButton
            // 
            guardarBibliotecarioButton.BackColor = Color.FromArgb(58, 157, 35);
            guardarBibliotecarioButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guardarBibliotecarioButton.ForeColor = Color.White;
            guardarBibliotecarioButton.Location = new Point(96, 440);
            guardarBibliotecarioButton.Margin = new Padding(3, 2, 3, 2);
            guardarBibliotecarioButton.Name = "guardarBibliotecarioButton";
            guardarBibliotecarioButton.Size = new Size(108, 32);
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
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(244, 440);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(108, 32);
            button2.TabIndex = 27;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 62, 80);
            panel2.Location = new Point(0, 77);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 436);
            panel2.TabIndex = 28;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 62, 80);
            panel3.Location = new Point(457, 77);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(11, 436);
            panel3.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(44, 62, 80);
            panel4.Location = new Point(0, 508);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(468, 8);
            panel4.TabIndex = 30;
            // 
            // ModalBibliotecario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(468, 516);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(guardarBibliotecarioButton);
            Controls.Add(label5);
            Controls.Add(correoTextBox);
            Controls.Add(label4);
            Controls.Add(telefonoTextBox);
            Controls.Add(label3);
            Controls.Add(claveTextBox);
            Controls.Add(label2);
            Controls.Add(edadTextBox);
            Controls.Add(label1);
            Controls.Add(apellidoTextBox);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ModalBibliotecario";
            Text = "ModalBibliotecario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label tituloModalLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label nombreLabel;
        private Button guardarBibliotecarioButton;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        public TextBox correoTextBox;
        public TextBox telefonoTextBox;
        public TextBox claveTextBox;
        public TextBox edadTextBox;
        public TextBox apellidoTextBox;
        public TextBox nombreTextBox;
    }
}