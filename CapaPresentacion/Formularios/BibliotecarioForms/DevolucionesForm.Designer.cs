namespace CapaPresentacion.Formularios.BibliotecarioForms
{
    partial class DevolucionesForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            fechaDevolucionDateTimePicker = new DateTimePicker();
            devolverButton = new Button();
            label3 = new Label();
            nombreLabel = new Label();
            observacionesTextBox = new TextBox();
            label2 = new Label();
            buscarTextBox = new TextBox();
            prestamosDataGridView = new DataGridView();
            buscarButton = new Button();
            validacionErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)prestamosDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validacionErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.ForeColor = Color.FromArgb(162, 129, 112);
            panel1.Location = new Point(262, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 12);
            panel1.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(317, 49);
            label1.Name = "label1";
            label1.Size = new Size(375, 42);
            label1.TabIndex = 77;
            label1.Text = "Devolución de libros";
            // 
            // fechaDevolucionDateTimePicker
            // 
            fechaDevolucionDateTimePicker.Location = new Point(595, 312);
            fechaDevolucionDateTimePicker.Name = "fechaDevolucionDateTimePicker";
            fechaDevolucionDateTimePicker.Size = new Size(322, 27);
            fechaDevolucionDateTimePicker.TabIndex = 73;
            // 
            // devolverButton
            // 
            devolverButton.BackColor = Color.DarkRed;
            devolverButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            devolverButton.ForeColor = Color.White;
            devolverButton.Location = new Point(598, 542);
            devolverButton.Name = "devolverButton";
            devolverButton.Size = new Size(333, 43);
            devolverButton.TabIndex = 72;
            devolverButton.Text = "Devolver";
            devolverButton.UseVisualStyleBackColor = false;
            devolverButton.Click += devolverButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(74, 74, 74);
            label3.Location = new Point(595, 260);
            label3.Name = "label3";
            label3.Size = new Size(195, 22);
            label3.TabIndex = 71;
            label3.Text = "Fecha de devolución";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = Color.Transparent;
            nombreLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            nombreLabel.ForeColor = Color.FromArgb(74, 74, 74);
            nombreLabel.Location = new Point(35, 188);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(105, 22);
            nombreLabel.TabIndex = 68;
            nombreLabel.Text = "Estudiante";
            // 
            // observacionesTextBox
            // 
            observacionesTextBox.BackColor = Color.White;
            observacionesTextBox.Location = new Point(598, 428);
            observacionesTextBox.Margin = new Padding(3, 4, 3, 4);
            observacionesTextBox.Multiline = true;
            observacionesTextBox.Name = "observacionesTextBox";
            observacionesTextBox.Size = new Size(333, 73);
            observacionesTextBox.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(74, 74, 74);
            label2.Location = new Point(598, 386);
            label2.Name = "label2";
            label2.Size = new Size(143, 22);
            label2.TabIndex = 81;
            label2.Text = "Observaciones";
            // 
            // buscarTextBox
            // 
            buscarTextBox.Location = new Point(179, 183);
            buscarTextBox.Name = "buscarTextBox";
            buscarTextBox.Size = new Size(231, 27);
            buscarTextBox.TabIndex = 82;
            // 
            // prestamosDataGridView
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            prestamosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            prestamosDataGridView.BackgroundColor = SystemColors.ControlLight;
            prestamosDataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            prestamosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            prestamosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            prestamosDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            prestamosDataGridView.Location = new Point(35, 260);
            prestamosDataGridView.Name = "prestamosDataGridView";
            prestamosDataGridView.RowHeadersWidth = 51;
            prestamosDataGridView.Size = new Size(527, 331);
            prestamosDataGridView.TabIndex = 83;
            // 
            // buscarButton
            // 
            buscarButton.BackColor = Color.FromArgb(58, 157, 35);
            buscarButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscarButton.ForeColor = Color.White;
            buscarButton.Location = new Point(428, 175);
            buscarButton.Name = "buscarButton";
            buscarButton.Size = new Size(114, 43);
            buscarButton.TabIndex = 84;
            buscarButton.Text = "Buscar";
            buscarButton.UseVisualStyleBackColor = false;
            buscarButton.Click += buscarButton_Click;
            // 
            // validacionErrorProvider
            // 
            validacionErrorProvider.ContainerControl = this;
            // 
            // DevolucionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 719);
            Controls.Add(buscarButton);
            Controls.Add(prestamosDataGridView);
            Controls.Add(buscarTextBox);
            Controls.Add(label2);
            Controls.Add(observacionesTextBox);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(fechaDevolucionDateTimePicker);
            Controls.Add(devolverButton);
            Controls.Add(label3);
            Controls.Add(nombreLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DevolucionesForm";
            Text = "DevolucionesForm";
            ((System.ComponentModel.ISupportInitialize)prestamosDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)validacionErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DateTimePicker fechaDevolucionDateTimePicker;
        private Button devolverButton;
        private Label label3;
        private Label nombreLabel;
        private TextBox observacionesTextBox;
        private Label label2;
        private TextBox buscarTextBox;
        private DataGridView prestamosDataGridView;
        private Button buscarButton;
        private ErrorProvider validacionErrorProvider;
    }
}