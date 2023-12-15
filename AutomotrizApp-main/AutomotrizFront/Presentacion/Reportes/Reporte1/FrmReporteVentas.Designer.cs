namespace AutomotrizFront.Presentacion.Reportes.Reporte1
{
    partial class FrmReporteVentas
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
            lblTitulo = new Label();
            lblHasta = new Label();
            lblDesde = new Label();
            dtpFechaMin = new DateTimePicker();
            dtpFechaMax = new DateTimePicker();
            btnBuscar = new Button();
            pnReporte = new Panel();
            rvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            pnReporte.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLight;
            lblTitulo.Location = new Point(13, 9);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(485, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ventas por tipos de autopartes";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasta.ForeColor = SystemColors.ControlLight;
            lblHasta.Location = new Point(27, 109);
            lblHasta.Margin = new Padding(4, 0, 4, 0);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(79, 15);
            lblHasta.TabIndex = 1;
            lblHasta.Text = "Fecha Hasta:";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesde.ForeColor = SystemColors.ControlLight;
            lblDesde.Location = new Point(25, 68);
            lblDesde.Margin = new Padding(4, 0, 4, 0);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(81, 15);
            lblDesde.TabIndex = 2;
            lblDesde.Text = "Fecha desde:";
            // 
            // dtpFechaMin
            // 
            dtpFechaMin.Location = new Point(114, 63);
            dtpFechaMin.Margin = new Padding(4, 3, 4, 3);
            dtpFechaMin.Name = "dtpFechaMin";
            dtpFechaMin.Size = new Size(276, 23);
            dtpFechaMin.TabIndex = 3;
            // 
            // dtpFechaMax
            // 
            dtpFechaMax.Location = new Point(114, 104);
            dtpFechaMax.Margin = new Padding(4, 3, 4, 3);
            dtpFechaMax.Name = "dtpFechaMax";
            dtpFechaMax.Size = new Size(276, 23);
            dtpFechaMax.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(796, 104);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 27);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pnReporte
            // 
            pnReporte.AutoScroll = true;
            pnReporte.AutoSize = true;
            pnReporte.Controls.Add(rvReporte);
            pnReporte.Location = new Point(12, 144);
            pnReporte.Name = "pnReporte";
            pnReporte.Size = new Size(874, 444);
            pnReporte.TabIndex = 6;
            // 
            // rvReporte
            // 
            rvReporte.BackColor = Color.FromArgb(35, 35, 35);
            rvReporte.Dock = DockStyle.Fill;
            rvReporte.Location = new Point(0, 0);
            rvReporte.Name = "ReportViewer";
            rvReporte.ServerReport.BearerToken = null;
            rvReporte.ShowToolBar = false;
            rvReporte.Size = new Size(874, 444);
            rvReporte.TabIndex = 0;
            // 
            // FrmReporteVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(898, 600);
            Controls.Add(pnReporte);
            Controls.Add(btnBuscar);
            Controls.Add(dtpFechaMax);
            Controls.Add(dtpFechaMin);
            Controls.Add(lblDesde);
            Controls.Add(lblHasta);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmReporteVentas";
            Text = "FrmReporteVentas";
            Load += FrmReporteVentas_Load;
            pnReporte.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaMin;
        private System.Windows.Forms.DateTimePicker dtpFechaMax;
        private System.Windows.Forms.Button btnBuscar;
        private Panel pnReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rvReporte;
    }
}