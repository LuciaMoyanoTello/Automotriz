namespace AutomotrizFront.Presentacion.Reportes.Reporte2
{
    partial class FrmReporte2
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
            pnReporte = new Panel();
            rvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            lblTitulo = new Label();
            btnBuscar = new Button();
            txtDniCliente = new TextBox();
            lblDniCliente = new Label();
            pnReporte.SuspendLayout();
            SuspendLayout();
            // 
            // pnReporte
            // 
            pnReporte.AutoScroll = true;
            pnReporte.AutoSize = true;
            pnReporte.Controls.Add(rvReporte);
            pnReporte.Location = new Point(12, 144);
            pnReporte.Name = "pnReporte";
            pnReporte.Size = new Size(874, 444);
            pnReporte.TabIndex = 7;
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
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLight;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(330, 37);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Compras por Cliente";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(796, 104);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 27);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDniCliente
            // 
            txtDniCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtDniCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtDniCliente.Location = new Point(114, 63);
            txtDniCliente.Margin = new Padding(4, 3, 4, 3);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(276, 23);
            txtDniCliente.TabIndex = 10;
            txtDniCliente.KeyPress += txtNumerico_KeyPress;
            // 
            // lblDniCliente
            // 
            lblDniCliente.AutoSize = true;
            lblDniCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDniCliente.ForeColor = SystemColors.ControlLight;
            lblDniCliente.Location = new Point(37, 65);
            lblDniCliente.Margin = new Padding(4, 0, 4, 0);
            lblDniCliente.Name = "lblDniCliente";
            lblDniCliente.Size = new Size(69, 15);
            lblDniCliente.TabIndex = 11;
            lblDniCliente.Text = "DNI Cliente";
            // 
            // FrmReporte2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(898, 600);
            Controls.Add(lblDniCliente);
            Controls.Add(txtDniCliente);
            Controls.Add(btnBuscar);
            Controls.Add(lblTitulo);
            Controls.Add(pnReporte);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReporte2";
            Text = "FrmReporte2";
            Load += FrmReporte1_Load;
            pnReporte.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rvReporte;
        private Label lblTitulo;
        private Button btnBuscar;
        private TextBox txtDniCliente;
        private Label lblDniCliente;
    }
}