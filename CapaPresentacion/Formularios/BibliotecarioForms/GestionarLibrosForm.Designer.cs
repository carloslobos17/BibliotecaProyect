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
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            eliminarLibroButton = new FontAwesome.Sharp.IconButton();
            agregarLibroButton = new FontAwesome.Sharp.IconButton();
            editarLibroButton = new FontAwesome.Sharp.IconButton();
            librosDataGridView = new DataGridView();
            pictureBox2 = new PictureBox();
            categoriasButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)librosDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.ForeColor = Color.FromArgb(162, 129, 112);
            panel1.Location = new Point(248, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 12);
            panel1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(314, 71);
            label2.Name = "label2";
            label2.Size = new Size(315, 42);
            label2.TabIndex = 24;
            label2.Text = "Gestión de libros";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // eliminarLibroButton
            // 
            eliminarLibroButton.BackColor = Color.DarkRed;
            eliminarLibroButton.FlatStyle = FlatStyle.Flat;
            eliminarLibroButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminarLibroButton.ForeColor = SystemColors.MenuBar;
            eliminarLibroButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            eliminarLibroButton.IconColor = SystemColors.MenuBar;
            eliminarLibroButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarLibroButton.IconSize = 40;
            eliminarLibroButton.ImageAlign = ContentAlignment.MiddleLeft;
            eliminarLibroButton.Location = new Point(796, 356);
            eliminarLibroButton.Margin = new Padding(0);
            eliminarLibroButton.Name = "eliminarLibroButton";
            eliminarLibroButton.Size = new Size(144, 49);
            eliminarLibroButton.TabIndex = 21;
            eliminarLibroButton.Text = "Eliminar";
            eliminarLibroButton.TextAlign = ContentAlignment.MiddleRight;
            eliminarLibroButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            eliminarLibroButton.UseVisualStyleBackColor = false;
            eliminarLibroButton.Click += eliminarLibroButton_Click;
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
            agregarLibroButton.Location = new Point(796, 220);
            agregarLibroButton.Margin = new Padding(0);
            agregarLibroButton.Name = "agregarLibroButton";
            agregarLibroButton.Size = new Size(144, 48);
            agregarLibroButton.TabIndex = 19;
            agregarLibroButton.Text = "Agregar";
            agregarLibroButton.TextAlign = ContentAlignment.MiddleRight;
            agregarLibroButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            agregarLibroButton.UseVisualStyleBackColor = false;
            agregarLibroButton.Click += agregarLibroButton_Click;
            // 
            // editarLibroButton
            // 
            editarLibroButton.BackColor = Color.SteelBlue;
            editarLibroButton.FlatStyle = FlatStyle.Flat;
            editarLibroButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editarLibroButton.ForeColor = SystemColors.MenuBar;
            editarLibroButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editarLibroButton.IconColor = SystemColors.MenuBar;
            editarLibroButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editarLibroButton.IconSize = 40;
            editarLibroButton.ImageAlign = ContentAlignment.MiddleLeft;
            editarLibroButton.Location = new Point(796, 286);
            editarLibroButton.Margin = new Padding(0);
            editarLibroButton.Name = "editarLibroButton";
            editarLibroButton.Size = new Size(144, 48);
            editarLibroButton.TabIndex = 20;
            editarLibroButton.Text = "Editar";
            editarLibroButton.TextAlign = ContentAlignment.MiddleRight;
            editarLibroButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            editarLibroButton.UseVisualStyleBackColor = false;
            editarLibroButton.Click += editarLibroButton_Click;
            // 
            // librosDataGridView
            // 
            librosDataGridView.AllowUserToAddRows = false;
            librosDataGridView.AllowUserToDeleteRows = false;
            librosDataGridView.AllowUserToResizeColumns = false;
            librosDataGridView.AllowUserToResizeRows = false;
            librosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            librosDataGridView.Location = new Point(126, 172);
            librosDataGridView.Name = "librosDataGridView";
            librosDataGridView.RowHeadersWidth = 51;
            librosDataGridView.Size = new Size(645, 444);
            librosDataGridView.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(796, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // categoriasButton
            // 
            categoriasButton.BackColor = Color.FromArgb(128, 64, 0);
            categoriasButton.FlatStyle = FlatStyle.Flat;
            categoriasButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoriasButton.ForeColor = SystemColors.MenuBar;
            categoriasButton.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            categoriasButton.IconColor = SystemColors.MenuBar;
            categoriasButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            categoriasButton.IconSize = 40;
            categoriasButton.ImageAlign = ContentAlignment.MiddleLeft;
            categoriasButton.Location = new Point(796, 424);
            categoriasButton.Margin = new Padding(0);
            categoriasButton.Name = "categoriasButton";
            categoriasButton.Size = new Size(144, 48);
            categoriasButton.TabIndex = 27;
            categoriasButton.Text = "Categorias";
            categoriasButton.TextAlign = ContentAlignment.MiddleRight;
            categoriasButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            categoriasButton.UseVisualStyleBackColor = false;
            categoriasButton.Click += categoriasButton_Click;
            // 
            // GestionarLibrosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 673);
            Controls.Add(categoriasButton);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(eliminarLibroButton);
            Controls.Add(agregarLibroButton);
            Controls.Add(editarLibroButton);
            Controls.Add(librosDataGridView);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionarLibrosForm";
            Text = "GestionarLibrosForm";
            Load += GestionarLibrosForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)librosDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton eliminarLibroButton;
        private FontAwesome.Sharp.IconButton agregarLibroButton;
        private FontAwesome.Sharp.IconButton editarLibroButton;
        private PictureBox pictureBox2;
        public DataGridView librosDataGridView;
        private FontAwesome.Sharp.IconButton categoriasButton;
    }
}