
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            panel1.Location = new Point(253, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 12);
            panel1.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(266, 68);
            label2.Name = "label2";
            label2.Size = new Size(427, 42);
            label2.TabIndex = 39;
            label2.Text = "Gestión de Estudiantes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(118, 48);
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
            eliminarEstudianteButton.Location = new Point(820, 371);
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
            agregarEstudianteButton.Location = new Point(820, 235);
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
            editarEstudianteButton.Location = new Point(820, 301);
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
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            estudiantesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            estudiantesDataGridView.BackgroundColor = SystemColors.ControlLight;
            estudiantesDataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            estudiantesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            estudiantesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            estudiantesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            estudiantesDataGridView.Location = new Point(83, 235);
            estudiantesDataGridView.Name = "estudiantesDataGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            estudiantesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            estudiantesDataGridView.RowHeadersWidth = 51;
            estudiantesDataGridView.Size = new Size(711, 489);
            estudiantesDataGridView.TabIndex = 34;
            // 
            // menuEstudiantesGroupBox
            // 
            menuEstudiantesGroupBox.Controls.Add(cargarEstudiantesButton);
            menuEstudiantesGroupBox.Controls.Add(filtrarEstudiantesButton);
            menuEstudiantesGroupBox.Location = new Point(83, 138);
            menuEstudiantesGroupBox.Margin = new Padding(3, 4, 3, 4);
            menuEstudiantesGroupBox.Name = "menuEstudiantesGroupBox";
            menuEstudiantesGroupBox.Padding = new Padding(3, 4, 3, 4);
            menuEstudiantesGroupBox.Size = new Size(711, 77);
            menuEstudiantesGroupBox.TabIndex = 41;
            menuEstudiantesGroupBox.TabStop = false;
            menuEstudiantesGroupBox.Text = "Ordenar A-Z";
            // 
            // cargarEstudiantesButton
            // 
            cargarEstudiantesButton.BackColor = SystemColors.ActiveBorder;
            cargarEstudiantesButton.Location = new Point(127, 28);
            cargarEstudiantesButton.Margin = new Padding(3, 4, 3, 4);
            cargarEstudiantesButton.Name = "cargarEstudiantesButton";
            cargarEstudiantesButton.Size = new Size(84, 41);
            cargarEstudiantesButton.TabIndex = 1;
            cargarEstudiantesButton.Text = "Cargar";
            cargarEstudiantesButton.UseVisualStyleBackColor = false;
            cargarEstudiantesButton.Click += cargarEstudiantesButton_Click;
            // 
            // filtrarEstudiantesButton
            // 
            filtrarEstudiantesButton.BackColor = Color.FromArgb(128, 64, 0);
            filtrarEstudiantesButton.ForeColor = SystemColors.Control;
            filtrarEstudiantesButton.Location = new Point(23, 28);
            filtrarEstudiantesButton.Margin = new Padding(3, 4, 3, 4);
            filtrarEstudiantesButton.Name = "filtrarEstudiantesButton";
            filtrarEstudiantesButton.Size = new Size(83, 41);
            filtrarEstudiantesButton.TabIndex = 0;
            filtrarEstudiantesButton.Text = "Filtrar";
            filtrarEstudiantesButton.UseVisualStyleBackColor = false;
            filtrarEstudiantesButton.Click += filtrarEstudiantesButton_Click;
            // 
            // EstudiantesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 780);
            Controls.Add(menuEstudiantesGroupBox);
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