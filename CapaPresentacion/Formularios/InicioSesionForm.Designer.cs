namespace CapaPresentacion.Formulario
{
    partial class LoginFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFormulario));
            panelSuperior = new Panel();
            titulLabel = new Label();
            iconoBox = new PictureBox();
            panelCentral = new Panel();
            errorLoginLabel = new Label();
            iniciarBtn = new Button();
            cancelarBtn = new Button();
            contraseñaLabel = new Label();
            usuarioLabel = new Label();
            claveLoginTextBox = new TextBox();
            usuarioLoginTextBox = new TextBox();
            panelInferior = new Panel();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconoBox).BeginInit();
            panelCentral.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(162, 129, 112);
            panelSuperior.Controls.Add(titulLabel);
            panelSuperior.Controls.Add(iconoBox);
            panelSuperior.Dock = DockStyle.Fill;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(584, 361);
            panelSuperior.TabIndex = 0;
            // 
            // titulLabel
            // 
            titulLabel.AutoSize = true;
            titulLabel.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulLabel.ForeColor = SystemColors.ControlLightLight;
            titulLabel.Location = new Point(145, 20);
            titulLabel.Name = "titulLabel";
            titulLabel.Size = new Size(346, 38);
            titulLabel.TabIndex = 1;
            titulLabel.Text = "Gestión de biblioteca";
            // 
            // iconoBox
            // 
            iconoBox.Image = (Image)resources.GetObject("iconoBox.Image");
            iconoBox.Location = new Point(0, 0);
            iconoBox.Name = "iconoBox";
            iconoBox.Size = new Size(100, 75);
            iconoBox.SizeMode = PictureBoxSizeMode.Zoom;
            iconoBox.TabIndex = 0;
            iconoBox.TabStop = false;
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.White;
            panelCentral.Controls.Add(errorLoginLabel);
            panelCentral.Controls.Add(iniciarBtn);
            panelCentral.Controls.Add(cancelarBtn);
            panelCentral.Controls.Add(contraseñaLabel);
            panelCentral.Controls.Add(usuarioLabel);
            panelCentral.Controls.Add(claveLoginTextBox);
            panelCentral.Controls.Add(usuarioLoginTextBox);
            panelCentral.Location = new Point(0, 75);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(584, 286);
            panelCentral.TabIndex = 1;
            // 
            // errorLoginLabel
            // 
            errorLoginLabel.AutoSize = true;
            errorLoginLabel.ForeColor = Color.Crimson;
            errorLoginLabel.Location = new Point(185, 206);
            errorLoginLabel.Name = "errorLoginLabel";
            errorLoginLabel.Size = new Size(0, 15);
            errorLoginLabel.TabIndex = 6;
            // 
            // iniciarBtn
            // 
            iniciarBtn.BackColor = Color.FromArgb(162, 129, 112);
            iniciarBtn.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iniciarBtn.ForeColor = SystemColors.ControlLightLight;
            iniciarBtn.Location = new Point(171, 160);
            iniciarBtn.Name = "iniciarBtn";
            iniciarBtn.Size = new Size(88, 26);
            iniciarBtn.TabIndex = 5;
            iniciarBtn.Text = "Iniciar";
            iniciarBtn.UseVisualStyleBackColor = false;
            iniciarBtn.Click += iniciarBtn_Click;
            // 
            // cancelarBtn
            // 
            cancelarBtn.BackColor = Color.FromArgb(162, 129, 112);
            cancelarBtn.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelarBtn.ForeColor = SystemColors.ButtonHighlight;
            cancelarBtn.Location = new Point(295, 158);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(114, 28);
            cancelarBtn.TabIndex = 4;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = false;
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contraseñaLabel.Location = new Point(145, 98);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new Size(114, 23);
            contraseñaLabel.TabIndex = 3;
            contraseñaLabel.Text = "Contraseña";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuarioLabel.Location = new Point(171, 48);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new Size(81, 23);
            usuarioLabel.TabIndex = 2;
            usuarioLabel.Text = "Usuario";
            // 
            // claveLoginTextBox
            // 
            claveLoginTextBox.BackColor = Color.White;
            claveLoginTextBox.Location = new Point(295, 98);
            claveLoginTextBox.Multiline = true;
            claveLoginTextBox.Name = "claveLoginTextBox";
            claveLoginTextBox.PasswordChar = '*';
            claveLoginTextBox.Size = new Size(114, 31);
            claveLoginTextBox.TabIndex = 1;
            // 
            // usuarioLoginTextBox
            // 
            usuarioLoginTextBox.BackColor = Color.White;
            usuarioLoginTextBox.Location = new Point(295, 48);
            usuarioLoginTextBox.Multiline = true;
            usuarioLoginTextBox.Name = "usuarioLoginTextBox";
            usuarioLoginTextBox.Size = new Size(114, 31);
            usuarioLoginTextBox.TabIndex = 0;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(162, 129, 112);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 311);
            panelInferior.Margin = new Padding(0);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(584, 50);
            panelInferior.TabIndex = 2;
            // 
            // LoginFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(panelInferior);
            Controls.Add(panelCentral);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginFormulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconoBox).EndInit();
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Panel panelCentral;
        private Panel panelInferior;
        private PictureBox iconoBox;
        private Label titulLabel;
        private Button iniciarBtn;
        private Button cancelarBtn;
        private Label contraseñaLabel;
        private Label usuarioLabel;
        private TextBox claveLoginTextBox;
        private TextBox usuarioLoginTextBox;
        private Label errorLoginLabel;
    }
}