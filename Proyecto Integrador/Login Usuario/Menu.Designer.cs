namespace SIstema_ClubDeportivo
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            lblSocios = new System.Windows.Forms.Label();
            lblCuota = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.LightSkyBlue;
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button1.Location = new System.Drawing.Point(12, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(145, 104);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.LightSkyBlue;
            button2.BackgroundImage = (System.Drawing.Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button2.Location = new System.Drawing.Point(185, 12);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(145, 104);
            button2.TabIndex = 1;
            button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // lblSocios
            // 
            lblSocios.AutoSize = true;
            lblSocios.Location = new System.Drawing.Point(58, 119);
            lblSocios.Name = "lblSocios";
            lblSocios.Size = new System.Drawing.Size(52, 20);
            lblSocios.TabIndex = 2;
            lblSocios.Text = "Socios";
            lblSocios.Click += label1_Click;
            // 
            // lblCuota
            // 
            lblCuota.AutoSize = true;
            lblCuota.Location = new System.Drawing.Point(231, 119);
            lblCuota.Name = "lblCuota";
            lblCuota.Size = new System.Drawing.Size(48, 20);
            lblCuota.TabIndex = 3;
            lblCuota.Text = "Cuota";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSkyBlue;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblCuota);
            Controls.Add(lblSocios);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmMenu";
            Text = "Menu";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSocios;
        private System.Windows.Forms.Label lblCuota;


    }
}