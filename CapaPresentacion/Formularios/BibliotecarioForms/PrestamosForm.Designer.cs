namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    partial class PrestamosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrestamosForm));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            prestarLibroButton = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            fechaPrestamoDateTimePicker = new DateTimePicker();
            fechaDevolucionDateTimePicker = new DateTimePicker();
            fechaDevolucionLabel = new Label();
            fechaPrestamoLabel = new Label();
            label6 = new Label();
            nombreLabel = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(686, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 681);
            panel2.TabIndex = 91;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-48, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(398, 745);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.ForeColor = Color.FromArgb(162, 129, 112);
            panel1.Location = new Point(120, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 12);
            panel1.TabIndex = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(175, 73);
            label1.Name = "label1";
            label1.Size = new Size(366, 42);
            label1.TabIndex = 89;
            label1.Text = "Prestamos de libros";
            // 
            // prestarLibroButton
            // 
            prestarLibroButton.BackColor = Color.FromArgb(58, 157, 35);
            prestarLibroButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prestarLibroButton.ForeColor = Color.White;
            prestarLibroButton.Location = new Point(192, 587);
            prestarLibroButton.Name = "prestarLibroButton";
            prestarLibroButton.Size = new Size(333, 43);
            prestarLibroButton.TabIndex = 84;
            prestarLibroButton.Text = "Prestar";
            prestarLibroButton.UseVisualStyleBackColor = false;
            prestarLibroButton.Click += prestarLibroButton_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(340, 288);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 99;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(340, 203);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 98;
            // 
            // fechaPrestamoDateTimePicker
            // 
            fechaPrestamoDateTimePicker.Location = new Point(340, 375);
            fechaPrestamoDateTimePicker.Name = "fechaPrestamoDateTimePicker";
            fechaPrestamoDateTimePicker.Size = new Size(250, 27);
            fechaPrestamoDateTimePicker.TabIndex = 97;
            // 
            // fechaDevolucionDateTimePicker
            // 
            fechaDevolucionDateTimePicker.Location = new Point(340, 461);
            fechaDevolucionDateTimePicker.Name = "fechaDevolucionDateTimePicker";
            fechaDevolucionDateTimePicker.Size = new Size(250, 27);
            fechaDevolucionDateTimePicker.TabIndex = 96;
            // 
            // fechaDevolucionLabel
            // 
            fechaDevolucionLabel.AutoSize = true;
            fechaDevolucionLabel.BackColor = Color.Transparent;
            fechaDevolucionLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            fechaDevolucionLabel.ForeColor = Color.FromArgb(74, 74, 74);
            fechaDevolucionLabel.Location = new Point(85, 461);
            fechaDevolucionLabel.Name = "fechaDevolucionLabel";
            fechaDevolucionLabel.Size = new Size(195, 22);
            fechaDevolucionLabel.TabIndex = 95;
            fechaDevolucionLabel.Text = "Fecha de devolución";
            // 
            // fechaPrestamoLabel
            // 
            fechaPrestamoLabel.AutoSize = true;
            fechaPrestamoLabel.BackColor = Color.Transparent;
            fechaPrestamoLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            fechaPrestamoLabel.ForeColor = Color.FromArgb(74, 74, 74);
            fechaPrestamoLabel.Location = new Point(99, 380);
            fechaPrestamoLabel.Name = "fechaPrestamoLabel";
            fechaPrestamoLabel.Size = new Size(181, 22);
            fechaPrestamoLabel.TabIndex = 94;
            fechaPrestamoLabel.Text = "Fecha de préstamo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(74, 74, 74);
            label6.Location = new Point(123, 289);
            label6.Name = "label6";
            label6.Size = new Size(157, 22);
            label6.TabIndex = 93;
            label6.Text = "Nombre del libro";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = Color.Transparent;
            nombreLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            nombreLabel.ForeColor = Color.FromArgb(74, 74, 74);
            nombreLabel.Location = new Point(175, 209);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(105, 22);
            nombreLabel.TabIndex = 92;
            nombreLabel.Text = "Estudiante";
            // 
            // PrestamosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 721);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(fechaPrestamoDateTimePicker);
            Controls.Add(fechaDevolucionDateTimePicker);
            Controls.Add(fechaDevolucionLabel);
            Controls.Add(fechaPrestamoLabel);
            Controls.Add(label6);
            Controls.Add(nombreLabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(prestarLibroButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrestamosForm";
            Text = "Prestamos";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Button prestarLibroButton;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker fechaPrestamoDateTimePicker;
        private DateTimePicker fechaDevolucionDateTimePicker;
        private Label fechaDevolucionLabel;
        private Label fechaPrestamoLabel;
        private Label label6;
        private Label nombreLabel;
    }
}