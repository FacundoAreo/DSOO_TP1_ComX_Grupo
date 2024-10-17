namespace Login_Usuario
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblTitulo = new System.Windows.Forms.Label();
            btnIngresar = new System.Windows.Forms.Button();
            txtUsuario = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(928, 346);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(122, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Login";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new System.Drawing.Point(1045, 643);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(191, 86);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(1023, 445);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(257, 27);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "Usuario";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new System.Drawing.Point(1023, 495);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(257, 27);
            txtPass.TabIndex = 3;
            txtPass.Text = "Contraseña";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(1902, 1033);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblTitulo);
            Name = "frmLogin";
            Text = "Login";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
    }
}
