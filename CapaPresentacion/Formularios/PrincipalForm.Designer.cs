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
            superiorPanel = new Panel();
            button2 = new Button();
            cerrarButton = new Button();
            titleLabel = new Label();
            menuPanel = new Panel();
            historialButton = new FontAwesome.Sharp.IconButton();
            librosButton = new FontAwesome.Sharp.IconButton();
            devolucionesButton = new FontAwesome.Sharp.IconButton();
            prestamosButton = new FontAwesome.Sharp.IconButton();
            gestionarLibrosButton = new FontAwesome.Sharp.IconButton();
            bibliotecariosButton = new FontAwesome.Sharp.IconButton();
            panelControlButton = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            contenedorPanel = new Panel();
            pictureBox2 = new PictureBox();
            superiorPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // superiorPanel
            // 
            superiorPanel.BackColor = SystemColors.Window;
            superiorPanel.Controls.Add(pictureBox2);
            superiorPanel.Controls.Add(button2);
            superiorPanel.Controls.Add(cerrarButton);
            superiorPanel.Controls.Add(titleLabel);
            superiorPanel.Dock = DockStyle.Top;
            superiorPanel.Location = new Point(0, 0);
            superiorPanel.Name = "superiorPanel";
            superiorPanel.Size = new Size(1250, 60);
            superiorPanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1154, 9);
            button2.Name = "button2";
            button2.Size = new Size(39, 37);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // cerrarButton
            // 
            cerrarButton.FlatAppearance.BorderSize = 0;
            cerrarButton.FlatStyle = FlatStyle.Flat;
            cerrarButton.Image = (Image)resources.GetObject("cerrarButton.Image");
            cerrarButton.Location = new Point(1199, 8);
            cerrarButton.Name = "cerrarButton";
            cerrarButton.Size = new Size(39, 37);
            cerrarButton.TabIndex = 2;
            cerrarButton.UseVisualStyleBackColor = true;
            cerrarButton.Click += cerrarButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(162, 129, 112);
            titleLabel.Location = new Point(77, 13);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(178, 33);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "B I B L I O T E C A";
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(162, 129, 112);
            menuPanel.Controls.Add(pictureBox1);
            menuPanel.Controls.Add(historialButton);
            menuPanel.Controls.Add(librosButton);
            menuPanel.Controls.Add(devolucionesButton);
            menuPanel.Controls.Add(prestamosButton);
            menuPanel.Controls.Add(gestionarLibrosButton);
            menuPanel.Controls.Add(bibliotecariosButton);
            menuPanel.Controls.Add(panelControlButton);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 60);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(255, 689);
            menuPanel.TabIndex = 1;
            // 
            // historialButton
            // 
            historialButton.FlatStyle = FlatStyle.Flat;
            historialButton.ForeColor = SystemColors.MenuBar;
            historialButton.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            historialButton.IconColor = SystemColors.MenuBar;
            historialButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            historialButton.IconSize = 30;
            historialButton.ImageAlign = ContentAlignment.MiddleLeft;
            historialButton.Location = new Point(31, 535);
            historialButton.Margin = new Padding(0);
            historialButton.Name = "historialButton";
            historialButton.Size = new Size(190, 38);
            historialButton.TabIndex = 7;
            historialButton.Text = " Historial";
            historialButton.UseVisualStyleBackColor = true;
            historialButton.Click += historialButton_Click;
            // 
            // librosButton
            // 
            librosButton.FlatStyle = FlatStyle.Flat;
            librosButton.ForeColor = SystemColors.MenuBar;
            librosButton.IconChar = FontAwesome.Sharp.IconChar.Book;
            librosButton.IconColor = SystemColors.MenuBar;
            librosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            librosButton.IconSize = 30;
            librosButton.ImageAlign = ContentAlignment.MiddleLeft;
            librosButton.Location = new Point(31, 481);
            librosButton.Margin = new Padding(0);
            librosButton.Name = "librosButton";
            librosButton.Size = new Size(190, 38);
            librosButton.TabIndex = 6;
            librosButton.Text = " Libros ";
            librosButton.UseVisualStyleBackColor = true;
            librosButton.Click += librosButton_Click;
            // 
            // devolucionesButton
            // 
            devolucionesButton.FlatStyle = FlatStyle.Flat;
            devolucionesButton.ForeColor = SystemColors.MenuBar;
            devolucionesButton.IconChar = FontAwesome.Sharp.IconChar.Reply;
            devolucionesButton.IconColor = SystemColors.MenuBar;
            devolucionesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            devolucionesButton.IconSize = 30;
            devolucionesButton.ImageAlign = ContentAlignment.MiddleLeft;
            devolucionesButton.Location = new Point(31, 424);
            devolucionesButton.Margin = new Padding(0);
            devolucionesButton.Name = "devolucionesButton";
            devolucionesButton.Size = new Size(190, 38);
            devolucionesButton.TabIndex = 5;
            devolucionesButton.Text = "    Devoluciones";
            devolucionesButton.UseVisualStyleBackColor = true;
            devolucionesButton.Click += devolucionesButton_Click;
            // 
            // prestamosButton
            // 
            prestamosButton.FlatStyle = FlatStyle.Flat;
            prestamosButton.ForeColor = SystemColors.MenuBar;
            prestamosButton.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            prestamosButton.IconColor = SystemColors.MenuBar;
            prestamosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            prestamosButton.IconSize = 30;
            prestamosButton.ImageAlign = ContentAlignment.MiddleLeft;
            prestamosButton.Location = new Point(31, 364);
            prestamosButton.Margin = new Padding(0);
            prestamosButton.Name = "prestamosButton";
            prestamosButton.Size = new Size(190, 38);
            prestamosButton.TabIndex = 4;
            prestamosButton.Text = "Préstamos";
            prestamosButton.UseVisualStyleBackColor = true;
            prestamosButton.Click += prestamosButton_Click;
            // 
            // gestionarLibrosButton
            // 
            gestionarLibrosButton.FlatStyle = FlatStyle.Flat;
            gestionarLibrosButton.ForeColor = SystemColors.MenuBar;
            gestionarLibrosButton.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            gestionarLibrosButton.IconColor = SystemColors.MenuBar;
            gestionarLibrosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            gestionarLibrosButton.IconSize = 30;
            gestionarLibrosButton.ImageAlign = ContentAlignment.MiddleLeft;
            gestionarLibrosButton.Location = new Point(31, 301);
            gestionarLibrosButton.Margin = new Padding(0);
            gestionarLibrosButton.Name = "gestionarLibrosButton";
            gestionarLibrosButton.Size = new Size(190, 38);
            gestionarLibrosButton.TabIndex = 3;
            gestionarLibrosButton.Text = "Gestionar libros";
            gestionarLibrosButton.TextAlign = ContentAlignment.MiddleRight;
            gestionarLibrosButton.UseVisualStyleBackColor = true;
            gestionarLibrosButton.Click += gestionarLibrosButton_Click;
            // 
            // bibliotecariosButton
            // 
            bibliotecariosButton.FlatStyle = FlatStyle.Flat;
            bibliotecariosButton.ForeColor = SystemColors.MenuBar;
            bibliotecariosButton.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            bibliotecariosButton.IconColor = SystemColors.MenuBar;
            bibliotecariosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bibliotecariosButton.IconSize = 30;
            bibliotecariosButton.ImageAlign = ContentAlignment.MiddleLeft;
            bibliotecariosButton.Location = new Point(32, 242);
            bibliotecariosButton.Margin = new Padding(0);
            bibliotecariosButton.Name = "bibliotecariosButton";
            bibliotecariosButton.Size = new Size(190, 38);
            bibliotecariosButton.TabIndex = 2;
            bibliotecariosButton.Text = "Bibliotecarios";
            bibliotecariosButton.TextAlign = ContentAlignment.MiddleRight;
            bibliotecariosButton.UseVisualStyleBackColor = true;
            bibliotecariosButton.Click += bibliotecariosButton_Click;
            // 
            // panelControlButton
            // 
            panelControlButton.BackColor = Color.FromArgb(162, 129, 112);
            panelControlButton.FlatStyle = FlatStyle.Flat;
            panelControlButton.ForeColor = SystemColors.MenuBar;
            panelControlButton.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            panelControlButton.IconColor = SystemColors.MenuBar;
            panelControlButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            panelControlButton.IconSize = 30;
            panelControlButton.ImageAlign = ContentAlignment.MiddleLeft;
            panelControlButton.Location = new Point(32, 185);
            panelControlButton.Margin = new Padding(0);
            panelControlButton.Name = "panelControlButton";
            panelControlButton.Size = new Size(190, 38);
            panelControlButton.TabIndex = 1;
            panelControlButton.Text = "Panel de control";
            panelControlButton.TextAlign = ContentAlignment.MiddleRight;
            panelControlButton.UseVisualStyleBackColor = false;
            panelControlButton.Click += panelControlButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.MenuBar;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contenedorPanel
            // 
            contenedorPanel.Location = new Point(249, 60);
            contenedorPanel.Name = "contenedorPanel";
            contenedorPanel.Size = new Size(1001, 689);
            contenedorPanel.TabIndex = 2;
            contenedorPanel.Paint += contenedorPanel_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // PrincipalForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1250, 749);
            Controls.Add(contenedorPanel);
            Controls.Add(menuPanel);
            Controls.Add(superiorPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrincipalForm";
            Load += PrincipalForm_Load;
            superiorPanel.ResumeLayout(false);
            superiorPanel.PerformLayout();
            menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel superiorPanel;
        private Panel menuPanel;
        private Label titleLabel;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton panelControlButton;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private FontAwesome.Sharp.IconButton prestamosButton;
        private FontAwesome.Sharp.IconButton gestionarLibrosButton;
        private FontAwesome.Sharp.IconButton bibliotecariosButton;
        private Button cerrarButton;
        private Button button2;
        private FontAwesome.Sharp.IconButton devolucionesButton;
        private FontAwesome.Sharp.IconButton historialButton;
        private FontAwesome.Sharp.IconButton librosButton;
        private Panel contenedorPanel;
        private PictureBox pictureBox2;
    }
}