namespace AutomotrizFront.Presentacion
{
    partial class FrmConsultarPresupuestos
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
            btnReiniciarFiltros = new Button();
            btnFiltrar = new Button();
            lblTitulo = new Label();
            lblTotal = new Label();
            lblFecha = new Label();
            lblNombreProducto = new Label();
            txtDniCliente = new TextBox();
            dgvConsultarPresupuestos = new DataGridView();
            txtTotalMax = new TextBox();
            txtTotalMin = new TextBox();
            dtpFechaMin = new DateTimePicker();
            dtpFechaMax = new DateTimePicker();
            idPresupuesto = new DataGridViewTextBoxColumn();
            nombreCliente = new DataGridViewTextBoxColumn();
            dniCliente = new DataGridViewTextBoxColumn();
            fechaPresupuesto = new DataGridViewTextBoxColumn();
            totalPresupuesto = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarPresupuestos).BeginInit();
            SuspendLayout();
            // 
            // btnReiniciarFiltros
            // 
            btnReiniciarFiltros.Location = new Point(654, 145);
            btnReiniciarFiltros.Margin = new Padding(4, 3, 4, 3);
            btnReiniciarFiltros.Name = "btnReiniciarFiltros";
            btnReiniciarFiltros.Size = new Size(125, 27);
            btnReiniciarFiltros.TabIndex = 6;
            btnReiniciarFiltros.Text = "Reiniciar Filtros";
            btnReiniciarFiltros.UseVisualStyleBackColor = true;
            btnReiniciarFiltros.Click += btnReiniciarFiltros_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(797, 145);
            btnFiltrar.Margin = new Padding(4, 3, 4, 3);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(88, 27);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLight;
            lblTitulo.Location = new Point(14, 13);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 25);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Listado de Presupuestos";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = SystemColors.ControlLight;
            lblTotal.Location = new Point(68, 145);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(34, 15);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "Total";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = SystemColors.ControlLight;
            lblFecha.Location = new Point(59, 105);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 16;
            lblFecha.Text = "Fecha";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreProducto.ForeColor = SystemColors.ControlLight;
            lblNombreProducto.Location = new Point(75, 65);
            lblNombreProducto.Margin = new Padding(4, 0, 4, 0);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(28, 15);
            lblNombreProducto.TabIndex = 12;
            lblNombreProducto.Text = "DNI";
            // 
            // txtDniCliente
            // 
            txtDniCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtDniCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtDniCliente.Location = new Point(114, 63);
            txtDniCliente.Margin = new Padding(4, 3, 4, 3);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(276, 23);
            txtDniCliente.TabIndex = 0;
            // 
            // dgvConsultarPresupuestos
            // 
            dgvConsultarPresupuestos.AllowUserToAddRows = false;
            dgvConsultarPresupuestos.AllowUserToDeleteRows = false;
            dgvConsultarPresupuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarPresupuestos.BorderStyle = BorderStyle.None;
            dgvConsultarPresupuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarPresupuestos.Columns.AddRange(new DataGridViewColumn[] { idPresupuesto, nombreCliente, dniCliente, fechaPresupuesto, totalPresupuesto, Eliminar });
            dgvConsultarPresupuestos.Location = new Point(14, 187);
            dgvConsultarPresupuestos.Margin = new Padding(4, 3, 4, 3);
            dgvConsultarPresupuestos.Name = "dgvConsultarPresupuestos";
            dgvConsultarPresupuestos.ReadOnly = true;
            dgvConsultarPresupuestos.RowHeadersVisible = false;
            dgvConsultarPresupuestos.Size = new Size(870, 399);
            dgvConsultarPresupuestos.TabIndex = 7;
            dgvConsultarPresupuestos.CellContentClick += dgvConsultarPresupuestos_CellContentClick;
            // 
            // txtTotalMax
            // 
            txtTotalMax.Location = new Point(274, 144);
            txtTotalMax.Margin = new Padding(4, 3, 4, 3);
            txtTotalMax.Name = "txtTotalMax";
            txtTotalMax.Size = new Size(116, 23);
            txtTotalMax.TabIndex = 4;
            txtTotalMax.KeyPress += txtNumerico_KeyPress;
            // 
            // txtTotalMin
            // 
            txtTotalMin.Location = new Point(114, 144);
            txtTotalMin.Margin = new Padding(4, 3, 4, 3);
            txtTotalMin.Name = "txtTotalMin";
            txtTotalMin.Size = new Size(116, 23);
            txtTotalMin.TabIndex = 3;
            txtTotalMin.KeyPress += txtNumerico_KeyPress;
            // 
            // dtpFechaMin
            // 
            dtpFechaMin.CustomFormat = "";
            dtpFechaMin.Format = DateTimePickerFormat.Short;
            dtpFechaMin.Location = new Point(114, 104);
            dtpFechaMin.Margin = new Padding(4, 3, 4, 3);
            dtpFechaMin.Name = "dtpFechaMin";
            dtpFechaMin.Size = new Size(116, 23);
            dtpFechaMin.TabIndex = 1;
            // 
            // dtpFechaMax
            // 
            dtpFechaMax.CustomFormat = "";
            dtpFechaMax.Format = DateTimePickerFormat.Short;
            dtpFechaMax.Location = new Point(274, 104);
            dtpFechaMax.Margin = new Padding(4, 3, 4, 3);
            dtpFechaMax.Name = "dtpFechaMax";
            dtpFechaMax.Size = new Size(116, 23);
            dtpFechaMax.TabIndex = 2;
            // 
            // idPresupuesto
            // 
            idPresupuesto.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            idPresupuesto.HeaderText = "ID";
            idPresupuesto.Name = "idPresupuesto";
            idPresupuesto.ReadOnly = true;
            idPresupuesto.Visible = false;
            idPresupuesto.Width = 24;
            // 
            // nombreCliente
            // 
            nombreCliente.HeaderText = "Cliente";
            nombreCliente.Name = "nombreCliente";
            nombreCliente.ReadOnly = true;
            // 
            // dniCliente
            // 
            dniCliente.HeaderText = "DNI";
            dniCliente.Name = "dniCliente";
            dniCliente.ReadOnly = true;
            // 
            // fechaPresupuesto
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            fechaPresupuesto.DefaultCellStyle = dataGridViewCellStyle1;
            fechaPresupuesto.HeaderText = "Fecha";
            fechaPresupuesto.Name = "fechaPresupuesto";
            fechaPresupuesto.ReadOnly = true;
            // 
            // totalPresupuesto
            // 
            totalPresupuesto.HeaderText = "Total";
            totalPresupuesto.Name = "totalPresupuesto";
            totalPresupuesto.ReadOnly = true;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Eliminar.HeaderText = "Accion";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            Eliminar.Width = 69;
            // 
            // FrmConsultarPresupuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(898, 600);
            Controls.Add(dtpFechaMax);
            Controls.Add(dtpFechaMin);
            Controls.Add(txtTotalMax);
            Controls.Add(txtTotalMin);
            Controls.Add(btnReiniciarFiltros);
            Controls.Add(btnFiltrar);
            Controls.Add(lblTitulo);
            Controls.Add(lblTotal);
            Controls.Add(lblFecha);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtDniCliente);
            Controls.Add(dgvConsultarPresupuestos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmConsultarPresupuestos";
            Text = "FrmConsultarPresupuestos";
            Load += FrmConsultarPresupuestos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarPresupuestos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnReiniciarFiltros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.DataGridView dgvConsultarPresupuestos;
        private System.Windows.Forms.TextBox txtTotalMax;
        private System.Windows.Forms.TextBox txtTotalMin;
        private System.Windows.Forms.DateTimePicker dtpFechaMin;
        private System.Windows.Forms.DateTimePicker dtpFechaMax;
        private DataGridViewTextBoxColumn idPresupuesto;
        private DataGridViewTextBoxColumn nombreCliente;
        private DataGridViewTextBoxColumn dniCliente;
        private DataGridViewTextBoxColumn fechaPresupuesto;
        private DataGridViewTextBoxColumn totalPresupuesto;
        private DataGridViewButtonColumn Eliminar;
    }
}