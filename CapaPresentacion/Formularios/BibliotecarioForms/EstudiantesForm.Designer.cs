namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    partial class EstudiantesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstudiantesForm));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            eliminarEstudianteButton = new FontAwesome.Sharp.IconButton();
            agregarEstudianteButton = new FontAwesome.Sharp.IconButton();
            editarEstudianteButton = new FontAwesome.Sharp.IconButton();
            estudiantesDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estudiantesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.ForeColor = Color.FromArgb(162, 129, 112);
            panel1.Location = new Point(283, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 12);
            panel1.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(304, 85);
            label2.Name = "label2";
            label2.Size = new Size(427, 42);
            label2.TabIndex = 39;
            label2.Text = "Gestión de Estudiantes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // eliminarEstudianteButton
            // 
            eliminarEstudianteButton.BackColor = Color.DarkRed;
            eliminarEstudianteButton.FlatStyle = FlatStyle.Flat;
            eliminarEstudianteButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminarEstudianteButton.ForeColor = SystemColors.MenuBar;
            eliminarEstudianteButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            eliminarEstudianteButton.IconColor = SystemColors.MenuBar;
            eliminarEstudianteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarEstudianteButton.IconSize = 40;
            eliminarEstudianteButton.ImageAlign = ContentAlignment.MiddleLeft;
            eliminarEstudianteButton.Location = new Point(832, 370);
            eliminarEstudianteButton.Margin = new Padding(0);
            eliminarEstudianteButton.Name = "eliminarEstudianteButton";
            eliminarEstudianteButton.Size = new Size(144, 49);
            eliminarEstudianteButton.TabIndex = 37;
            eliminarEstudianteButton.Text = "Eliminar";
            eliminarEstudianteButton.TextAlign = ContentAlignment.MiddleRight;
            eliminarEstudianteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            eliminarEstudianteButton.UseVisualStyleBackColor = false;
            eliminarEstudianteButton.Click += eliminarEstudianteButton_Click;
            // 
            // agregarEstudianteButton
            // 
            agregarEstudianteButton.BackColor = Color.FromArgb(58, 157, 35);
            agregarEstudianteButton.FlatStyle = FlatStyle.Flat;
            agregarEstudianteButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarEstudianteButton.ForeColor = SystemColors.MenuBar;
            agregarEstudianteButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            agregarEstudianteButton.IconColor = SystemColors.MenuBar;
            agregarEstudianteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            agregarEstudianteButton.IconSize = 40;
            agregarEstudianteButton.ImageAlign = ContentAlignment.MiddleLeft;
            agregarEstudianteButton.Location = new Point(832, 234);
            agregarEstudianteButton.Margin = new Padding(0);
            agregarEstudianteButton.Name = "agregarEstudianteButton";
            agregarEstudianteButton.Size = new Size(144, 48);
            agregarEstudianteButton.TabIndex = 35;
            agregarEstudianteButton.Text = "Agregar";
            agregarEstudianteButton.TextAlign = ContentAlignment.MiddleRight;
            agregarEstudianteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            agregarEstudianteButton.UseVisualStyleBackColor = false;
            agregarEstudianteButton.Click += agregarEstudianteButton_Click;
            // 
            // editarEstudianteButton
            // 
            editarEstudianteButton.BackColor = Color.SteelBlue;
            editarEstudianteButton.FlatStyle = FlatStyle.Flat;
            editarEstudianteButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editarEstudianteButton.ForeColor = SystemColors.MenuBar;
            editarEstudianteButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editarEstudianteButton.IconColor = SystemColors.MenuBar;
            editarEstudianteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editarEstudianteButton.IconSize = 40;
            editarEstudianteButton.ImageAlign = ContentAlignment.MiddleLeft;
            editarEstudianteButton.Location = new Point(832, 301);
            editarEstudianteButton.Margin = new Padding(0);
            editarEstudianteButton.Name = "editarEstudianteButton";
            editarEstudianteButton.Size = new Size(144, 48);
            editarEstudianteButton.TabIndex = 36;
            editarEstudianteButton.Text = "Editar";
            editarEstudianteButton.TextAlign = ContentAlignment.MiddleRight;
            editarEstudianteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            editarEstudianteButton.UseVisualStyleBackColor = false;
            editarEstudianteButton.Click += editarEstudianteButton_Click;
            // 
            // estudiantesDataGridView
            // 
            estudiantesDataGridView.AllowUserToAddRows = false;
            estudiantesDataGridView.AllowUserToDeleteRows = false;
            estudiantesDataGridView.AllowUserToResizeColumns = false;
            estudiantesDataGridView.AllowUserToResizeRows = false;
            estudiantesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            estudiantesDataGridView.Location = new Point(162, 186);
            estudiantesDataGridView.Name = "estudiantesDataGridView";
            estudiantesDataGridView.RowHeadersWidth = 51;
            estudiantesDataGridView.Size = new Size(645, 444);
            estudiantesDataGridView.TabIndex = 34;
            // 
            // EstudiantesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 673);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(eliminarEstudianteButton);
            Controls.Add(agregarEstudianteButton);
            Controls.Add(editarEstudianteButton);
            Controls.Add(estudiantesDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EstudiantesForm";
            Text = "EstudiantesForms";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)estudiantesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton eliminarEstudianteButton;
        private FontAwesome.Sharp.IconButton agregarEstudianteButton;
        private FontAwesome.Sharp.IconButton editarEstudianteButton;
        private DataGridView estudiantesDataGridView;
    }
}