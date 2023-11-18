namespace AutomotrizFront.Presentacion.ReporteVenta
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpFechaMin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaMax = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rvReporteVenta = new Microsoft.Reporting.WinForms.ReportViewer(); // Esto tira error
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ventas por tipos de autopartes";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblHasta.Location = new System.Drawing.Point(326, 52);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(71, 13);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Fecha Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDesde.Location = new System.Drawing.Point(13, 52);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(72, 13);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Fecha desde:";
            // 
            // dtpFechaMin
            // 
            this.dtpFechaMin.Location = new System.Drawing.Point(91, 46);
            this.dtpFechaMin.Name = "dtpFechaMin";
            this.dtpFechaMin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaMin.TabIndex = 3;
            // 
            // dtpFechaMax
            // 
            this.dtpFechaMax.Location = new System.Drawing.Point(403, 46);
            this.dtpFechaMax.Name = "dtpFechaMax";
            this.dtpFechaMax.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaMax.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(632, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rvReporteVenta
            // 
            this.rvReporteVenta.LocalReport.ReportEmbeddedResource = "AutomotrizFront.Presentacion.ReporteVenta.RptVenta.rdlc";
            this.rvReporteVenta.Location = new System.Drawing.Point(12, 88);
            this.rvReporteVenta.Name = "rvReporteVenta";
            this.rvReporteVenta.ServerReport.BearerToken = null;
            this.rvReporteVenta.Size = new System.Drawing.Size(746, 420);
            this.rvReporteVenta.TabIndex = 6;
            // 
            // FrmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(770, 520);
            this.Controls.Add(this.rvReporteVenta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFechaMax);
            this.Controls.Add(this.dtpFechaMin);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteVentas";
            this.Text = "FrmReporteVentas";
            this.Load += new System.EventHandler(this.FrmReporteVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaMin;
        private System.Windows.Forms.DateTimePicker dtpFechaMax;
        private System.Windows.Forms.Button btnBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer rvReporteVenta;
    }
}