
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
            menuEstudiantesGroupBox = new GroupBox();
            cargarEstudiantesButton = new Button();
            filtrarEstudiantesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estudiantesDataGridView).BeginInit();
            menuEstudiantesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.ForeColor = Color.FromArgb(162, 129, 112);
            panel1.Location = new Point(260, 64);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 9);
            panel1.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(271, 26);
            label2.Name = "label2";
            label2.Size = new Size(345, 36);
            label2.TabIndex = 39;
            label2.Text = "Gestión de Estudiantes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(142, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 62);
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
            eliminarEstudianteButton.Location = new Point(728, 278);
            eliminarEstudianteButton.Margin = new Padding(0);
            eliminarEstudianteButton.Name = "eliminarEstudianteButton";
            eliminarEstudianteButton.Size = new Size(126, 37);
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
            agregarEstudianteButton.Location = new Point(728, 176);
            agregarEstudianteButton.Margin = new Padding(0);
            agregarEstudianteButton.Name = "agregarEstudianteButton";
            agregarEstudianteButton.Size = new Size(126, 36);
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
            editarEstudianteButton.Location = new Point(728, 226);
            editarEstudianteButton.Margin = new Padding(0);
            editarEstudianteButton.Name = "editarEstudianteButton";
            editarEstudianteButton.Size = new Size(126, 36);
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
            estudiantesDataGridView.Location = new Point(161, 176);
            estudiantesDataGridView.Margin = new Padding(3, 2, 3, 2);
            estudiantesDataGridView.Name = "estudiantesDataGridView";
            estudiantesDataGridView.RowHeadersWidth = 51;
            estudiantesDataGridView.Size = new Size(564, 333);
            estudiantesDataGridView.TabIndex = 34;
            // 
            // menuEstudiantesGroupBox
            // 
            menuEstudiantesGroupBox.Controls.Add(cargarEstudiantesButton);
            menuEstudiantesGroupBox.Controls.Add(filtrarEstudiantesButton);
            menuEstudiantesGroupBox.Location = new Point(161, 92);
            menuEstudiantesGroupBox.Name = "menuEstudiantesGroupBox";
            menuEstudiantesGroupBox.Size = new Size(564, 73);
            menuEstudiantesGroupBox.TabIndex = 41;
            menuEstudiantesGroupBox.TabStop = false;
            menuEstudiantesGroupBox.Text = "Ordenar Estudiantes por Orden Alfabetico";
            // 
            // cargarEstudiantesButton
            // 
            cargarEstudiantesButton.Location = new Point(322, 37);
            cargarEstudiantesButton.Name = "cargarEstudiantesButton";
            cargarEstudiantesButton.Size = new Size(204, 23);
            cargarEstudiantesButton.TabIndex = 1;
            cargarEstudiantesButton.Text = "Cargar Estudiantes";
            cargarEstudiantesButton.UseVisualStyleBackColor = true;
            cargarEstudiantesButton.Click += cargarEstudiantesButton_Click;
            // 
            // filtrarEstudiantesButton
            // 
            filtrarEstudiantesButton.Location = new Point(20, 37);
            filtrarEstudiantesButton.Name = "filtrarEstudiantesButton";
            filtrarEstudiantesButton.Size = new Size(204, 23);
            filtrarEstudiantesButton.TabIndex = 0;
            filtrarEstudiantesButton.Text = "Ordenar Estudiantes";
            filtrarEstudiantesButton.UseVisualStyleBackColor = true;
            filtrarEstudiantesButton.Click += filtrarEstudiantesButton_Click;
            // 
            // EstudiantesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 571);
            Controls.Add(menuEstudiantesGroupBox);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(eliminarEstudianteButton);
            Controls.Add(agregarEstudianteButton);
            Controls.Add(editarEstudianteButton);
            Controls.Add(estudiantesDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EstudiantesForm";
            Text = "EstudiantesForms";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)estudiantesDataGridView).EndInit();
            menuEstudiantesGroupBox.ResumeLayout(false);
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
        private GroupBox menuEstudiantesGroupBox;
        private Button cargarEstudiantesButton;
        private Button filtrarEstudiantesButton;
    }
}