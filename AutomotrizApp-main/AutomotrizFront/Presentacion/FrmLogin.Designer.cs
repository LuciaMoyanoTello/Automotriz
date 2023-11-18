namespace AutomotrizFront.Presentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            btnIngresar = new Button();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            lblLoginError = new Label();
            cbPassword = new CheckBox();
            pbLogo = new PictureBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ControlLight;
            btnIngresar.Location = new Point(128, 422);
            btnIngresar.Margin = new Padding(4, 3, 4, 3);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(128, 43);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(99, 344);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(186, 26);
            txtPassword.TabIndex = 2;
            txtPassword.Tag = "Contraseña";
            txtPassword.Text = "Contraseña";
            txtPassword.Enter += TextBoxEvento;
            txtPassword.Leave += TextBoxEvento;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUser.ForeColor = Color.Gray;
            txtUser.Location = new Point(98, 271);
            txtUser.Margin = new Padding(4, 3, 4, 3);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(186, 26);
            txtUser.TabIndex = 1;
            txtUser.Tag = "Usuario";
            txtUser.Text = "Usuario";
            txtUser.Enter += TextBoxEvento;
            txtUser.Leave += TextBoxEvento;
            // 
            // lblLoginError
            // 
            lblLoginError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLoginError.AutoSize = true;
            lblLoginError.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoginError.ForeColor = Color.FromArgb(226, 50, 50);
            lblLoginError.Location = new Point(55, 389);
            lblLoginError.Margin = new Padding(4, 0, 4, 0);
            lblLoginError.Name = "lblLoginError";
            lblLoginError.Size = new Size(0, 16);
            lblLoginError.TabIndex = 5;
            lblLoginError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbPassword
            // 
            cbPassword.Appearance = Appearance.Button;
            cbPassword.AutoCheck = false;
            cbPassword.CheckAlign = ContentAlignment.MiddleCenter;
            cbPassword.FlatAppearance.BorderSize = 0;
            cbPassword.FlatAppearance.CheckedBackColor = Color.FromArgb(43, 43, 43);
            cbPassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            cbPassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 43, 43);
            cbPassword.FlatStyle = FlatStyle.Flat;
            cbPassword.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbPassword.Image = Properties.Resources.PassHideIcon;
            cbPassword.Location = new Point(294, 344);
            cbPassword.Margin = new Padding(0);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(29, 29);
            cbPassword.TabIndex = 3;
            cbPassword.TextAlign = ContentAlignment.MiddleCenter;
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.Click += cbPassword_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.AutomotrizLogo;
            pbLogo.Location = new Point(111, 95);
            pbLogo.Margin = new Padding(4, 3, 4, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(162, 112);
            pbLogo.TabIndex = 3;
            pbLogo.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = Properties.Resources.ExitIcon;
            btnSalir.Location = new Point(356, 6);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(23, 23);
            btnSalir.TabIndex = 6;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(385, 531);
            Controls.Add(btnSalir);
            Controls.Add(cbPassword);
            Controls.Add(lblLoginError);
            Controls.Add(pbLogo);
            Controls.Add(txtUser);
            Controls.Add(txtPassword);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.CheckBox cbPassword;
        private System.Windows.Forms.Button btnSalir;
    }
}