namespace AutomotrizFront
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pnMenuPrincipal = new Panel();
            btnSalir = new Button();
            pnControles = new Panel();
            btnAcercaDe = new Button();
            pnMenuReportes = new Panel();
            btnReporte2 = new Button();
            btnReporte1 = new Button();
            btnMenuReportes = new Button();
            pnMenuPresupuesto = new Panel();
            btnNuevoPresupuesto = new Button();
            btnConsultarPresupuestos = new Button();
            btnMenuPresupuesto = new Button();
            pnMenuProductos = new Panel();
            btnNuevoProducto = new Button();
            btnConsultarProductos = new Button();
            btnMenuProductos = new Button();
            pnUsuario = new Panel();
            pbUserIcon = new PictureBox();
            lblUsuario = new Label();
            pnMuestra = new Panel();
            lblReloj = new Label();
            tmrReloj = new System.Windows.Forms.Timer(components);
            pnMenuPrincipal.SuspendLayout();
            pnControles.SuspendLayout();
            pnMenuReportes.SuspendLayout();
            pnMenuPresupuesto.SuspendLayout();
            pnMenuProductos.SuspendLayout();
            pnUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).BeginInit();
            pnMuestra.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenuPrincipal
            // 
            pnMenuPrincipal.BackColor = Color.FromArgb(43, 43, 43);
            pnMenuPrincipal.Controls.Add(btnSalir);
            pnMenuPrincipal.Controls.Add(pnControles);
            pnMenuPrincipal.Controls.Add(pnUsuario);
            pnMenuPrincipal.Dock = DockStyle.Left;
            pnMenuPrincipal.Location = new Point(0, 0);
            pnMenuPrincipal.Margin = new Padding(4, 3, 4, 3);
            pnMenuPrincipal.Name = "pnMenuPrincipal";
            pnMenuPrincipal.Size = new Size(198, 623);
            pnMenuPrincipal.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderColor = Color.White;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.IndianRed;
            btnSalir.Location = new Point(0, 578);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(198, 45);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnControles
            // 
            pnControles.AutoScroll = true;
            pnControles.Controls.Add(btnAcercaDe);
            pnControles.Controls.Add(pnMenuReportes);
            pnControles.Controls.Add(pnMenuPresupuesto);
            pnControles.Controls.Add(pnMenuProductos);
            pnControles.Location = new Point(0, 179);
            pnControles.Margin = new Padding(4, 3, 4, 3);
            pnControles.Name = "pnControles";
            pnControles.Size = new Size(217, 390);
            pnControles.TabIndex = 2;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.Dock = DockStyle.Top;
            btnAcercaDe.FlatAppearance.BorderColor = Color.White;
            btnAcercaDe.FlatAppearance.BorderSize = 0;
            btnAcercaDe.FlatStyle = FlatStyle.Flat;
            btnAcercaDe.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcercaDe.ForeColor = SystemColors.ControlLight;
            btnAcercaDe.ImageAlign = ContentAlignment.MiddleRight;
            btnAcercaDe.Location = new Point(0, 405);
            btnAcercaDe.Margin = new Padding(4, 3, 4, 3);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Padding = new Padding(18, 0, 0, 0);
            btnAcercaDe.Size = new Size(200, 45);
            btnAcercaDe.TabIndex = 1;
            btnAcercaDe.Text = "Acerca de";
            btnAcercaDe.TextAlign = ContentAlignment.MiddleLeft;
            btnAcercaDe.UseVisualStyleBackColor = true;
            btnAcercaDe.Click += btnAcercaDe_Click;
            // 
            // pnMenuReportes
            // 
            pnMenuReportes.Controls.Add(btnReporte2);
            pnMenuReportes.Controls.Add(btnReporte1);
            pnMenuReportes.Controls.Add(btnMenuReportes);
            pnMenuReportes.Dock = DockStyle.Top;
            pnMenuReportes.Location = new Point(0, 270);
            pnMenuReportes.Margin = new Padding(4, 3, 4, 3);
            pnMenuReportes.Name = "pnMenuReportes";
            pnMenuReportes.Size = new Size(200, 135);
            pnMenuReportes.TabIndex = 5;
            // 
            // btnReporte2
            // 
            btnReporte2.Dock = DockStyle.Top;
            btnReporte2.FlatAppearance.BorderColor = Color.White;
            btnReporte2.FlatAppearance.BorderSize = 0;
            btnReporte2.FlatStyle = FlatStyle.Flat;
            btnReporte2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReporte2.ForeColor = SystemColors.ControlLight;
            btnReporte2.Location = new Point(0, 90);
            btnReporte2.Margin = new Padding(4, 3, 4, 3);
            btnReporte2.Name = "btnReporte2";
            btnReporte2.Padding = new Padding(29, 0, 0, 0);
            btnReporte2.Size = new Size(200, 45);
            btnReporte2.TabIndex = 4;
            btnReporte2.Text = "Compras x cliente";
            btnReporte2.TextAlign = ContentAlignment.MiddleLeft;
            btnReporte2.UseVisualStyleBackColor = true;
            btnReporte2.Click += btnReporte2_Click;
            // 
            // btnReporte1
            // 
            btnReporte1.Dock = DockStyle.Top;
            btnReporte1.FlatAppearance.BorderColor = Color.White;
            btnReporte1.FlatAppearance.BorderSize = 0;
            btnReporte1.FlatStyle = FlatStyle.Flat;
            btnReporte1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReporte1.ForeColor = SystemColors.ControlLight;
            btnReporte1.Location = new Point(0, 45);
            btnReporte1.Margin = new Padding(4, 3, 4, 3);
            btnReporte1.Name = "btnReporte1";
            btnReporte1.Padding = new Padding(29, 0, 0, 0);
            btnReporte1.Size = new Size(200, 45);
            btnReporte1.TabIndex = 3;
            btnReporte1.Text = "Ganancia x tipo";
            btnReporte1.TextAlign = ContentAlignment.MiddleLeft;
            btnReporte1.UseVisualStyleBackColor = true;
            btnReporte1.Click += btnReporte1_Click;
            // 
            // btnMenuReportes
            // 
            btnMenuReportes.Dock = DockStyle.Top;
            btnMenuReportes.FlatAppearance.BorderColor = Color.White;
            btnMenuReportes.FlatAppearance.BorderSize = 0;
            btnMenuReportes.FlatStyle = FlatStyle.Flat;
            btnMenuReportes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuReportes.ForeColor = SystemColors.ControlLight;
            btnMenuReportes.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuReportes.Location = new Point(0, 0);
            btnMenuReportes.Margin = new Padding(4, 3, 4, 3);
            btnMenuReportes.Name = "btnMenuReportes";
            btnMenuReportes.Padding = new Padding(18, 0, 0, 0);
            btnMenuReportes.Size = new Size(200, 45);
            btnMenuReportes.TabIndex = 0;
            btnMenuReportes.Text = "Reportes";
            btnMenuReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuReportes.UseVisualStyleBackColor = true;
            btnMenuReportes.Click += btnMenuReportes_Click;
            // 
            // pnMenuPresupuesto
            // 
            pnMenuPresupuesto.Controls.Add(btnNuevoPresupuesto);
            pnMenuPresupuesto.Controls.Add(btnConsultarPresupuestos);
            pnMenuPresupuesto.Controls.Add(btnMenuPresupuesto);
            pnMenuPresupuesto.Dock = DockStyle.Top;
            pnMenuPresupuesto.Location = new Point(0, 135);
            pnMenuPresupuesto.Margin = new Padding(4, 3, 4, 3);
            pnMenuPresupuesto.Name = "pnMenuPresupuesto";
            pnMenuPresupuesto.Size = new Size(200, 135);
            pnMenuPresupuesto.TabIndex = 4;
            // 
            // btnNuevoPresupuesto
            // 
            btnNuevoPresupuesto.Dock = DockStyle.Top;
            btnNuevoPresupuesto.FlatAppearance.BorderColor = Color.White;
            btnNuevoPresupuesto.FlatAppearance.BorderSize = 0;
            btnNuevoPresupuesto.FlatStyle = FlatStyle.Flat;
            btnNuevoPresupuesto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoPresupuesto.ForeColor = SystemColors.ControlLight;
            btnNuevoPresupuesto.Location = new Point(0, 90);
            btnNuevoPresupuesto.Margin = new Padding(4, 3, 4, 3);
            btnNuevoPresupuesto.Name = "btnNuevoPresupuesto";
            btnNuevoPresupuesto.Padding = new Padding(29, 0, 0, 0);
            btnNuevoPresupuesto.Size = new Size(200, 45);
            btnNuevoPresupuesto.TabIndex = 2;
            btnNuevoPresupuesto.Text = "Nuevo Presupuesto";
            btnNuevoPresupuesto.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoPresupuesto.UseVisualStyleBackColor = true;
            btnNuevoPresupuesto.Click += btnNuevoPresupuesto_Click;
            // 
            // btnConsultarPresupuestos
            // 
            btnConsultarPresupuestos.Dock = DockStyle.Top;
            btnConsultarPresupuestos.FlatAppearance.BorderColor = Color.White;
            btnConsultarPresupuestos.FlatAppearance.BorderSize = 0;
            btnConsultarPresupuestos.FlatStyle = FlatStyle.Flat;
            btnConsultarPresupuestos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarPresupuestos.ForeColor = SystemColors.ControlLight;
            btnConsultarPresupuestos.Location = new Point(0, 45);
            btnConsultarPresupuestos.Margin = new Padding(4, 3, 4, 3);
            btnConsultarPresupuestos.Name = "btnConsultarPresupuestos";
            btnConsultarPresupuestos.Padding = new Padding(29, 0, 0, 0);
            btnConsultarPresupuestos.Size = new Size(200, 45);
            btnConsultarPresupuestos.TabIndex = 1;
            btnConsultarPresupuestos.Text = "Consultar Presupuestos";
            btnConsultarPresupuestos.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultarPresupuestos.UseVisualStyleBackColor = true;
            btnConsultarPresupuestos.Click += btnConsultarPresupuestos_Click;
            // 
            // btnMenuPresupuesto
            // 
            btnMenuPresupuesto.Dock = DockStyle.Top;
            btnMenuPresupuesto.FlatAppearance.BorderColor = Color.White;
            btnMenuPresupuesto.FlatAppearance.BorderSize = 0;
            btnMenuPresupuesto.FlatStyle = FlatStyle.Flat;
            btnMenuPresupuesto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuPresupuesto.ForeColor = SystemColors.ControlLight;
            btnMenuPresupuesto.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuPresupuesto.Location = new Point(0, 0);
            btnMenuPresupuesto.Margin = new Padding(4, 3, 4, 3);
            btnMenuPresupuesto.Name = "btnMenuPresupuesto";
            btnMenuPresupuesto.Padding = new Padding(18, 0, 0, 0);
            btnMenuPresupuesto.Size = new Size(200, 45);
            btnMenuPresupuesto.TabIndex = 0;
            btnMenuPresupuesto.Text = "Presupuesto";
            btnMenuPresupuesto.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuPresupuesto.UseVisualStyleBackColor = true;
            btnMenuPresupuesto.Click += btnMenuPresupuesto_Click;
            // 
            // pnMenuProductos
            // 
            pnMenuProductos.Controls.Add(btnNuevoProducto);
            pnMenuProductos.Controls.Add(btnConsultarProductos);
            pnMenuProductos.Controls.Add(btnMenuProductos);
            pnMenuProductos.Dock = DockStyle.Top;
            pnMenuProductos.Location = new Point(0, 0);
            pnMenuProductos.Margin = new Padding(4, 3, 4, 3);
            pnMenuProductos.Name = "pnMenuProductos";
            pnMenuProductos.Size = new Size(200, 135);
            pnMenuProductos.TabIndex = 0;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Dock = DockStyle.Top;
            btnNuevoProducto.FlatAppearance.BorderColor = Color.White;
            btnNuevoProducto.FlatAppearance.BorderSize = 0;
            btnNuevoProducto.FlatStyle = FlatStyle.Flat;
            btnNuevoProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoProducto.ForeColor = SystemColors.ControlLight;
            btnNuevoProducto.Location = new Point(0, 90);
            btnNuevoProducto.Margin = new Padding(4, 3, 4, 3);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Padding = new Padding(29, 0, 0, 0);
            btnNuevoProducto.Size = new Size(200, 45);
            btnNuevoProducto.TabIndex = 2;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnConsultarProductos
            // 
            btnConsultarProductos.Dock = DockStyle.Top;
            btnConsultarProductos.FlatAppearance.BorderColor = Color.White;
            btnConsultarProductos.FlatAppearance.BorderSize = 0;
            btnConsultarProductos.FlatStyle = FlatStyle.Flat;
            btnConsultarProductos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarProductos.ForeColor = SystemColors.ControlLight;
            btnConsultarProductos.Location = new Point(0, 45);
            btnConsultarProductos.Margin = new Padding(4, 3, 4, 3);
            btnConsultarProductos.Name = "btnConsultarProductos";
            btnConsultarProductos.Padding = new Padding(29, 0, 0, 0);
            btnConsultarProductos.Size = new Size(200, 45);
            btnConsultarProductos.TabIndex = 1;
            btnConsultarProductos.Text = "Consultar Productos";
            btnConsultarProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultarProductos.UseVisualStyleBackColor = true;
            btnConsultarProductos.Click += btnConsultarProductos_Click;
            // 
            // btnMenuProductos
            // 
            btnMenuProductos.Dock = DockStyle.Top;
            btnMenuProductos.FlatAppearance.BorderColor = Color.White;
            btnMenuProductos.FlatAppearance.BorderSize = 0;
            btnMenuProductos.FlatStyle = FlatStyle.Flat;
            btnMenuProductos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuProductos.ForeColor = SystemColors.ControlLight;
            btnMenuProductos.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuProductos.Location = new Point(0, 0);
            btnMenuProductos.Margin = new Padding(4, 3, 4, 3);
            btnMenuProductos.Name = "btnMenuProductos";
            btnMenuProductos.Padding = new Padding(18, 0, 0, 0);
            btnMenuProductos.Size = new Size(200, 45);
            btnMenuProductos.TabIndex = 0;
            btnMenuProductos.Text = "Productos";
            btnMenuProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuProductos.UseVisualStyleBackColor = true;
            btnMenuProductos.Click += btnMenuProductos_Click;
            // 
            // pnUsuario
            // 
            pnUsuario.BackColor = Color.FromArgb(43, 43, 43);
            pnUsuario.Controls.Add(pbUserIcon);
            pnUsuario.Controls.Add(lblUsuario);
            pnUsuario.Dock = DockStyle.Top;
            pnUsuario.Location = new Point(0, 0);
            pnUsuario.Margin = new Padding(4, 3, 4, 3);
            pnUsuario.Name = "pnUsuario";
            pnUsuario.Size = new Size(198, 179);
            pnUsuario.TabIndex = 1;
            // 
            // pbUserIcon
            // 
            pbUserIcon.Image = Properties.Resources.UserIcon;
            pbUserIcon.Location = new Point(50, 19);
            pbUserIcon.Margin = new Padding(4, 3, 4, 3);
            pbUserIcon.Name = "pbUserIcon";
            pbUserIcon.Size = new Size(98, 98);
            pbUserIcon.TabIndex = 1;
            pbUserIcon.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.Dock = DockStyle.Bottom;
            lblUsuario.FlatStyle = FlatStyle.Flat;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.WhiteSmoke;
            lblUsuario.Location = new Point(0, 127);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Padding = new Padding(0, 0, 0, 6);
            lblUsuario.Size = new Size(198, 52);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnMuestra
            // 
            pnMuestra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnMuestra.BackColor = Color.FromArgb(43, 43, 43);
            pnMuestra.Controls.Add(lblReloj);
            pnMuestra.Location = new Point(209, 12);
            pnMuestra.Margin = new Padding(4, 3, 4, 3);
            pnMuestra.Name = "pnMuestra";
            pnMuestra.Size = new Size(898, 600);
            pnMuestra.TabIndex = 1;
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblReloj.ForeColor = Color.FromArgb(72, 72, 72);
            lblReloj.Location = new Point(241, 246);
            lblReloj.Margin = new Padding(4, 0, 4, 0);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(417, 108);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            // 
            // tmrReloj
            // 
            tmrReloj.Interval = 1000;
            tmrReloj.Tick += tmrReloj_Tick;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(1120, 623);
            Controls.Add(pnMuestra);
            Controls.Add(pnMenuPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += FrmPrincipal_Load;
            pnMenuPrincipal.ResumeLayout(false);
            pnControles.ResumeLayout(false);
            pnMenuReportes.ResumeLayout(false);
            pnMenuPresupuesto.ResumeLayout(false);
            pnMenuProductos.ResumeLayout(false);
            pnUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).EndInit();
            pnMuestra.ResumeLayout(false);
            pnMuestra.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnMenuPrincipal;
        private System.Windows.Forms.Panel pnMuestra;
        private System.Windows.Forms.Panel pnUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnConsultarProductos;
        private System.Windows.Forms.Panel pnControles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnMenuReportes;
        private System.Windows.Forms.Button btnMenuPresupuesto;
        private System.Windows.Forms.Button btnConsultarPresupuestos;
        private System.Windows.Forms.Button btnMenuProductos;
        private System.Windows.Forms.Panel pnMenuProductos;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Panel pnMenuPresupuesto;
        private System.Windows.Forms.Button btnNuevoPresupuesto;
        private System.Windows.Forms.PictureBox pbUserIcon;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.Panel pnMenuReportes;
        private System.Windows.Forms.Button btnReporte2;
        private System.Windows.Forms.Button btnReporte1;
    }
}

