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
            label1 = new Label();
            NombreCategoriatextBox = new TextBox();
            CategoriadataGridView = new DataGridView();
            panel1 = new Panel();
            Nombrelabel = new Label();
            eliminarCategoriaButton = new FontAwesome.Sharp.IconButton();
            agregarCategoriaButton = new FontAwesome.Sharp.IconButton();
            editarCategoriaButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)CategoriadataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(381, 26);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 0;
            label1.Text = "Categorias";
            // 
            // NombreCategoriatextBox
            // 
            NombreCategoriatextBox.Location = new Point(151, 90);
            NombreCategoriatextBox.Multiline = true;
            NombreCategoriatextBox.Name = "NombreCategoriatextBox";
            NombreCategoriatextBox.Size = new Size(222, 37);
            NombreCategoriatextBox.TabIndex = 2;
            // 
            // CategoriadataGridView
            // 
            CategoriadataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoriadataGridView.Location = new Point(43, 171);
            CategoriadataGridView.Name = "CategoriadataGridView";
            CategoriadataGridView.RowHeadersWidth = 51;
            CategoriadataGridView.Size = new Size(779, 324);
            CategoriadataGridView.TabIndex = 3;
            CategoriadataGridView.CellClick += CategoriadataGridView_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 73);
            panel1.TabIndex = 4;
            // 
            // Nombrelabel
            // 
            Nombrelabel.AutoSize = true;
            Nombrelabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            Nombrelabel.Location = new Point(43, 105);
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
            eliminarCategoriaButton.Location = new Point(699, 90);
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
            agregarCategoriaButton.Location = new Point(402, 93);
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
            editarCategoriaButton.Location = new Point(570, 93);
            editarCategoriaButton.Margin = new Padding(0);
            editarCategoriaButton.Name = "editarCategoriaButton";
            editarCategoriaButton.Size = new Size(105, 48);
            editarCategoriaButton.TabIndex = 23;
            editarCategoriaButton.Text = "Editar";
            editarCategoriaButton.TextAlign = ContentAlignment.MiddleRight;
            editarCategoriaButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            editarCategoriaButton.UseVisualStyleBackColor = false;
            editarCategoriaButton.Click += editarCategoriaButton_Click;
            // 
            // CategoriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 533);
            Controls.Add(eliminarCategoriaButton);
            Controls.Add(agregarCategoriaButton);
            Controls.Add(editarCategoriaButton);
            Controls.Add(Nombrelabel);
            Controls.Add(panel1);
            Controls.Add(CategoriadataGridView);
            Controls.Add(NombreCategoriatextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoriaForm";
            Text = "CategoriaForm";
            ((System.ComponentModel.ISupportInitialize)CategoriadataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NombreCategoriatextBox;
        private DataGridView CategoriadataGridView;
        private Panel panel1;
        private Label Nombrelabel;
        private FontAwesome.Sharp.IconButton eliminarCategoriaButton;
        private FontAwesome.Sharp.IconButton agregarCategoriaButton;
        private FontAwesome.Sharp.IconButton editarCategoriaButton;
    }
}