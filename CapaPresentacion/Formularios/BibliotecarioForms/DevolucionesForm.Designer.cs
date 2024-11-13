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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(340, 266);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 76;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(340, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 75;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(340, 353);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 74;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(340, 439);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 73;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(175, 549);
            button1.Name = "button1";
            button1.Size = new Size(333, 43);
            button1.TabIndex = 72;
            button1.Text = "Prestar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(74, 74, 74);
            label3.Location = new Point(85, 439);
            label3.Name = "label3";
            label3.Size = new Size(195, 22);
            label3.TabIndex = 71;
            label3.Text = "Fecha de devolución";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(74, 74, 74);
            label2.Location = new Point(99, 358);
            label2.Name = "label2";
            label2.Size = new Size(181, 22);
            label2.TabIndex = 70;
            label2.Text = "Fecha de préstamo";
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
            // DevolucionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 719);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(nombreLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DevolucionesForm";
            Text = "DevolucionesForm";
            Load += DevolucionesForm_Load;
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
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label nombreLabel;
    }
}