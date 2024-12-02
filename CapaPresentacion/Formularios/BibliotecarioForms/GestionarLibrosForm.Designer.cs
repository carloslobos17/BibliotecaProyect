namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    partial class GestionarLibrosForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            eliminarLibroButton = new FontAwesome.Sharp.IconButton();
            agregarLibroButton = new FontAwesome.Sharp.IconButton();
            editarLibroButton = new FontAwesome.Sharp.IconButton();
            librosDataGridView = new DataGridView();
            categoriasButton = new FontAwesome.Sharp.IconButton();
            iniciarDateTimePicker = new DateTimePicker();
            finalizarDateTimePicker = new DateTimePicker();
            filtrarButton = new Button();
            cargarLibrosButton = new Button();
            groupBox1 = new GroupBox();
            fechaLimiteLabel = new Label();
            fechaInicioLabel = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)librosDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(332, 57);
            label2.Name = "label2";
            label2.Size = new Size(315, 42);
            label2.TabIndex = 24;
            label2.Text = "Gestión de libros";
            // 
            // eliminarLibroButton
            // 
            eliminarLibroButton.BackColor = Color.DarkRed;
            eliminarLibroButton.FlatStyle = FlatStyle.Flat;
            eliminarLibroButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminarLibroButton.ForeColor = SystemColors.MenuBar;
            eliminarLibroButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            eliminarLibroButton.IconColor = SystemColors.MenuBar;
            eliminarLibroButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarLibroButton.IconSize = 40;
            eliminarLibroButton.ImageAlign = ContentAlignment.MiddleLeft;
            eliminarLibroButton.Location = new Point(825, 446);
            eliminarLibroButton.Margin = new Padding(0);
            eliminarLibroButton.Name = "eliminarLibroButton";
            eliminarLibroButton.Size = new Size(144, 49);
            eliminarLibroButton.TabIndex = 21;
            eliminarLibroButton.Text = "Eliminar";
            eliminarLibroButton.TextAlign = ContentAlignment.MiddleRight;
            eliminarLibroButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            eliminarLibroButton.UseVisualStyleBackColor = false;
            eliminarLibroButton.Click += eliminarLibroButton_Click;
            // 
            // agregarLibroButton
            // 
            agregarLibroButton.BackColor = Color.FromArgb(58, 157, 35);
            agregarLibroButton.FlatStyle = FlatStyle.Flat;
            agregarLibroButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarLibroButton.ForeColor = SystemColors.MenuBar;
            agregarLibroButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            agregarLibroButton.IconColor = SystemColors.MenuBar;
            agregarLibroButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            agregarLibroButton.IconSize = 40;
            agregarLibroButton.ImageAlign = ContentAlignment.MiddleLeft;
            agregarLibroButton.Location = new Point(825, 310);
            agregarLibroButton.Margin = new Padding(0);
            agregarLibroButton.Name = "agregarLibroButton";
            agregarLibroButton.Size = new Size(144, 48);
            agregarLibroButton.TabIndex = 19;
            agregarLibroButton.Text = "Agregar";
            agregarLibroButton.TextAlign = ContentAlignment.MiddleRight;
            agregarLibroButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            agregarLibroButton.UseVisualStyleBackColor = false;
            agregarLibroButton.Click += agregarLibroButton_Click;
            // 
            // editarLibroButton
            // 
            editarLibroButton.BackColor = Color.SteelBlue;
            editarLibroButton.FlatStyle = FlatStyle.Flat;
            editarLibroButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editarLibroButton.ForeColor = SystemColors.MenuBar;
            editarLibroButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editarLibroButton.IconColor = SystemColors.MenuBar;
            editarLibroButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editarLibroButton.IconSize = 40;
            editarLibroButton.ImageAlign = ContentAlignment.MiddleLeft;
            editarLibroButton.Location = new Point(825, 375);
            editarLibroButton.Margin = new Padding(0);
            editarLibroButton.Name = "editarLibroButton";
            editarLibroButton.Size = new Size(144, 48);
            editarLibroButton.TabIndex = 20;
            editarLibroButton.Text = "Editar";
            editarLibroButton.TextAlign = ContentAlignment.MiddleRight;
            editarLibroButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            editarLibroButton.UseVisualStyleBackColor = false;
            editarLibroButton.Click += editarLibroButton_Click;
            // 
            // librosDataGridView
            // 
            librosDataGridView.AllowUserToAddRows = false;
            librosDataGridView.AllowUserToDeleteRows = false;
            librosDataGridView.AllowUserToResizeColumns = false;
            librosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            librosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            librosDataGridView.BackgroundColor = SystemColors.ControlLight;
            librosDataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            librosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            librosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            librosDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            librosDataGridView.Location = new Point(45, 250);
            librosDataGridView.Name = "librosDataGridView";
            librosDataGridView.RowHeadersWidth = 51;
            librosDataGridView.Size = new Size(759, 514);
            librosDataGridView.TabIndex = 18;
            librosDataGridView.CellContentClick += librosDataGridView_CellContentClick;
            // 
            // categoriasButton
            // 
            categoriasButton.BackColor = Color.FromArgb(128, 64, 0);
            categoriasButton.FlatStyle = FlatStyle.Flat;
            categoriasButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoriasButton.ForeColor = SystemColors.MenuBar;
            categoriasButton.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            categoriasButton.IconColor = SystemColors.MenuBar;
            categoriasButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            categoriasButton.IconSize = 40;
            categoriasButton.ImageAlign = ContentAlignment.MiddleLeft;
            categoriasButton.Location = new Point(825, 514);
            categoriasButton.Margin = new Padding(0);
            categoriasButton.Name = "categoriasButton";
            categoriasButton.Size = new Size(144, 48);
            categoriasButton.TabIndex = 27;
            categoriasButton.Text = "Categorias";
            categoriasButton.TextAlign = ContentAlignment.MiddleRight;
            categoriasButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            categoriasButton.UseVisualStyleBackColor = false;
            categoriasButton.Click += categoriasButton_Click;
            // 
            // iniciarDateTimePicker
            // 
            iniciarDateTimePicker.Location = new Point(83, 42);
            iniciarDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            iniciarDateTimePicker.Name = "iniciarDateTimePicker";
            iniciarDateTimePicker.Size = new Size(278, 29);
            iniciarDateTimePicker.TabIndex = 28;
            // 
            // finalizarDateTimePicker
            // 
            finalizarDateTimePicker.Location = new Point(453, 41);
            finalizarDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            finalizarDateTimePicker.Name = "finalizarDateTimePicker";
            finalizarDateTimePicker.Size = new Size(278, 29);
            finalizarDateTimePicker.TabIndex = 29;
            // 
            // filtrarButton
            // 
            filtrarButton.Location = new Point(830, 39);
            filtrarButton.Margin = new Padding(3, 4, 3, 4);
            filtrarButton.Name = "filtrarButton";
            filtrarButton.Size = new Size(75, 36);
            filtrarButton.TabIndex = 30;
            filtrarButton.Text = "Filtrar";
            filtrarButton.UseVisualStyleBackColor = true;
            filtrarButton.Click += filtrarButton_Click;
            // 
            // cargarLibrosButton
            // 
            cargarLibrosButton.Location = new Point(737, 39);
            cargarLibrosButton.Margin = new Padding(3, 4, 3, 4);
            cargarLibrosButton.Name = "cargarLibrosButton";
            cargarLibrosButton.Size = new Size(87, 36);
            cargarLibrosButton.TabIndex = 31;
            cargarLibrosButton.Text = "Cargar";
            cargarLibrosButton.UseVisualStyleBackColor = true;
            cargarLibrosButton.Click += cargarLibrosButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fechaLimiteLabel);
            groupBox1.Controls.Add(fechaInicioLabel);
            groupBox1.Controls.Add(iniciarDateTimePicker);
            groupBox1.Controls.Add(cargarLibrosButton);
            groupBox1.Controls.Add(finalizarDateTimePicker);
            groupBox1.Controls.Add(filtrarButton);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(45, 143);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(929, 100);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Libros Por Fecha de Lanzamiento";
            // 
            // fechaLimiteLabel
            // 
            fechaLimiteLabel.AutoSize = true;
            fechaLimiteLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fechaLimiteLabel.Location = new Point(376, 48);
            fechaLimiteLabel.Name = "fechaLimiteLabel";
            fechaLimiteLabel.Size = new Size(55, 23);
            fechaLimiteLabel.TabIndex = 33;
            fechaLimiteLabel.Text = "Hasta";
            // 
            // fechaInicioLabel
            // 
            fechaInicioLabel.AutoSize = true;
            fechaInicioLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fechaInicioLabel.Location = new Point(6, 48);
            fechaInicioLabel.Name = "fechaInicioLabel";
            fechaInicioLabel.Size = new Size(59, 23);
            fechaInicioLabel.TabIndex = 32;
            fechaInicioLabel.Text = "Desde";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.ForeColor = Color.FromArgb(162, 129, 112);
            panel1.Location = new Point(237, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 12);
            panel1.TabIndex = 41;
            // 
            // GestionarLibrosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 835);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(categoriasButton);
            Controls.Add(label2);
            Controls.Add(eliminarLibroButton);
            Controls.Add(agregarLibroButton);
            Controls.Add(editarLibroButton);
            Controls.Add(librosDataGridView);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionarLibrosForm";
            Text = "GestionarLibrosForm";
            ((System.ComponentModel.ISupportInitialize)librosDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private FontAwesome.Sharp.IconButton eliminarLibroButton;
        private FontAwesome.Sharp.IconButton agregarLibroButton;
        private FontAwesome.Sharp.IconButton editarLibroButton;
        public DataGridView librosDataGridView;
        private FontAwesome.Sharp.IconButton categoriasButton;
        private DateTimePicker iniciarDateTimePicker;
        private DateTimePicker finalizarDateTimePicker;
        private Button filtrarButton;
        private Button cargarLibrosButton;
        private GroupBox groupBox1;
        private Label fechaLimiteLabel;
        private Label fechaInicioLabel;
        private Panel panel1;
    }
}