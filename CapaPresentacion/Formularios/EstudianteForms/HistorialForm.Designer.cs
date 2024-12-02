namespace CapaPresentacion.Formularios.EstudianteForms
{
    partial class HistorialForm
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
            panel1 = new Panel();
            tituloLabel = new Label();
            prestamoHistorialButton = new Button();
            devolucionesHistorialButton = new Button();
            historialDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)historialDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.ForeColor = Color.FromArgb(162, 129, 112);
            panel1.Location = new Point(260, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 10);
            panel1.TabIndex = 80;
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloLabel.ForeColor = Color.FromArgb(128, 64, 0);
            tituloLabel.Location = new Point(235, 60);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(639, 42);
            tituloLabel.TabIndex = 79;
            tituloLabel.Text = "Historial Prestamos y Devoluciones";
            // 
            // prestamoHistorialButton
            // 
            prestamoHistorialButton.BackColor = Color.DarkCyan;
            prestamoHistorialButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prestamoHistorialButton.ForeColor = Color.White;
            prestamoHistorialButton.Location = new Point(210, 168);
            prestamoHistorialButton.Name = "prestamoHistorialButton";
            prestamoHistorialButton.Size = new Size(333, 43);
            prestamoHistorialButton.TabIndex = 81;
            prestamoHistorialButton.Text = "Prestamos";
            prestamoHistorialButton.UseVisualStyleBackColor = false;
            prestamoHistorialButton.Click += prestamoHistorialButton_Click;
            // 
            // devolucionesHistorialButton
            // 
            devolucionesHistorialButton.BackColor = Color.DarkCyan;
            devolucionesHistorialButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            devolucionesHistorialButton.ForeColor = Color.White;
            devolucionesHistorialButton.Location = new Point(571, 168);
            devolucionesHistorialButton.Name = "devolucionesHistorialButton";
            devolucionesHistorialButton.Size = new Size(333, 43);
            devolucionesHistorialButton.TabIndex = 82;
            devolucionesHistorialButton.Text = "Devoluciones";
            devolucionesHistorialButton.UseVisualStyleBackColor = false;
            devolucionesHistorialButton.Click += devolucionesHistorialButton_Click;
            // 
            // historialDataGridView
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            historialDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            historialDataGridView.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            historialDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            historialDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            historialDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            historialDataGridView.Location = new Point(118, 248);
            historialDataGridView.Name = "historialDataGridView";
            historialDataGridView.RowHeadersWidth = 51;
            historialDataGridView.Size = new Size(869, 484);
            historialDataGridView.TabIndex = 83;
            // 
            // HistorialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 780);
            Controls.Add(historialDataGridView);
            Controls.Add(devolucionesHistorialButton);
            Controls.Add(prestamoHistorialButton);
            Controls.Add(panel1);
            Controls.Add(tituloLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HistorialForm";
            Text = "HistorialForm";
            ((System.ComponentModel.ISupportInitialize)historialDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label tituloLabel;
        private Button prestamoHistorialButton;
        private Button devolucionesHistorialButton;
        private DataGridView historialDataGridView;
    }
}