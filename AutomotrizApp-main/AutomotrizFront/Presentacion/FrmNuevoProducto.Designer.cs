namespace AutomotrizFront.Presentacion
{
    partial class FrmNuevoProducto
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
            btnConfirmar = new Button();
            lblTitulo = new Label();
            lblTipoProducto = new Label();
            lblPrecioProducto = new Label();
            cboTipoProducto = new ComboBox();
            txtPrecioProducto = new TextBox();
            lblNombreProducto = new Label();
            txtNombreProducto = new TextBox();
            dgvConsultarProductos = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            nombreProducto = new DataGridViewTextBoxColumn();
            precioProducto = new DataGridViewTextBoxColumn();
            tipoProducto = new DataGridViewTextBoxColumn();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarProductos).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(797, 560);
            btnConfirmar.Margin = new Padding(4, 3, 4, 3);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(88, 27);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLight;
            lblTitulo.Location = new Point(14, 13);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(166, 25);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Nuevo Producto";
            // 
            // lblTipoProducto
            // 
            lblTipoProducto.AutoSize = true;
            lblTipoProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoProducto.ForeColor = SystemColors.ControlLight;
            lblTipoProducto.Location = new Point(71, 145);
            lblTipoProducto.Margin = new Padding(4, 0, 4, 0);
            lblTipoProducto.Name = "lblTipoProducto";
            lblTipoProducto.Size = new Size(31, 15);
            lblTipoProducto.TabIndex = 17;
            lblTipoProducto.Text = "Tipo";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioProducto.ForeColor = SystemColors.ControlLight;
            lblPrecioProducto.Location = new Point(58, 105);
            lblPrecioProducto.Margin = new Padding(4, 0, 4, 0);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(42, 15);
            lblPrecioProducto.TabIndex = 16;
            lblPrecioProducto.Text = "Precio";
            // 
            // cboTipoProducto
            // 
            cboTipoProducto.FormattingEnabled = true;
            cboTipoProducto.Location = new Point(114, 144);
            cboTipoProducto.Margin = new Padding(4, 3, 4, 3);
            cboTipoProducto.Name = "cboTipoProducto";
            cboTipoProducto.Size = new Size(276, 23);
            cboTipoProducto.TabIndex = 2;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(114, 104);
            txtPrecioProducto.Margin = new Padding(4, 3, 4, 3);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(276, 23);
            txtPrecioProducto.TabIndex = 1;
            txtPrecioProducto.KeyPress += txtNumerico_KeyPress;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreProducto.ForeColor = SystemColors.ControlLight;
            lblNombreProducto.Location = new Point(47, 65);
            lblNombreProducto.Margin = new Padding(4, 0, 4, 0);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(52, 15);
            lblNombreProducto.TabIndex = 12;
            lblNombreProducto.Text = "Nombre";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(114, 63);
            txtNombreProducto.Margin = new Padding(4, 3, 4, 3);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(276, 23);
            txtNombreProducto.TabIndex = 0;
            // 
            // dgvConsultarProductos
            // 
            dgvConsultarProductos.AllowUserToAddRows = false;
            dgvConsultarProductos.AllowUserToDeleteRows = false;
            dgvConsultarProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarProductos.BorderStyle = BorderStyle.None;
            dgvConsultarProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarProductos.Columns.AddRange(new DataGridViewColumn[] { idProducto, nombreProducto, precioProducto, tipoProducto });
            dgvConsultarProductos.Location = new Point(14, 189);
            dgvConsultarProductos.Margin = new Padding(4, 3, 4, 3);
            dgvConsultarProductos.Name = "dgvConsultarProductos";
            dgvConsultarProductos.ReadOnly = true;
            dgvConsultarProductos.RowHeadersVisible = false;
            dgvConsultarProductos.Size = new Size(870, 346);
            dgvConsultarProductos.TabIndex = 4;
            // 
            // idProducto
            // 
            idProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            idProducto.HeaderText = "ID";
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            idProducto.Width = 43;
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "Nombre";
            nombreProducto.Name = "nombreProducto";
            nombreProducto.ReadOnly = true;
            // 
            // precioProducto
            // 
            precioProducto.HeaderText = "Precio";
            precioProducto.Name = "precioProducto";
            precioProducto.ReadOnly = true;
            // 
            // tipoProducto
            // 
            tipoProducto.HeaderText = "Tipo";
            tipoProducto.Name = "tipoProducto";
            tipoProducto.ReadOnly = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(14, 560);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 27);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(898, 600);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lblTitulo);
            Controls.Add(lblTipoProducto);
            Controls.Add(lblPrecioProducto);
            Controls.Add(cboTipoProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(dgvConsultarProductos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmNuevoProducto";
            Text = "FrmNuevoProducto";
            Load += FrmNuevoProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.DataGridView dgvConsultarProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProducto;
        private System.Windows.Forms.Button btnCancelar;
    }
}