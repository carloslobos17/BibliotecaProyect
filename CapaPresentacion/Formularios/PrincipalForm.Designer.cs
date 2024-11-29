namespace CapaPresentacion
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            menuPanel = new Panel();
            administradoresButton = new FontAwesome.Sharp.IconButton();
            estudiantesButton = new FontAwesome.Sharp.IconButton();
            salirIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            correoUsuarioLabel = new Label();
            nombreUsuarioLabel = new Label();
            pictureBox1 = new PictureBox();
            historialButton = new FontAwesome.Sharp.IconButton();
            librosButton = new FontAwesome.Sharp.IconButton();
            devolucionesButton = new FontAwesome.Sharp.IconButton();
            prestamosButton = new FontAwesome.Sharp.IconButton();
            gestionarLibrosButton = new FontAwesome.Sharp.IconButton();
            bibliotecariosButton = new FontAwesome.Sharp.IconButton();
            panelControlButton = new FontAwesome.Sharp.IconButton();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            contenedorPanel = new Panel();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salirIconPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(44, 62, 80);
            menuPanel.Controls.Add(administradoresButton);
            menuPanel.Controls.Add(estudiantesButton);
            menuPanel.Controls.Add(salirIconPictureBox);
            menuPanel.Controls.Add(correoUsuarioLabel);
            menuPanel.Controls.Add(nombreUsuarioLabel);
            menuPanel.Controls.Add(pictureBox1);
            menuPanel.Controls.Add(historialButton);
            menuPanel.Controls.Add(librosButton);
            menuPanel.Controls.Add(devolucionesButton);
            menuPanel.Controls.Add(prestamosButton);
            menuPanel.Controls.Add(gestionarLibrosButton);
            menuPanel.Controls.Add(bibliotecariosButton);
            menuPanel.Controls.Add(panelControlButton);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(258, 789);
            menuPanel.TabIndex = 1;
            menuPanel.Paint += menuPanel_Paint;
            // 
            // administradoresButton
            // 
            administradoresButton.BackColor = Color.FromArgb(37, 53, 68);
            administradoresButton.FlatStyle = FlatStyle.Flat;
            administradoresButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            administradoresButton.ForeColor = SystemColors.MenuBar;
            administradoresButton.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            administradoresButton.IconColor = SystemColors.MenuBar;
            administradoresButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            administradoresButton.IconSize = 30;
            administradoresButton.ImageAlign = ContentAlignment.MiddleLeft;
            administradoresButton.Location = new Point(29, 292);
            administradoresButton.Margin = new Padding(0);
            administradoresButton.Name = "administradoresButton";
            administradoresButton.Size = new Size(190, 38);
            administradoresButton.TabIndex = 13;
            administradoresButton.Text = "Administradores";
            administradoresButton.TextAlign = ContentAlignment.MiddleRight;
            administradoresButton.UseVisualStyleBackColor = false;
            administradoresButton.Click += administradoresButton_Click;
            // 
            // estudiantesButton
            // 
            estudiantesButton.BackColor = Color.FromArgb(37, 53, 68);
            estudiantesButton.FlatStyle = FlatStyle.Flat;
            estudiantesButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            estudiantesButton.ForeColor = SystemColors.MenuBar;
            estudiantesButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            estudiantesButton.IconColor = SystemColors.MenuBar;
            estudiantesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            estudiantesButton.IconSize = 30;
            estudiantesButton.ImageAlign = ContentAlignment.MiddleLeft;
            estudiantesButton.Location = new Point(29, 405);
            estudiantesButton.Margin = new Padding(0);
            estudiantesButton.Name = "estudiantesButton";
            estudiantesButton.Size = new Size(190, 38);
            estudiantesButton.TabIndex = 12;
            estudiantesButton.Text = "Estudiantes";
            estudiantesButton.TextAlign = ContentAlignment.MiddleRight;
            estudiantesButton.UseVisualStyleBackColor = false;
            estudiantesButton.Click += estudiantesButton_Click;
            // 
            // salirIconPictureBox
            // 
            salirIconPictureBox.BackColor = Color.FromArgb(44, 62, 80);
            salirIconPictureBox.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            salirIconPictureBox.IconColor = Color.White;
            salirIconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            salirIconPictureBox.IconSize = 40;
            salirIconPictureBox.Location = new Point(201, 737);
            salirIconPictureBox.Name = "salirIconPictureBox";
            salirIconPictureBox.Size = new Size(40, 40);
            salirIconPictureBox.TabIndex = 11;
            salirIconPictureBox.TabStop = false;
            salirIconPictureBox.Click += salirIconPictureBox_Click;
            // 
            // correoUsuarioLabel
            // 
            correoUsuarioLabel.AutoSize = true;
            correoUsuarioLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            correoUsuarioLabel.ForeColor = Color.White;
            correoUsuarioLabel.Location = new Point(29, 187);
            correoUsuarioLabel.Name = "correoUsuarioLabel";
            correoUsuarioLabel.Size = new Size(198, 20);
            correoUsuarioLabel.TabIndex = 10;
            correoUsuarioLabel.Text = "mariasalome@gmail.com";
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreUsuarioLabel.ForeColor = Color.White;
            nombreUsuarioLabel.Location = new Point(58, 162);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new Size(133, 25);
            nombreUsuarioLabel.TabIndex = 9;
            nombreUsuarioLabel.Text = "Maria Salomé";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // historialButton
            // 
            historialButton.BackColor = Color.FromArgb(37, 53, 68);
            historialButton.FlatStyle = FlatStyle.Flat;
            historialButton.ForeColor = SystemColors.MenuBar;
            historialButton.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            historialButton.IconColor = SystemColors.MenuBar;
            historialButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            historialButton.IconSize = 30;
            historialButton.ImageAlign = ContentAlignment.MiddleLeft;
            historialButton.Location = new Point(29, 693);
            historialButton.Margin = new Padding(0);
            historialButton.Name = "historialButton";
            historialButton.Size = new Size(190, 38);
            historialButton.TabIndex = 7;
            historialButton.Text = " Historial";
            historialButton.UseVisualStyleBackColor = false;
            historialButton.Click += historialButton_Click;
            // 
            // librosButton
            // 
            librosButton.BackColor = Color.FromArgb(37, 53, 68);
            librosButton.FlatStyle = FlatStyle.Flat;
            librosButton.ForeColor = SystemColors.MenuBar;
            librosButton.IconChar = FontAwesome.Sharp.IconChar.Book;
            librosButton.IconColor = SystemColors.MenuBar;
            librosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            librosButton.IconSize = 30;
            librosButton.ImageAlign = ContentAlignment.MiddleLeft;
            librosButton.Location = new Point(29, 638);
            librosButton.Margin = new Padding(0);
            librosButton.Name = "librosButton";
            librosButton.Size = new Size(190, 38);
            librosButton.TabIndex = 6;
            librosButton.Text = " Libros ";
            librosButton.UseVisualStyleBackColor = false;
            librosButton.Click += librosButton_Click;
            // 
            // devolucionesButton
            // 
            devolucionesButton.BackColor = Color.FromArgb(37, 53, 68);
            devolucionesButton.FlatStyle = FlatStyle.Flat;
            devolucionesButton.ForeColor = SystemColors.MenuBar;
            devolucionesButton.IconChar = FontAwesome.Sharp.IconChar.Reply;
            devolucionesButton.IconColor = SystemColors.MenuBar;
            devolucionesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            devolucionesButton.IconSize = 30;
            devolucionesButton.ImageAlign = ContentAlignment.MiddleLeft;
            devolucionesButton.Location = new Point(29, 583);
            devolucionesButton.Margin = new Padding(0);
            devolucionesButton.Name = "devolucionesButton";
            devolucionesButton.Size = new Size(190, 38);
            devolucionesButton.TabIndex = 5;
            devolucionesButton.Text = "    Devoluciones";
            devolucionesButton.UseVisualStyleBackColor = false;
            devolucionesButton.Click += devolucionesButton_Click;
            // 
            // prestamosButton
            // 
            prestamosButton.BackColor = Color.FromArgb(37, 53, 68);
            prestamosButton.FlatStyle = FlatStyle.Flat;
            prestamosButton.ForeColor = SystemColors.MenuBar;
            prestamosButton.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            prestamosButton.IconColor = SystemColors.MenuBar;
            prestamosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            prestamosButton.IconSize = 30;
            prestamosButton.ImageAlign = ContentAlignment.MiddleLeft;
            prestamosButton.Location = new Point(29, 522);
            prestamosButton.Margin = new Padding(0);
            prestamosButton.Name = "prestamosButton";
            prestamosButton.Size = new Size(190, 38);
            prestamosButton.TabIndex = 4;
            prestamosButton.Text = "Préstamos";
            prestamosButton.UseVisualStyleBackColor = false;
            prestamosButton.Click += prestamosButton_Click;
            // 
            // gestionarLibrosButton
            // 
            gestionarLibrosButton.BackColor = Color.FromArgb(37, 53, 68);
            gestionarLibrosButton.FlatStyle = FlatStyle.Flat;
            gestionarLibrosButton.ForeColor = SystemColors.MenuBar;
            gestionarLibrosButton.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            gestionarLibrosButton.IconColor = SystemColors.MenuBar;
            gestionarLibrosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            gestionarLibrosButton.IconSize = 30;
            gestionarLibrosButton.ImageAlign = ContentAlignment.MiddleLeft;
            gestionarLibrosButton.Location = new Point(29, 462);
            gestionarLibrosButton.Margin = new Padding(0);
            gestionarLibrosButton.Name = "gestionarLibrosButton";
            gestionarLibrosButton.Size = new Size(190, 38);
            gestionarLibrosButton.TabIndex = 3;
            gestionarLibrosButton.Text = "Gestionar libros";
            gestionarLibrosButton.TextAlign = ContentAlignment.MiddleRight;
            gestionarLibrosButton.UseVisualStyleBackColor = false;
            gestionarLibrosButton.Click += gestionarLibrosButton_Click;
            // 
            // bibliotecariosButton
            // 
            bibliotecariosButton.BackColor = Color.FromArgb(37, 53, 68);
            bibliotecariosButton.FlatStyle = FlatStyle.Flat;
            bibliotecariosButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bibliotecariosButton.ForeColor = SystemColors.MenuBar;
            bibliotecariosButton.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            bibliotecariosButton.IconColor = SystemColors.MenuBar;
            bibliotecariosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bibliotecariosButton.IconSize = 30;
            bibliotecariosButton.ImageAlign = ContentAlignment.MiddleLeft;
            bibliotecariosButton.Location = new Point(29, 348);
            bibliotecariosButton.Margin = new Padding(0);
            bibliotecariosButton.Name = "bibliotecariosButton";
            bibliotecariosButton.Size = new Size(190, 38);
            bibliotecariosButton.TabIndex = 2;
            bibliotecariosButton.Text = "Bibliotecarios";
            bibliotecariosButton.TextAlign = ContentAlignment.MiddleRight;
            bibliotecariosButton.UseVisualStyleBackColor = false;
            bibliotecariosButton.Click += bibliotecariosButton_Click;
            // 
            // panelControlButton
            // 
            panelControlButton.BackColor = Color.FromArgb(37, 53, 68);
            panelControlButton.FlatStyle = FlatStyle.Flat;
            panelControlButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelControlButton.ForeColor = SystemColors.MenuBar;
            panelControlButton.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            panelControlButton.IconColor = SystemColors.MenuBar;
            panelControlButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            panelControlButton.IconSize = 30;
            panelControlButton.ImageAlign = ContentAlignment.MiddleLeft;
            panelControlButton.Location = new Point(29, 237);
            panelControlButton.Margin = new Padding(0);
            panelControlButton.Name = "panelControlButton";
            panelControlButton.Size = new Size(190, 38);
            panelControlButton.TabIndex = 1;
            panelControlButton.Text = "Panel de control";
            panelControlButton.TextAlign = ContentAlignment.MiddleRight;
            panelControlButton.UseVisualStyleBackColor = false;
            panelControlButton.Click += panelControlButton_Click;
            // 
            // contenedorPanel
            // 
            contenedorPanel.Location = new Point(257, 0);
            contenedorPanel.Name = "contenedorPanel";
            contenedorPanel.Size = new Size(993, 789);
            contenedorPanel.TabIndex = 2;
            // 
            // PrincipalForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1250, 789);
            Controls.Add(contenedorPanel);
            Controls.Add(menuPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrincipalForm";
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)salirIconPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel menuPanel;
        private FontAwesome.Sharp.IconButton panelControlButton;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private FontAwesome.Sharp.IconButton prestamosButton;
        private FontAwesome.Sharp.IconButton gestionarLibrosButton;
        private FontAwesome.Sharp.IconButton bibliotecariosButton;
        private FontAwesome.Sharp.IconButton devolucionesButton;
        private FontAwesome.Sharp.IconButton historialButton;
        private FontAwesome.Sharp.IconButton librosButton;
        private Panel contenedorPanel;
        private PictureBox pictureBox1;
        private Label nombreUsuarioLabel;
        private Label correoUsuarioLabel;
        private FontAwesome.Sharp.IconPictureBox salirIconPictureBox;
        private FontAwesome.Sharp.IconButton estudiantesButton;
        private FontAwesome.Sharp.IconButton administradoresButton;
    }
}