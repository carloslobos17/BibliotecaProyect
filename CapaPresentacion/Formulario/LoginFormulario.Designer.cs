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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            BtnIniciarSesion = new Button();
            BtnCancelarInicio = new Button();
            label3 = new Label();
            label2 = new Label();
            TextBoxContrasena = new TextBox();
            TextBoxUsuario = new TextBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 361);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 20);
            label1.Name = "label1";
            label1.Size = new Size(382, 38);
            label1.TabIndex = 1;
            label1.Text = "Biblioteca los 5 Amigos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(BtnIniciarSesion);
            panel2.Controls.Add(BtnCancelarInicio);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TextBoxContrasena);
            panel2.Controls.Add(TextBoxUsuario);
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 286);
            panel2.TabIndex = 1;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnIniciarSesion.Location = new Point(295, 160);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(83, 26);
            BtnIniciarSesion.TabIndex = 5;
            BtnIniciarSesion.Text = "Iniciar";
            BtnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // BtnCancelarInicio
            // 
            BtnCancelarInicio.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCancelarInicio.Location = new Point(176, 158);
            BtnCancelarInicio.Name = "BtnCancelarInicio";
            BtnCancelarInicio.Size = new Size(83, 28);
            BtnCancelarInicio.TabIndex = 4;
            BtnCancelarInicio.Text = "Cancelar";
            BtnCancelarInicio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(145, 98);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 48);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // TextBoxContrasena
            // 
            TextBoxContrasena.Location = new Point(295, 98);
            TextBoxContrasena.Multiline = true;
            TextBoxContrasena.Name = "TextBoxContrasena";
            TextBoxContrasena.Size = new Size(114, 31);
            TextBoxContrasena.TabIndex = 1;
            // 
            // TextBoxUsuario
            // 
            TextBoxUsuario.Location = new Point(295, 48);
            TextBoxUsuario.Multiline = true;
            TextBoxUsuario.Name = "TextBoxUsuario";
            TextBoxUsuario.Size = new Size(114, 31);
            TextBoxUsuario.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SandyBrown;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 311);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 50);
            panel3.TabIndex = 2;
            // 
            // LoginFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginFormulario";
            Text = "login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Button BtnIniciarSesion;
        private Button BtnCancelarInicio;
        private Label label3;
        private Label label2;
        private TextBox TextBoxContrasena;
        private TextBox TextBoxUsuario;
    }
}