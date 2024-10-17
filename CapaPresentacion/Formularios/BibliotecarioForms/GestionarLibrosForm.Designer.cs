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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Rol = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Libros = new DataGridViewTextBoxColumn();
            Prestamos = new DataGridViewTextBoxColumn();
            Devoluciones = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 20);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 0;
            label1.Text = "Gestionar libros";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Rol, Usuario, Libros, Prestamos, Devoluciones, Categoria });
            dataGridView1.Location = new Point(27, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(628, 150);
            dataGridView1.TabIndex = 1;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            // 
            // Libros
            // 
            Libros.HeaderText = "Libros";
            Libros.Name = "Libros";
            // 
            // Prestamos
            // 
            Prestamos.HeaderText = "Prestamos";
            Prestamos.Name = "Prestamos";
            // 
            // Devoluciones
            // 
            Devoluciones.HeaderText = "Devoluciones";
            Devoluciones.Name = "Devoluciones";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(77, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 384);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(261, 321);
            button1.Name = "button1";
            button1.Size = new Size(201, 29);
            button1.TabIndex = 11;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(487, 196);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(90, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(317, 191);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(501, 265);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 7;
            label4.Text = "Eliminar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(341, 265);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 6;
            label3.Text = "Editar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(148, 265);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 5;
            label2.Text = "Agregar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(162, 129, 112);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 70);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(162, 129, 112);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 679);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 70);
            panel3.TabIndex = 4;
            // 
            // GestionarLibrosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 749);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GestionarLibrosForm";
            Text = "GestionarLibrosForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Libros;
        private DataGridViewTextBoxColumn Prestamos;
        private DataGridViewTextBoxColumn Devoluciones;
        private DataGridViewTextBoxColumn Categoria;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}