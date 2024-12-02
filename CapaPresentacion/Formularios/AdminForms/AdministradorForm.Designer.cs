namespace CapaPresentacion.Formularios.AdminForms
{
    partial class AdministradorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            eliminarAdministradorButton = new FontAwesome.Sharp.IconButton();
            agregarAdministradorButton = new FontAwesome.Sharp.IconButton();
            editarAdministradorButton = new FontAwesome.Sharp.IconButton();
            administradorDataGridView = new DataGridView();
            menuAdminGroupBox = new GroupBox();
            cargarAdminsButton = new Button();
            filtrarAdminsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administradorDataGridView).BeginInit();
            menuAdminGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.ForeColor = Color.FromArgb(162, 129, 112);
            panel1.Location = new Point(315, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 12);
            panel1.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(312, 64);
            label2.Name = "label2";
            label2.Size = new Size(462, 42);
            label2.TabIndex = 39;
            label2.Text = "Gestión de Administrador";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(177, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // eliminarAdministradorButton
            // 
            eliminarAdministradorButton.BackColor = Color.DarkRed;
            eliminarAdministradorButton.FlatStyle = FlatStyle.Flat;
            eliminarAdministradorButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminarAdministradorButton.ForeColor = SystemColors.MenuBar;
            eliminarAdministradorButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            eliminarAdministradorButton.IconColor = SystemColors.MenuBar;
            eliminarAdministradorButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarAdministradorButton.IconSize = 40;
            eliminarAdministradorButton.ImageAlign = ContentAlignment.MiddleLeft;
            eliminarAdministradorButton.Location = new Point(822, 372);
            eliminarAdministradorButton.Margin = new Padding(0);
            eliminarAdministradorButton.Name = "eliminarAdministradorButton";
            eliminarAdministradorButton.Size = new Size(144, 49);
            eliminarAdministradorButton.TabIndex = 37;
            eliminarAdministradorButton.Text = "Eliminar";
            eliminarAdministradorButton.TextAlign = ContentAlignment.MiddleRight;
            eliminarAdministradorButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            eliminarAdministradorButton.UseVisualStyleBackColor = false;
            eliminarAdministradorButton.Click += eliminarAdministradorButton_Click;
            // 
            // agregarAdministradorButton
            // 
            agregarAdministradorButton.BackColor = Color.FromArgb(58, 157, 35);
            agregarAdministradorButton.FlatStyle = FlatStyle.Flat;
            agregarAdministradorButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarAdministradorButton.ForeColor = SystemColors.MenuBar;
            agregarAdministradorButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            agregarAdministradorButton.IconColor = SystemColors.MenuBar;
            agregarAdministradorButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            agregarAdministradorButton.IconSize = 40;
            agregarAdministradorButton.ImageAlign = ContentAlignment.MiddleLeft;
            agregarAdministradorButton.Location = new Point(822, 257);
            agregarAdministradorButton.Margin = new Padding(0);
            agregarAdministradorButton.Name = "agregarAdministradorButton";
            agregarAdministradorButton.Size = new Size(144, 48);
            agregarAdministradorButton.TabIndex = 35;
            agregarAdministradorButton.Text = "Agregar";
            agregarAdministradorButton.TextAlign = ContentAlignment.MiddleRight;
            agregarAdministradorButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            agregarAdministradorButton.UseVisualStyleBackColor = false;
            agregarAdministradorButton.Click += agregarAdministradorButton_Click;
            // 
            // editarAdministradorButton
            // 
            editarAdministradorButton.BackColor = Color.SteelBlue;
            editarAdministradorButton.FlatStyle = FlatStyle.Flat;
            editarAdministradorButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editarAdministradorButton.ForeColor = SystemColors.MenuBar;
            editarAdministradorButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editarAdministradorButton.IconColor = SystemColors.MenuBar;
            editarAdministradorButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editarAdministradorButton.IconSize = 40;
            editarAdministradorButton.ImageAlign = ContentAlignment.MiddleLeft;
            editarAdministradorButton.Location = new Point(822, 312);
            editarAdministradorButton.Margin = new Padding(0);
            editarAdministradorButton.Name = "editarAdministradorButton";
            editarAdministradorButton.Size = new Size(144, 48);
            editarAdministradorButton.TabIndex = 36;
            editarAdministradorButton.Text = "Editar";
            editarAdministradorButton.TextAlign = ContentAlignment.MiddleRight;
            editarAdministradorButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            editarAdministradorButton.UseVisualStyleBackColor = false;
            editarAdministradorButton.Click += editarAdministradorButton_Click;
            // 
            // administradorDataGridView
            // 
            administradorDataGridView.AllowUserToAddRows = false;
            administradorDataGridView.AllowUserToDeleteRows = false;
            administradorDataGridView.AllowUserToResizeColumns = false;
            administradorDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            administradorDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            administradorDataGridView.BackgroundColor = SystemColors.ControlLight;
            administradorDataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            administradorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            administradorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            administradorDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            administradorDataGridView.Location = new Point(89, 269);
            administradorDataGridView.Name = "administradorDataGridView";
            administradorDataGridView.RowHeadersWidth = 51;
            administradorDataGridView.Size = new Size(714, 444);
            administradorDataGridView.TabIndex = 34;
            // 
            // menuAdminGroupBox
            // 
            menuAdminGroupBox.Controls.Add(cargarAdminsButton);
            menuAdminGroupBox.Controls.Add(filtrarAdminsButton);
            menuAdminGroupBox.Location = new Point(89, 169);
            menuAdminGroupBox.Margin = new Padding(3, 4, 3, 4);
            menuAdminGroupBox.Name = "menuAdminGroupBox";
            menuAdminGroupBox.Padding = new Padding(3, 4, 3, 4);
            menuAdminGroupBox.Size = new Size(714, 81);
            menuAdminGroupBox.TabIndex = 42;
            menuAdminGroupBox.TabStop = false;
            menuAdminGroupBox.Text = "Ordenar A-Z";
            // 
            // cargarAdminsButton
            // 
            cargarAdminsButton.BackColor = SystemColors.ActiveBorder;
            cargarAdminsButton.Location = new Point(129, 27);
            cargarAdminsButton.Margin = new Padding(3, 4, 3, 4);
            cargarAdminsButton.Name = "cargarAdminsButton";
            cargarAdminsButton.Size = new Size(97, 38);
            cargarAdminsButton.TabIndex = 1;
            cargarAdminsButton.Text = "Cargar";
            cargarAdminsButton.UseVisualStyleBackColor = false;
            cargarAdminsButton.Click += cargarAdminsButton_Click;
            // 
            // filtrarAdminsButton
            // 
            filtrarAdminsButton.BackColor = Color.FromArgb(128, 64, 0);
            filtrarAdminsButton.ForeColor = SystemColors.ButtonFace;
            filtrarAdminsButton.Location = new Point(23, 28);
            filtrarAdminsButton.Margin = new Padding(0);
            filtrarAdminsButton.Name = "filtrarAdminsButton";
            filtrarAdminsButton.Size = new Size(93, 37);
            filtrarAdminsButton.TabIndex = 0;
            filtrarAdminsButton.Text = "Filtrar";
            filtrarAdminsButton.UseVisualStyleBackColor = false;
            filtrarAdminsButton.Click += filtrarAdminsButton_Click;
            // 
            // AdministradorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 780);
            Controls.Add(menuAdminGroupBox);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(eliminarAdministradorButton);
            Controls.Add(agregarAdministradorButton);
            Controls.Add(editarAdministradorButton);
            Controls.Add(administradorDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdministradorForm";
            Text = "AdministradorForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)administradorDataGridView).EndInit();
            menuAdminGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton eliminarAdministradorButton;
        private FontAwesome.Sharp.IconButton agregarAdministradorButton;
        private FontAwesome.Sharp.IconButton editarAdministradorButton;
        private DataGridView administradorDataGridView;
        private GroupBox menuAdminGroupBox;
        private Button cargarAdminsButton;
        private Button filtrarAdminsButton;
    }
}