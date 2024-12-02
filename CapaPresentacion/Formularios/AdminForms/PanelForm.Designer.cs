namespace CapaPresentacion.Formularios.AdminForms
{
    partial class PanelForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            estadisticasTableLayoutPanel = new TableLayoutPanel();
            bibliotecariosPanel = new Panel();
            bibliotecarioIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            cantidadBibliotecarioLabel = new Label();
            tituloBibliotecariosLabel = new Label();
            librosPanel = new Panel();
            librosIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            cantidadLibrosLabel = new Label();
            tituloLibrosLabel = new Label();
            prestamosPanel = new Panel();
            prestamosIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            cantidadPrestamosLabel = new Label();
            tituloPrestamosLabel = new Label();
            devolucionesPanel = new Panel();
            devolucionesIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            cantidadDevolucionesLabel = new Label();
            tituloDevolucionesLabel = new Label();
            cantidadCategoriaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            librosPopularesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            estadisticasTableLayoutPanel.SuspendLayout();
            bibliotecariosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bibliotecarioIconPictureBox).BeginInit();
            librosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)librosIconPictureBox).BeginInit();
            prestamosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prestamosIconPictureBox).BeginInit();
            devolucionesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)devolucionesIconPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantidadCategoriaChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)librosPopularesChart).BeginInit();
            SuspendLayout();
            // 
            // estadisticasTableLayoutPanel
            // 
            estadisticasTableLayoutPanel.Anchor = AnchorStyles.Top;
            estadisticasTableLayoutPanel.BackColor = Color.LightGray;
            estadisticasTableLayoutPanel.ColumnCount = 4;
            estadisticasTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            estadisticasTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            estadisticasTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            estadisticasTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            estadisticasTableLayoutPanel.Controls.Add(bibliotecariosPanel, 0, 0);
            estadisticasTableLayoutPanel.Controls.Add(librosPanel, 1, 0);
            estadisticasTableLayoutPanel.Controls.Add(prestamosPanel, 2, 0);
            estadisticasTableLayoutPanel.Controls.Add(devolucionesPanel, 3, 0);
            estadisticasTableLayoutPanel.Location = new Point(22, 19);
            estadisticasTableLayoutPanel.Margin = new Padding(10);
            estadisticasTableLayoutPanel.Name = "estadisticasTableLayoutPanel";
            estadisticasTableLayoutPanel.RowCount = 1;
            estadisticasTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            estadisticasTableLayoutPanel.Size = new Size(971, 157);
            estadisticasTableLayoutPanel.TabIndex = 0;
            // 
            // bibliotecariosPanel
            // 
            bibliotecariosPanel.Anchor = AnchorStyles.None;
            bibliotecariosPanel.BackColor = Color.White;
            bibliotecariosPanel.Controls.Add(bibliotecarioIconPictureBox);
            bibliotecariosPanel.Controls.Add(cantidadBibliotecarioLabel);
            bibliotecariosPanel.Controls.Add(tituloBibliotecariosLabel);
            bibliotecariosPanel.Location = new Point(14, 17);
            bibliotecariosPanel.Name = "bibliotecariosPanel";
            bibliotecariosPanel.Size = new Size(213, 123);
            bibliotecariosPanel.TabIndex = 5;
            bibliotecariosPanel.MouseEnter += bibliotecariosPanel_MouseEnter;
            bibliotecariosPanel.MouseLeave += bibliotecariosPanel_MouseLeave;
            // 
            // bibliotecarioIconPictureBox
            // 
            bibliotecarioIconPictureBox.BackColor = Color.White;
            bibliotecarioIconPictureBox.ForeColor = Color.Black;
            bibliotecarioIconPictureBox.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            bibliotecarioIconPictureBox.IconColor = Color.Black;
            bibliotecarioIconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bibliotecarioIconPictureBox.IconSize = 40;
            bibliotecarioIconPictureBox.Location = new Point(170, 3);
            bibliotecarioIconPictureBox.Name = "bibliotecarioIconPictureBox";
            bibliotecarioIconPictureBox.Size = new Size(40, 40);
            bibliotecarioIconPictureBox.TabIndex = 6;
            bibliotecarioIconPictureBox.TabStop = false;
            // 
            // cantidadBibliotecarioLabel
            // 
            cantidadBibliotecarioLabel.AutoSize = true;
            cantidadBibliotecarioLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cantidadBibliotecarioLabel.Location = new Point(78, 46);
            cantidadBibliotecarioLabel.Name = "cantidadBibliotecarioLabel";
            cantidadBibliotecarioLabel.Size = new Size(56, 46);
            cantidadBibliotecarioLabel.TabIndex = 5;
            cantidadBibliotecarioLabel.Text = "50";
            // 
            // tituloBibliotecariosLabel
            // 
            tituloBibliotecariosLabel.AutoSize = true;
            tituloBibliotecariosLabel.BackColor = Color.Transparent;
            tituloBibliotecariosLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloBibliotecariosLabel.ForeColor = SystemColors.GrayText;
            tituloBibliotecariosLabel.Location = new Point(7, 9);
            tituloBibliotecariosLabel.Name = "tituloBibliotecariosLabel";
            tituloBibliotecariosLabel.Size = new Size(117, 22);
            tituloBibliotecariosLabel.TabIndex = 3;
            tituloBibliotecariosLabel.Text = "Bibliotecarios";
            // 
            // librosPanel
            // 
            librosPanel.Anchor = AnchorStyles.None;
            librosPanel.BackColor = Color.White;
            librosPanel.Controls.Add(librosIconPictureBox);
            librosPanel.Controls.Add(cantidadLibrosLabel);
            librosPanel.Controls.Add(tituloLibrosLabel);
            librosPanel.Location = new Point(259, 17);
            librosPanel.Name = "librosPanel";
            librosPanel.Size = new Size(208, 122);
            librosPanel.TabIndex = 4;
            librosPanel.MouseEnter += librosPanel_MouseEnter;
            librosPanel.MouseLeave += librosPanel_MouseLeave;
            // 
            // librosIconPictureBox
            // 
            librosIconPictureBox.BackColor = Color.White;
            librosIconPictureBox.ForeColor = Color.Black;
            librosIconPictureBox.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            librosIconPictureBox.IconColor = Color.Black;
            librosIconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            librosIconPictureBox.IconSize = 40;
            librosIconPictureBox.Location = new Point(165, 2);
            librosIconPictureBox.Name = "librosIconPictureBox";
            librosIconPictureBox.Size = new Size(40, 40);
            librosIconPictureBox.TabIndex = 7;
            librosIconPictureBox.TabStop = false;
            // 
            // cantidadLibrosLabel
            // 
            cantidadLibrosLabel.AutoSize = true;
            cantidadLibrosLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cantidadLibrosLabel.Location = new Point(60, 46);
            cantidadLibrosLabel.Name = "cantidadLibrosLabel";
            cantidadLibrosLabel.Size = new Size(74, 46);
            cantidadLibrosLabel.TabIndex = 6;
            cantidadLibrosLabel.Text = "100";
            // 
            // tituloLibrosLabel
            // 
            tituloLibrosLabel.AutoSize = true;
            tituloLibrosLabel.BackColor = Color.Transparent;
            tituloLibrosLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloLibrosLabel.ForeColor = SystemColors.ControlDarkDark;
            tituloLibrosLabel.Location = new Point(14, 9);
            tituloLibrosLabel.Name = "tituloLibrosLabel";
            tituloLibrosLabel.Size = new Size(59, 22);
            tituloLibrosLabel.TabIndex = 3;
            tituloLibrosLabel.Text = "Libros";
            // 
            // prestamosPanel
            // 
            prestamosPanel.Anchor = AnchorStyles.None;
            prestamosPanel.BackColor = Color.White;
            prestamosPanel.Controls.Add(prestamosIconPictureBox);
            prestamosPanel.Controls.Add(cantidadPrestamosLabel);
            prestamosPanel.Controls.Add(tituloPrestamosLabel);
            prestamosPanel.Location = new Point(502, 17);
            prestamosPanel.Name = "prestamosPanel";
            prestamosPanel.Size = new Size(205, 123);
            prestamosPanel.TabIndex = 3;
            prestamosPanel.MouseEnter += prestamosPanel_MouseEnter;
            prestamosPanel.MouseLeave += prestamosPanel_MouseLeave;
            // 
            // prestamosIconPictureBox
            // 
            prestamosIconPictureBox.BackColor = Color.White;
            prestamosIconPictureBox.ForeColor = Color.Black;
            prestamosIconPictureBox.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            prestamosIconPictureBox.IconColor = Color.Black;
            prestamosIconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            prestamosIconPictureBox.IconSize = 40;
            prestamosIconPictureBox.Location = new Point(165, 1);
            prestamosIconPictureBox.Name = "prestamosIconPictureBox";
            prestamosIconPictureBox.Size = new Size(40, 40);
            prestamosIconPictureBox.TabIndex = 8;
            prestamosIconPictureBox.TabStop = false;
            // 
            // cantidadPrestamosLabel
            // 
            cantidadPrestamosLabel.AutoSize = true;
            cantidadPrestamosLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cantidadPrestamosLabel.Location = new Point(70, 46);
            cantidadPrestamosLabel.Name = "cantidadPrestamosLabel";
            cantidadPrestamosLabel.Size = new Size(56, 46);
            cantidadPrestamosLabel.TabIndex = 7;
            cantidadPrestamosLabel.Text = "24";
            // 
            // tituloPrestamosLabel
            // 
            tituloPrestamosLabel.AutoSize = true;
            tituloPrestamosLabel.BackColor = Color.Transparent;
            tituloPrestamosLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloPrestamosLabel.ForeColor = SystemColors.ControlDarkDark;
            tituloPrestamosLabel.Location = new Point(12, 9);
            tituloPrestamosLabel.Name = "tituloPrestamosLabel";
            tituloPrestamosLabel.Size = new Size(95, 22);
            tituloPrestamosLabel.TabIndex = 3;
            tituloPrestamosLabel.Text = "Prestamos";
            // 
            // devolucionesPanel
            // 
            devolucionesPanel.Anchor = AnchorStyles.None;
            devolucionesPanel.BackColor = Color.White;
            devolucionesPanel.Controls.Add(devolucionesIconPictureBox);
            devolucionesPanel.Controls.Add(cantidadDevolucionesLabel);
            devolucionesPanel.Controls.Add(tituloDevolucionesLabel);
            devolucionesPanel.Location = new Point(743, 16);
            devolucionesPanel.Name = "devolucionesPanel";
            devolucionesPanel.Size = new Size(211, 124);
            devolucionesPanel.TabIndex = 2;
            devolucionesPanel.MouseEnter += devolucionesPanel_MouseEnter;
            devolucionesPanel.MouseLeave += devolucionesPanel_MouseLeave;
            // 
            // devolucionesIconPictureBox
            // 
            devolucionesIconPictureBox.BackColor = Color.White;
            devolucionesIconPictureBox.ForeColor = Color.Black;
            devolucionesIconPictureBox.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            devolucionesIconPictureBox.IconColor = Color.Black;
            devolucionesIconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            devolucionesIconPictureBox.IconSize = 40;
            devolucionesIconPictureBox.Location = new Point(171, 3);
            devolucionesIconPictureBox.Name = "devolucionesIconPictureBox";
            devolucionesIconPictureBox.Size = new Size(40, 40);
            devolucionesIconPictureBox.TabIndex = 9;
            devolucionesIconPictureBox.TabStop = false;
            // 
            // cantidadDevolucionesLabel
            // 
            cantidadDevolucionesLabel.AutoSize = true;
            cantidadDevolucionesLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cantidadDevolucionesLabel.Location = new Point(69, 46);
            cantidadDevolucionesLabel.Name = "cantidadDevolucionesLabel";
            cantidadDevolucionesLabel.Size = new Size(56, 46);
            cantidadDevolucionesLabel.TabIndex = 8;
            cantidadDevolucionesLabel.Text = "24";
            // 
            // tituloDevolucionesLabel
            // 
            tituloDevolucionesLabel.AutoSize = true;
            tituloDevolucionesLabel.BackColor = Color.Transparent;
            tituloDevolucionesLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloDevolucionesLabel.ForeColor = SystemColors.ControlDarkDark;
            tituloDevolucionesLabel.Location = new Point(12, 9);
            tituloDevolucionesLabel.Name = "tituloDevolucionesLabel";
            tituloDevolucionesLabel.Size = new Size(118, 22);
            tituloDevolucionesLabel.TabIndex = 3;
            tituloDevolucionesLabel.Text = "Devoluciones";
            // 
            // cantidadCategoriaChart
            // 
            chartArea1.Name = "ChartArea1";
            cantidadCategoriaChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            cantidadCategoriaChart.Legends.Add(legend1);
            cantidadCategoriaChart.Location = new Point(43, 201);
            cantidadCategoriaChart.Name = "cantidadCategoriaChart";
            cantidadCategoriaChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            cantidadCategoriaChart.Series.Add(series1);
            cantidadCategoriaChart.Size = new Size(446, 416);
            cantidadCategoriaChart.TabIndex = 1;
            cantidadCategoriaChart.Text = "chart1";
            // 
            // librosPopularesChart
            // 
            chartArea2.Name = "ChartArea1";
            librosPopularesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            librosPopularesChart.Legends.Add(legend2);
            librosPopularesChart.Location = new Point(536, 201);
            librosPopularesChart.Name = "librosPopularesChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            librosPopularesChart.Series.Add(series2);
            librosPopularesChart.Size = new Size(430, 416);
            librosPopularesChart.TabIndex = 2;
            librosPopularesChart.Text = "chart1";
            // 
            // PanelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1012, 647);
            Controls.Add(librosPopularesChart);
            Controls.Add(cantidadCategoriaChart);
            Controls.Add(estadisticasTableLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PanelForm";
            Text = "PanelForm";
            estadisticasTableLayoutPanel.ResumeLayout(false);
            bibliotecariosPanel.ResumeLayout(false);
            bibliotecariosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bibliotecarioIconPictureBox).EndInit();
            librosPanel.ResumeLayout(false);
            librosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)librosIconPictureBox).EndInit();
            prestamosPanel.ResumeLayout(false);
            prestamosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prestamosIconPictureBox).EndInit();
            devolucionesPanel.ResumeLayout(false);
            devolucionesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)devolucionesIconPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cantidadCategoriaChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)librosPopularesChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel estadisticasTableLayoutPanel;
        private Panel devolucionesPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart cantidadCategoriaChart;
        private Label tituloDevolucionesLabel;
        private Panel bibliotecariosPanel;
        private Label tituloBibliotecariosLabel;
        private Panel librosPanel;
        private Label tituloLibrosLabel;
        private Panel prestamosPanel;
        private Label tituloPrestamosLabel;
        private Label cantidadBibliotecarioLabel;
        private Label cantidadLibrosLabel;
        private Label cantidadPrestamosLabel;
        private Label cantidadDevolucionesLabel;
        private FontAwesome.Sharp.IconPictureBox bibliotecarioIconPictureBox;
        private FontAwesome.Sharp.IconPictureBox librosIconPictureBox;
        private FontAwesome.Sharp.IconPictureBox prestamosIconPictureBox;
        private FontAwesome.Sharp.IconPictureBox devolucionesIconPictureBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart librosPopularesChart;
    }
}