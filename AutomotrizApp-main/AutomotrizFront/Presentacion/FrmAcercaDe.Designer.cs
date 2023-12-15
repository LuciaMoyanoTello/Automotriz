namespace AutomotrizFront.Presentacion
{
    partial class FrmAcercaDe
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
            lblGrupo = new Label();
            lblIntegrantes = new Label();
            lblComision = new Label();
            lblTextoGrupo = new Label();
            lblComisionTexto = new Label();
            lblIntegratesTexto = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLight;
            lblTitulo.Location = new Point(14, 10);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(175, 37);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "Acerca De";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.BackColor = Color.Transparent;
            lblGrupo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblGrupo.ForeColor = SystemColors.ControlLight;
            lblGrupo.Location = new Point(16, 88);
            lblGrupo.Margin = new Padding(4, 0, 4, 0);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(77, 25);
            lblGrupo.TabIndex = 21;
            lblGrupo.Text = "Grupo:";
            // 
            // lblIntegrantes
            // 
            lblIntegrantes.AutoSize = true;
            lblIntegrantes.BackColor = Color.Transparent;
            lblIntegrantes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIntegrantes.ForeColor = SystemColors.ControlLight;
            lblIntegrantes.Location = new Point(16, 307);
            lblIntegrantes.Margin = new Padding(4, 0, 4, 0);
            lblIntegrantes.Name = "lblIntegrantes";
            lblIntegrantes.Size = new Size(125, 25);
            lblIntegrantes.TabIndex = 22;
            lblIntegrantes.Text = "Integrantes:";
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.BackColor = Color.Transparent;
            lblComision.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblComision.ForeColor = SystemColors.ControlLight;
            lblComision.Location = new Point(16, 197);
            lblComision.Margin = new Padding(4, 0, 4, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(101, 25);
            lblComision.TabIndex = 23;
            lblComision.Text = "Comision";
            // 
            // lblTextoGrupo
            // 
            lblTextoGrupo.AutoSize = true;
            lblTextoGrupo.BackColor = Color.Transparent;
            lblTextoGrupo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTextoGrupo.ForeColor = SystemColors.ControlLight;
            lblTextoGrupo.Location = new Point(18, 128);
            lblTextoGrupo.Margin = new Padding(4, 0, 4, 0);
            lblTextoGrupo.Name = "lblTextoGrupo";
            lblTextoGrupo.Size = new Size(167, 20);
            lblTextoGrupo.TabIndex = 24;
            lblTextoGrupo.Text = "Grupo 12 (Automotriz)";
            // 
            // lblComisionTexto
            // 
            lblComisionTexto.AutoSize = true;
            lblComisionTexto.BackColor = Color.Transparent;
            lblComisionTexto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblComisionTexto.ForeColor = SystemColors.ControlLight;
            lblComisionTexto.Location = new Point(18, 238);
            lblComisionTexto.Margin = new Padding(4, 0, 4, 0);
            lblComisionTexto.Name = "lblComisionTexto";
            lblComisionTexto.Size = new Size(93, 20);
            lblComisionTexto.TabIndex = 25;
            lblComisionTexto.Text = "1w1 (Tarde)";
            // 
            // lblIntegratesTexto
            // 
            lblIntegratesTexto.AutoSize = true;
            lblIntegratesTexto.BackColor = Color.Transparent;
            lblIntegratesTexto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIntegratesTexto.ForeColor = SystemColors.ControlLight;
            lblIntegratesTexto.Location = new Point(18, 347);
            lblIntegratesTexto.Margin = new Padding(4, 0, 4, 0);
            lblIntegratesTexto.Name = "lblIntegratesTexto";
            lblIntegratesTexto.Size = new Size(272, 60);
            lblIntegratesTexto.TabIndex = 26;
            lblIntegratesTexto.Text = "113857 De Maussion Gabriel\r\n114136 Moyano Tello Lucia Amancay\r\n114256 Menta Agustina";
            // 
            // FrmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            BackgroundImage = Properties.Resources.BackgroundAcercaDe;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(898, 600);
            Controls.Add(lblIntegratesTexto);
            Controls.Add(lblComisionTexto);
            Controls.Add(lblTextoGrupo);
            Controls.Add(lblComision);
            Controls.Add(lblIntegrantes);
            Controls.Add(lblGrupo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmAcercaDe";
            Text = "FrmAcercaDe";
            Load += FrmAcercaDe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblTextoGrupo;
        private System.Windows.Forms.Label lblComisionTexto;
        private System.Windows.Forms.Label lblIntegratesTexto;
    }
}