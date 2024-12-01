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
            panel1.Location = new Point(239, 81);
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
            label2.Location = new Point(236, 43);
            label2.Name = "label2";
            label2.Size = new Size(376, 36);
            label2.TabIndex = 39;
            label2.Text = "Gestión de Administrador";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(118, 28);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 62);
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
            eliminarAdministradorButton.Location = new Point(719, 279);
            eliminarAdministradorButton.Margin = new Padding(0);
            eliminarAdministradorButton.Name = "eliminarAdministradorButton";
            eliminarAdministradorButton.Size = new Size(126, 37);
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
            agregarAdministradorButton.Location = new Point(719, 193);
            agregarAdministradorButton.Margin = new Padding(0);
            agregarAdministradorButton.Name = "agregarAdministradorButton";
            agregarAdministradorButton.Size = new Size(126, 36);
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
            editarAdministradorButton.Location = new Point(719, 234);
            editarAdministradorButton.Margin = new Padding(0);
            editarAdministradorButton.Name = "editarAdministradorButton";
            editarAdministradorButton.Size = new Size(126, 36);
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
            administradorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            administradorDataGridView.Location = new Point(138, 193);
            administradorDataGridView.Margin = new Padding(3, 2, 3, 2);
            administradorDataGridView.Name = "administradorDataGridView";
            administradorDataGridView.RowHeadersWidth = 51;
            administradorDataGridView.Size = new Size(564, 333);
            administradorDataGridView.TabIndex = 34;
            // 
            // menuAdminGroupBox
            // 
            menuAdminGroupBox.Controls.Add(cargarAdminsButton);
            menuAdminGroupBox.Controls.Add(filtrarAdminsButton);
            menuAdminGroupBox.Location = new Point(138, 115);
            menuAdminGroupBox.Name = "menuAdminGroupBox";
            menuAdminGroupBox.Size = new Size(564, 73);
            menuAdminGroupBox.TabIndex = 42;
            menuAdminGroupBox.TabStop = false;
            menuAdminGroupBox.Text = "Ordenar Administradores por Orden Alfabetico";
            // 
            // cargarAdminsButton
            // 
            cargarAdminsButton.Location = new Point(324, 37);
            cargarAdminsButton.Name = "cargarAdminsButton";
            cargarAdminsButton.Size = new Size(204, 23);
            cargarAdminsButton.TabIndex = 1;
            cargarAdminsButton.Text = "Cargar Administradores";
            cargarAdminsButton.UseVisualStyleBackColor = true;
            cargarAdminsButton.Click += cargarAdminsButton_Click;
            // 
            // filtrarAdminsButton
            // 
            filtrarAdminsButton.Location = new Point(20, 37);
            filtrarAdminsButton.Name = "filtrarAdminsButton";
            filtrarAdminsButton.Size = new Size(204, 23);
            filtrarAdminsButton.TabIndex = 0;
            filtrarAdminsButton.Text = "Ordenar Administradores";
            filtrarAdminsButton.UseVisualStyleBackColor = true;
            filtrarAdminsButton.Click += filtrarAdminsButton_Click;
            // 
            // AdministradorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 585);
            Controls.Add(menuAdminGroupBox);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(eliminarAdministradorButton);
            Controls.Add(agregarAdministradorButton);
            Controls.Add(editarAdministradorButton);
            Controls.Add(administradorDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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