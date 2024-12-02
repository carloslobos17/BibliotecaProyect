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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFormulario));
            panelSuperior = new Panel();
            titulLabel = new Label();
            iconoBox = new PictureBox();
            panelCentral = new Panel();
            errorLoginLabel = new Label();
            iniciarBtn = new Button();
            cancelarBtn = new Button();
            contraseñaLabel = new Label();
            correoLabel = new Label();
            claveSesionTextBox = new TextBox();
            correoSesionTextBox = new TextBox();
            panelInferior = new Panel();
            validacionErrorProvider = new ErrorProvider(components);
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconoBox).BeginInit();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validacionErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(37, 53, 68);
            panelSuperior.Controls.Add(titulLabel);
            panelSuperior.Controls.Add(iconoBox);
            panelSuperior.Dock = DockStyle.Fill;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Margin = new Padding(3, 4, 3, 4);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(667, 481);
            panelSuperior.TabIndex = 0;
            // 
            // titulLabel
            // 
            titulLabel.AutoSize = true;
            titulLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulLabel.ForeColor = SystemColors.ControlLightLight;
            titulLabel.Location = new Point(133, 25);
            titulLabel.Name = "titulLabel";
            titulLabel.Size = new Size(511, 46);
            titulLabel.TabIndex = 1;
            titulLabel.Text = "GESTION DE BIBLIOTECA";
            // 
            // iconoBox
            // 
            iconoBox.Image = (Image)resources.GetObject("iconoBox.Image");
            iconoBox.Location = new Point(0, 0);
            iconoBox.Margin = new Padding(3, 4, 3, 4);
            iconoBox.Name = "iconoBox";
            iconoBox.Size = new Size(114, 100);
            iconoBox.SizeMode = PictureBoxSizeMode.Zoom;
            iconoBox.TabIndex = 0;
            iconoBox.TabStop = false;
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.LightGray;
            panelCentral.Controls.Add(errorLoginLabel);
            panelCentral.Controls.Add(iniciarBtn);
            panelCentral.Controls.Add(cancelarBtn);
            panelCentral.Controls.Add(contraseñaLabel);
            panelCentral.Controls.Add(correoLabel);
            panelCentral.Controls.Add(claveSesionTextBox);
            panelCentral.Controls.Add(correoSesionTextBox);
            panelCentral.Location = new Point(0, 100);
            panelCentral.Margin = new Padding(3, 4, 3, 4);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(667, 381);
            panelCentral.TabIndex = 1;
            // 
            // errorLoginLabel
            // 
            errorLoginLabel.AutoSize = true;
            errorLoginLabel.ForeColor = Color.Crimson;
            errorLoginLabel.Location = new Point(213, 277);
            errorLoginLabel.Name = "errorLoginLabel";
            errorLoginLabel.Size = new Size(0, 20);
            errorLoginLabel.TabIndex = 6;
            // 
            // iniciarBtn
            // 
            iniciarBtn.BackColor = Color.SeaGreen;
            iniciarBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iniciarBtn.ForeColor = SystemColors.ControlLightLight;
            iniciarBtn.Location = new Point(158, 211);
            iniciarBtn.Margin = new Padding(3, 4, 3, 4);
            iniciarBtn.Name = "iniciarBtn";
            iniciarBtn.Size = new Size(130, 50);
            iniciarBtn.TabIndex = 5;
            iniciarBtn.Text = "Iniciar";
            iniciarBtn.UseVisualStyleBackColor = false;
            iniciarBtn.Click += iniciarBtn_Click;
            // 
            // cancelarBtn
            // 
            cancelarBtn.BackColor = Color.FromArgb(191, 97, 106);
            cancelarBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelarBtn.ForeColor = SystemColors.ButtonHighlight;
            cancelarBtn.Location = new Point(351, 209);
            cancelarBtn.Margin = new Padding(3, 4, 3, 4);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(142, 52);
            cancelarBtn.TabIndex = 4;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = false;
            cancelarBtn.Click += cancelarBtn_Click;
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contraseñaLabel.Location = new Point(133, 143);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new Size(140, 28);
            contraseñaLabel.TabIndex = 3;
            contraseñaLabel.Text = "Contraseña";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            correoLabel.Location = new Point(182, 56);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new Size(87, 28);
            correoLabel.TabIndex = 2;
            correoLabel.Text = "Correo";
            // 
            // claveSesionTextBox
            // 
            claveSesionTextBox.BackColor = Color.White;
            claveSesionTextBox.Location = new Point(313, 131);
            claveSesionTextBox.Margin = new Padding(3, 4, 3, 4);
            claveSesionTextBox.Multiline = true;
            claveSesionTextBox.Name = "claveSesionTextBox";
            claveSesionTextBox.PasswordChar = '*';
            claveSesionTextBox.Size = new Size(237, 40);
            claveSesionTextBox.TabIndex = 1;
            // 
            // correoSesionTextBox
            // 
            correoSesionTextBox.BackColor = Color.White;
            correoSesionTextBox.Location = new Point(313, 56);
            correoSesionTextBox.Margin = new Padding(3, 4, 3, 4);
            correoSesionTextBox.Multiline = true;
            correoSesionTextBox.Name = "correoSesionTextBox";
            correoSesionTextBox.Size = new Size(237, 40);
            correoSesionTextBox.TabIndex = 0;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(37, 53, 68);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 414);
            panelInferior.Margin = new Padding(0);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(667, 67);
            panelInferior.TabIndex = 2;
            // 
            // validacionErrorProvider
            // 
            validacionErrorProvider.ContainerControl = this;
            // 
            // LoginFormulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 481);
            Controls.Add(panelInferior);
            Controls.Add(panelCentral);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginFormulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconoBox).EndInit();
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)validacionErrorProvider).EndInit();
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
        private Label correoLabel;
        private TextBox claveSesionTextBox;
        private TextBox correoSesionTextBox;
        private Label errorLoginLabel;
        private ErrorProvider validacionErrorProvider;
    }
}