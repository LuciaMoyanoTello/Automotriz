namespace AutomotrizFront.Presentacion
{
    partial class FrmNuevoPresupuesto
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
            lblDniCliente = new Label();
            lblFecha = new Label();
            txtCantidad = new TextBox();
            dgvDetallesNuevoPresupuesto = new DataGridView();
            btnAgregar = new Button();
            cboProducto = new ComboBox();
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            txtDniCliente = new TextBox();
            lblTotalTexto = new Label();
            lblTotalValor = new Label();
            btnCancelar = new Button();
            nombreProducto = new DataGridViewTextBoxColumn();
            precioProducto = new DataGridViewTextBoxColumn();
            cantidadProducto = new DataGridViewTextBoxColumn();
            subTotalDetalle = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesNuevoPresupuesto).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(797, 561);
            btnConfirmar.Margin = new Padding(4, 3, 4, 3);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(88, 27);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLight;
            lblTitulo.Location = new Point(14, 14);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(201, 25);
            lblTitulo.TabIndex = 27;
            lblTitulo.Text = "Nuevo Presupuesto";
            // 
            // lblTipoProducto
            // 
            lblTipoProducto.AutoSize = true;
            lblTipoProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoProducto.ForeColor = SystemColors.ControlLight;
            lblTipoProducto.Location = new Point(421, 147);
            lblTipoProducto.Margin = new Padding(4, 0, 4, 0);
            lblTipoProducto.Name = "lblTipoProducto";
            lblTipoProducto.Size = new Size(56, 15);
            lblTipoProducto.TabIndex = 26;
            lblTipoProducto.Text = "Cantidad";
            // 
            // lblDniCliente
            // 
            lblDniCliente.AutoSize = true;
            lblDniCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDniCliente.ForeColor = SystemColors.ControlLight;
            lblDniCliente.Location = new Point(74, 106);
            lblDniCliente.Margin = new Padding(4, 0, 4, 0);
            lblDniCliente.Name = "lblDniCliente";
            lblDniCliente.Size = new Size(28, 15);
            lblDniCliente.TabIndex = 25;
            lblDniCliente.Text = "DNI";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = SystemColors.ControlLight;
            lblFecha.Location = new Point(58, 66);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 22;
            lblFecha.Text = "Fecha";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(493, 145);
            txtCantidad.Margin = new Padding(4, 3, 4, 3);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(276, 23);
            txtCantidad.TabIndex = 3;
            txtCantidad.KeyPress += txtNumerico_KeyPress;
            // 
            // dgvDetallesNuevoPresupuesto
            // 
            dgvDetallesNuevoPresupuesto.AllowUserToAddRows = false;
            dgvDetallesNuevoPresupuesto.AllowUserToDeleteRows = false;
            dgvDetallesNuevoPresupuesto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallesNuevoPresupuesto.BorderStyle = BorderStyle.None;
            dgvDetallesNuevoPresupuesto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesNuevoPresupuesto.Columns.AddRange(new DataGridViewColumn[] { nombreProducto, precioProducto, cantidadProducto, subTotalDetalle, Eliminar });
            dgvDetallesNuevoPresupuesto.Location = new Point(14, 190);
            dgvDetallesNuevoPresupuesto.Margin = new Padding(4, 3, 4, 3);
            dgvDetallesNuevoPresupuesto.Name = "dgvDetallesNuevoPresupuesto";
            dgvDetallesNuevoPresupuesto.ReadOnly = true;
            dgvDetallesNuevoPresupuesto.RowHeadersVisible = false;
            dgvDetallesNuevoPresupuesto.Size = new Size(870, 346);
            dgvDetallesNuevoPresupuesto.TabIndex = 6;
            dgvDetallesNuevoPresupuesto.CellContentClick += dgvDetallesNuevoPresupuesto_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(797, 143);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 27);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(114, 144);
            cboProducto.Margin = new Padding(4, 3, 4, 3);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(276, 23);
            cboProducto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(41, 147);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 30;
            label1.Text = "Producto";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "";
            dtpFecha.Location = new Point(114, 66);
            dtpFecha.Margin = new Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(276, 23);
            dtpFecha.TabIndex = 0;
            dtpFecha.Value = new DateTime(2023, 11, 6, 0, 0, 0, 0);
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(114, 105);
            txtDniCliente.Margin = new Padding(4, 3, 4, 3);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(276, 23);
            txtDniCliente.TabIndex = 1;
            txtDniCliente.KeyPress += txtNumerico_KeyPress;
            // 
            // lblTotalTexto
            // 
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalTexto.ForeColor = SystemColors.ControlLight;
            lblTotalTexto.Location = new Point(601, 564);
            lblTotalTexto.Margin = new Padding(4, 0, 4, 0);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Size = new Size(54, 16);
            lblTotalTexto.TabIndex = 35;
            lblTotalTexto.Text = "Total:  $";
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalValor.ForeColor = SystemColors.ControlLight;
            lblTotalValor.Location = new Point(659, 564);
            lblTotalValor.Margin = new Padding(4, 0, 4, 0);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(14, 16);
            lblTotalValor.TabIndex = 36;
            lblTotalValor.Text = "0";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(14, 556);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 27);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "Producto";
            nombreProducto.Name = "nombreProducto";
            nombreProducto.ReadOnly = true;
            // 
            // precioProducto
            // 
            precioProducto.HeaderText = "Precio";
            precioProducto.Name = "precioProducto";
            precioProducto.ReadOnly = true;
            // 
            // cantidadProducto
            // 
            cantidadProducto.HeaderText = "Cantidad";
            cantidadProducto.Name = "cantidadProducto";
            cantidadProducto.ReadOnly = true;
            // 
            // subTotalDetalle
            // 
            subTotalDetalle.HeaderText = "Sub-Total";
            subTotalDetalle.Name = "subTotalDetalle";
            subTotalDetalle.ReadOnly = true;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Eliminar.HeaderText = "Accion";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Width = 50;
            // 
            // FrmNuevoPresupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(898, 600);
            Controls.Add(btnCancelar);
            Controls.Add(lblTotalValor);
            Controls.Add(lblTotalTexto);
            Controls.Add(txtDniCliente);
            Controls.Add(dtpFecha);
            Controls.Add(cboProducto);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(btnConfirmar);
            Controls.Add(lblTitulo);
            Controls.Add(lblTipoProducto);
            Controls.Add(lblDniCliente);
            Controls.Add(lblFecha);
            Controls.Add(txtCantidad);
            Controls.Add(dgvDetallesNuevoPresupuesto);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmNuevoPresupuesto";
            Text = "FrmNuevoPresupuesto";
            Load += FrmNuevoPresupuesto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetallesNuevoPresupuesto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvDetallesNuevoPresupuesto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label lblTotalTexto;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Button btnCancelar;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn precioProducto;
        private DataGridViewTextBoxColumn cantidadProducto;
        private DataGridViewTextBoxColumn subTotalDetalle;
        private DataGridViewButtonColumn Eliminar;
    }
}