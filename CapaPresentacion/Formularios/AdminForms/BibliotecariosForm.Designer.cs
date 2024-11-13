namespace CapaPresentacion.Formularios.AdminForms
{
    partial class BibliotecariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BibliotecariosForm));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            agregarLibroButton = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.ForeColor = Color.FromArgb(162, 129, 112);
            panel1.Location = new Point(268, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 12);
            panel1.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(288, 70);
            label2.Name = "label2";
            label2.Size = new Size(452, 42);
            label2.TabIndex = 32;
            label2.Text = "Gestión de bibliotecarios";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.DarkRed;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = SystemColors.MenuBar;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton3.IconColor = SystemColors.MenuBar;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 40;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(816, 355);
            iconButton3.Margin = new Padding(0);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(144, 49);
            iconButton3.TabIndex = 30;
            iconButton3.Text = "Eliminar";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
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
            agregarLibroButton.Location = new Point(816, 219);
            agregarLibroButton.Margin = new Padding(0);
            agregarLibroButton.Name = "agregarLibroButton";
            agregarLibroButton.Size = new Size(144, 48);
            agregarLibroButton.TabIndex = 28;
            agregarLibroButton.Text = "Agregar";
            agregarLibroButton.TextAlign = ContentAlignment.MiddleRight;
            agregarLibroButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            agregarLibroButton.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.SteelBlue;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = SystemColors.MenuBar;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconButton1.IconColor = SystemColors.MenuBar;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(816, 285);
            iconButton1.Margin = new Padding(0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(144, 48);
            iconButton1.TabIndex = 29;
            iconButton1.Text = "Editar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(146, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(645, 444);
            dataGridView1.TabIndex = 27;
            // 
            // BibliotecariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1080, 673);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(iconButton3);
            Controls.Add(agregarLibroButton);
            Controls.Add(iconButton1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BibliotecariosForm";
            Text = "BibliotecariosForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton agregarLibroButton;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView dataGridView1;
    }
}