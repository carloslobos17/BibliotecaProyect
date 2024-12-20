﻿namespace CapaPresentacion.Formularios.BibliotecarioForms.Modal
{
    partial class CategoriaForm
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
            nombreCategoriaTextBox = new TextBox();
            CategoriadataGridView = new DataGridView();
            panel1 = new Panel();
            tituloModalLabel = new Label();
            Nombrelabel = new Label();
            eliminarCategoriaButton = new FontAwesome.Sharp.IconButton();
            agregarCategoriaButton = new FontAwesome.Sharp.IconButton();
            editarCategoriaButton = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            validacionErrorProvider = new ErrorProvider(components);
            panel3 = new Panel();
            panel4 = new Panel();
            cerrarIconButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)CategoriadataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validacionErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // nombreCategoriaTextBox
            // 
            nombreCategoriaTextBox.Location = new Point(211, 124);
            nombreCategoriaTextBox.Multiline = true;
            nombreCategoriaTextBox.Name = "nombreCategoriaTextBox";
            nombreCategoriaTextBox.Size = new Size(222, 37);
            nombreCategoriaTextBox.TabIndex = 2;
            // 
            // CategoriadataGridView
            // 
            CategoriadataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoriadataGridView.Location = new Point(68, 199);
            CategoriadataGridView.Name = "CategoriadataGridView";
            CategoriadataGridView.RowHeadersWidth = 51;
            CategoriadataGridView.Size = new Size(335, 324);
            CategoriadataGridView.TabIndex = 3;
            CategoriadataGridView.CellClick += CategoriadataGridView_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(cerrarIconButton);
            panel1.Controls.Add(tituloModalLabel);
            panel1.Location = new Point(-5, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 98);
            panel1.TabIndex = 4;
            // 
            // tituloModalLabel
            // 
            tituloModalLabel.AutoSize = true;
            tituloModalLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloModalLabel.ForeColor = Color.White;
            tituloModalLabel.Location = new Point(225, 33);
            tituloModalLabel.Name = "tituloModalLabel";
            tituloModalLabel.Size = new Size(158, 36);
            tituloModalLabel.TabIndex = 1;
            tituloModalLabel.Text = "Categorias";
            // 
            // Nombrelabel
            // 
            Nombrelabel.AutoSize = true;
            Nombrelabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            Nombrelabel.Location = new Point(87, 139);
            Nombrelabel.Name = "Nombrelabel";
            Nombrelabel.Size = new Size(79, 22);
            Nombrelabel.TabIndex = 5;
            Nombrelabel.Text = "Nombre";
            // 
            // eliminarCategoriaButton
            // 
            eliminarCategoriaButton.BackColor = Color.DarkRed;
            eliminarCategoriaButton.FlatStyle = FlatStyle.Flat;
            eliminarCategoriaButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminarCategoriaButton.ForeColor = SystemColors.MenuBar;
            eliminarCategoriaButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            eliminarCategoriaButton.IconColor = SystemColors.MenuBar;
            eliminarCategoriaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarCategoriaButton.IconSize = 40;
            eliminarCategoriaButton.ImageAlign = ContentAlignment.MiddleLeft;
            eliminarCategoriaButton.Location = new Point(424, 351);
            eliminarCategoriaButton.Margin = new Padding(0);
            eliminarCategoriaButton.Name = "eliminarCategoriaButton";
            eliminarCategoriaButton.Size = new Size(123, 49);
            eliminarCategoriaButton.TabIndex = 24;
            eliminarCategoriaButton.Text = "Eliminar";
            eliminarCategoriaButton.TextAlign = ContentAlignment.MiddleRight;
            eliminarCategoriaButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            eliminarCategoriaButton.UseVisualStyleBackColor = false;
            eliminarCategoriaButton.Click += eliminarCategoriaButton_Click;
            // 
            // agregarCategoriaButton
            // 
            agregarCategoriaButton.BackColor = Color.FromArgb(58, 157, 35);
            agregarCategoriaButton.FlatStyle = FlatStyle.Flat;
            agregarCategoriaButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarCategoriaButton.ForeColor = SystemColors.MenuBar;
            agregarCategoriaButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            agregarCategoriaButton.IconColor = SystemColors.MenuBar;
            agregarCategoriaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            agregarCategoriaButton.IconSize = 40;
            agregarCategoriaButton.ImageAlign = ContentAlignment.MiddleLeft;
            agregarCategoriaButton.Location = new Point(424, 218);
            agregarCategoriaButton.Margin = new Padding(0);
            agregarCategoriaButton.Name = "agregarCategoriaButton";
            agregarCategoriaButton.Size = new Size(125, 48);
            agregarCategoriaButton.TabIndex = 22;
            agregarCategoriaButton.Text = "Agregar";
            agregarCategoriaButton.TextAlign = ContentAlignment.MiddleRight;
            agregarCategoriaButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            agregarCategoriaButton.UseVisualStyleBackColor = false;
            agregarCategoriaButton.Click += agregarCategoriaButton_Click;
            // 
            // editarCategoriaButton
            // 
            editarCategoriaButton.BackColor = Color.SteelBlue;
            editarCategoriaButton.FlatStyle = FlatStyle.Flat;
            editarCategoriaButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editarCategoriaButton.ForeColor = SystemColors.MenuBar;
            editarCategoriaButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editarCategoriaButton.IconColor = SystemColors.MenuBar;
            editarCategoriaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editarCategoriaButton.IconSize = 40;
            editarCategoriaButton.ImageAlign = ContentAlignment.MiddleLeft;
            editarCategoriaButton.Location = new Point(424, 285);
            editarCategoriaButton.Margin = new Padding(0);
            editarCategoriaButton.Name = "editarCategoriaButton";
            editarCategoriaButton.Size = new Size(125, 48);
            editarCategoriaButton.TabIndex = 23;
            editarCategoriaButton.Text = "Editar";
            editarCategoriaButton.TextAlign = ContentAlignment.MiddleRight;
            editarCategoriaButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            editarCategoriaButton.UseVisualStyleBackColor = false;
            editarCategoriaButton.Click += editarCategoriaButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 62, 80);
            panel2.Location = new Point(-5, 558);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 73);
            panel2.TabIndex = 25;
            // 
            // validacionErrorProvider
            // 
            validacionErrorProvider.ContainerControl = this;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 62, 80);
            panel3.Location = new Point(594, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(23, 472);
            panel3.TabIndex = 26;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(44, 62, 80);
            panel4.Location = new Point(-5, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(22, 472);
            panel4.TabIndex = 27;
            // 
            // cerrarIconButton
            // 
            cerrarIconButton.IconChar = FontAwesome.Sharp.IconChar.X;
            cerrarIconButton.IconColor = Color.FromArgb(44, 62, 80);
            cerrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cerrarIconButton.IconSize = 22;
            cerrarIconButton.Location = new Point(565, 15);
            cerrarIconButton.Name = "cerrarIconButton";
            cerrarIconButton.Size = new Size(32, 30);
            cerrarIconButton.TabIndex = 2;
            cerrarIconButton.UseVisualStyleBackColor = true;
            cerrarIconButton.Click += cerrarIconButton_Click;
            // 
            // CategoriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 628);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(eliminarCategoriaButton);
            Controls.Add(agregarCategoriaButton);
            Controls.Add(editarCategoriaButton);
            Controls.Add(Nombrelabel);
            Controls.Add(panel1);
            Controls.Add(CategoriadataGridView);
            Controls.Add(nombreCategoriaTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoriaForm";
            Text = "CategoriaForm";
            ((System.ComponentModel.ISupportInitialize)CategoriadataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)validacionErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nombreCategoriaTextBox;
        private DataGridView CategoriadataGridView;
        private Panel panel1;
        private Label Nombrelabel;
        private FontAwesome.Sharp.IconButton eliminarCategoriaButton;
        private FontAwesome.Sharp.IconButton agregarCategoriaButton;
        private FontAwesome.Sharp.IconButton editarCategoriaButton;
        private Label tituloModalLabel;
        private Panel panel2;
        private ErrorProvider validacionErrorProvider;
        private Panel panel4;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton cerrarIconButton;
    }
}