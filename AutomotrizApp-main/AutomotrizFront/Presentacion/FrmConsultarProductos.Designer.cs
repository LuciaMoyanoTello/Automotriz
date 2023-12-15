namespace AutomotrizFront.Presentacion
{
    partial class FrmConsultarProductos
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
            dgvConsultarProductos = new DataGridView();
            txtNombreProducto = new TextBox();
            lblNombreProducto = new Label();
            txtPrecioProductoMin = new TextBox();
            txtPrecioProductoMax = new TextBox();
            cboTipoProducto = new ComboBox();
            lblPrecioProducto = new Label();
            lblTipoProducto = new Label();
            lblTitulo = new Label();
            btnFiltrar = new Button();
            btnReiniciarFiltros = new Button();
            idProducto = new DataGridViewTextBoxColumn();
            nombreProducto = new DataGridViewTextBoxColumn();
            precioProducto = new DataGridViewTextBoxColumn();
            tipoProducto = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultarProductos
            // 
            dgvConsultarProductos.AllowUserToAddRows = false;
            dgvConsultarProductos.AllowUserToDeleteRows = false;
            dgvConsultarProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarProductos.BorderStyle = BorderStyle.None;
            dgvConsultarProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarProductos.Columns.AddRange(new DataGridViewColumn[] { idProducto, nombreProducto, precioProducto, tipoProducto, Editar, Eliminar });
            dgvConsultarProductos.Location = new Point(14, 187);
            dgvConsultarProductos.Margin = new Padding(4, 3, 4, 3);
            dgvConsultarProductos.Name = "dgvConsultarProductos";
            dgvConsultarProductos.ReadOnly = true;
            dgvConsultarProductos.RowHeadersVisible = false;
            dgvConsultarProductos.Size = new Size(870, 399);
            dgvConsultarProductos.TabIndex = 6;
            dgvConsultarProductos.CellContentClick += dgvConsultarProductos_CellContentClick;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNombreProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNombreProducto.Location = new Point(114, 61);
            txtNombreProducto.Margin = new Padding(4, 3, 4, 3);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(276, 23);
            txtNombreProducto.TabIndex = 0;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreProducto.ForeColor = SystemColors.ControlLight;
            lblNombreProducto.Location = new Point(47, 62);
            lblNombreProducto.Margin = new Padding(4, 0, 4, 0);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(52, 15);
            lblNombreProducto.TabIndex = 2;
            lblNombreProducto.Text = "Nombre";
            // 
            // txtPrecioProductoMin
            // 
            txtPrecioProductoMin.Location = new Point(114, 102);
            txtPrecioProductoMin.Margin = new Padding(4, 3, 4, 3);
            txtPrecioProductoMin.Name = "txtPrecioProductoMin";
            txtPrecioProductoMin.Size = new Size(116, 23);
            txtPrecioProductoMin.TabIndex = 1;
            txtPrecioProductoMin.KeyPress += txtNumerico_KeyPress;
            // 
            // txtPrecioProductoMax
            // 
            txtPrecioProductoMax.Location = new Point(274, 102);
            txtPrecioProductoMax.Margin = new Padding(4, 3, 4, 3);
            txtPrecioProductoMax.Name = "txtPrecioProductoMax";
            txtPrecioProductoMax.Size = new Size(116, 23);
            txtPrecioProductoMax.TabIndex = 2;
            txtPrecioProductoMax.KeyPress += txtNumerico_KeyPress;
            // 
            // cboTipoProducto
            // 
            cboTipoProducto.FormattingEnabled = true;
            cboTipoProducto.Location = new Point(114, 142);
            cboTipoProducto.Margin = new Padding(4, 3, 4, 3);
            cboTipoProducto.Name = "cboTipoProducto";
            cboTipoProducto.Size = new Size(276, 23);
            cboTipoProducto.TabIndex = 3;
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioProducto.ForeColor = SystemColors.ControlLight;
            lblPrecioProducto.Location = new Point(58, 103);
            lblPrecioProducto.Margin = new Padding(4, 0, 4, 0);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(42, 15);
            lblPrecioProducto.TabIndex = 6;
            lblPrecioProducto.Text = "Precio";
            // 
            // lblTipoProducto
            // 
            lblTipoProducto.AutoSize = true;
            lblTipoProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoProducto.ForeColor = SystemColors.ControlLight;
            lblTipoProducto.Location = new Point(71, 143);
            lblTipoProducto.Margin = new Padding(4, 0, 4, 0);
            lblTipoProducto.Name = "lblTipoProducto";
            lblTipoProducto.Size = new Size(31, 15);
            lblTipoProducto.TabIndex = 7;
            lblTipoProducto.Text = "Tipo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLight;
            lblTitulo.Location = new Point(14, 10);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(215, 25);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Listado de Productos";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(797, 143);
            btnFiltrar.Margin = new Padding(4, 3, 4, 3);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(88, 27);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnReiniciarFiltros
            // 
            btnReiniciarFiltros.Location = new Point(654, 143);
            btnReiniciarFiltros.Margin = new Padding(4, 3, 4, 3);
            btnReiniciarFiltros.Name = "btnReiniciarFiltros";
            btnReiniciarFiltros.Size = new Size(125, 27);
            btnReiniciarFiltros.TabIndex = 5;
            btnReiniciarFiltros.Text = "Reiniciar Filtros";
            btnReiniciarFiltros.UseVisualStyleBackColor = true;
            btnReiniciarFiltros.Click += btnReiniciarFiltros_Click;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "ID";
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            idProducto.Visible = false;
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "Nombre";
            nombreProducto.Name = "nombreProducto";
            nombreProducto.ReadOnly = true;
            // 
            // precioProducto
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            precioProducto.DefaultCellStyle = dataGridViewCellStyle1;
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
            // Editar
            // 
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Editar.HeaderText = "Accion";
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Resizable = DataGridViewTriState.True;
            Editar.Width = 50;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Eliminar.HeaderText = "Accion";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Width = 50;
            // 
            // FrmConsultarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(898, 600);
            Controls.Add(btnReiniciarFiltros);
            Controls.Add(btnFiltrar);
            Controls.Add(lblTitulo);
            Controls.Add(lblTipoProducto);
            Controls.Add(lblPrecioProducto);
            Controls.Add(cboTipoProducto);
            Controls.Add(txtPrecioProductoMax);
            Controls.Add(txtPrecioProductoMin);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(dgvConsultarProductos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmConsultarProductos";
            Text = "FrmConsultarProductos";
            Load += FrmConsultarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarProductos;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioProductoMin;
        private System.Windows.Forms.TextBox txtPrecioProductoMax;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnReiniciarFiltros;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn precioProducto;
        private DataGridViewTextBoxColumn tipoProducto;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
    }
}