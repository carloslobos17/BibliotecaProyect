namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    partial class DevolucionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolucionesForm));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            librosComboBox = new ComboBox();
            estudiantesComboBox = new ComboBox();
            fechaDevolucionDateTimePicker = new DateTimePicker();
            devolverButton = new Button();
            label3 = new Label();
            label6 = new Label();
            nombreLabel = new Label();
            observacionesTextBox = new TextBox();
            label2 = new Label();
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
            panel2.TabIndex = 79;
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
            panel1.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(175, 73);
            label1.Name = "label1";
            label1.Size = new Size(375, 42);
            label1.TabIndex = 77;
            label1.Text = "Devolución de libros";
            // 
            // librosComboBox
            // 
            librosComboBox.FormattingEnabled = true;
            librosComboBox.Location = new Point(340, 266);
            librosComboBox.Name = "librosComboBox";
            librosComboBox.Size = new Size(250, 28);
            librosComboBox.TabIndex = 76;
            // 
            // estudiantesComboBox
            // 
            estudiantesComboBox.FormattingEnabled = true;
            estudiantesComboBox.Location = new Point(340, 181);
            estudiantesComboBox.Name = "estudiantesComboBox";
            estudiantesComboBox.Size = new Size(250, 28);
            estudiantesComboBox.TabIndex = 75;
            // 
            // fechaDevolucionDateTimePicker
            // 
            fechaDevolucionDateTimePicker.Location = new Point(340, 347);
            fechaDevolucionDateTimePicker.Name = "fechaDevolucionDateTimePicker";
            fechaDevolucionDateTimePicker.Size = new Size(250, 27);
            fechaDevolucionDateTimePicker.TabIndex = 73;
            // 
            // devolverButton
            // 
            devolverButton.BackColor = Color.DarkRed;
            devolverButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            devolverButton.ForeColor = Color.White;
            devolverButton.Location = new Point(175, 549);
            devolverButton.Name = "devolverButton";
            devolverButton.Size = new Size(333, 43);
            devolverButton.TabIndex = 72;
            devolverButton.Text = "Devolver";
            devolverButton.UseVisualStyleBackColor = false;
            devolverButton.Click += devolverButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(74, 74, 74);
            label3.Location = new Point(85, 347);
            label3.Name = "label3";
            label3.Size = new Size(195, 22);
            label3.TabIndex = 71;
            label3.Text = "Fecha de devolución";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(74, 74, 74);
            label6.Location = new Point(123, 267);
            label6.Name = "label6";
            label6.Size = new Size(157, 22);
            label6.TabIndex = 69;
            label6.Text = "Nombre del libro";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = Color.Transparent;
            nombreLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            nombreLabel.ForeColor = Color.FromArgb(74, 74, 74);
            nombreLabel.Location = new Point(175, 187);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(105, 22);
            nombreLabel.TabIndex = 68;
            nombreLabel.Text = "Estudiante";
            // 
            // observacionesTextBox
            // 
            observacionesTextBox.BackColor = Color.White;
            observacionesTextBox.Location = new Point(340, 418);
            observacionesTextBox.Margin = new Padding(3, 4, 3, 4);
            observacionesTextBox.Multiline = true;
            observacionesTextBox.Name = "observacionesTextBox";
            observacionesTextBox.Size = new Size(250, 73);
            observacionesTextBox.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(74, 74, 74);
            label2.Location = new Point(137, 419);
            label2.Name = "label2";
            label2.Size = new Size(143, 22);
            label2.TabIndex = 81;
            label2.Text = "Observaciones";
            // 
            // DevolucionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 719);
            Controls.Add(label2);
            Controls.Add(observacionesTextBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(librosComboBox);
            Controls.Add(estudiantesComboBox);
            Controls.Add(fechaDevolucionDateTimePicker);
            Controls.Add(devolverButton);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(nombreLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DevolucionesForm";
            Text = "DevolucionesForm";
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
        private ComboBox librosComboBox;
        private ComboBox estudiantesComboBox;
        private DateTimePicker fechaDevolucionDateTimePicker;
        private Button devolverButton;
        private Label label3;
        private Label label6;
        private Label nombreLabel;
        private TextBox observacionesTextBox;
        private Label label2;
    }
}