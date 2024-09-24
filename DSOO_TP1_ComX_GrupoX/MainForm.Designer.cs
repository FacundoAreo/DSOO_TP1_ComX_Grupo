namespace DSOO_TP1_ComX_GrupoX
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controles para el formulario
        private System.Windows.Forms.TextBox txtIdSocio;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.TextBox txtNombreActividad;
        private System.Windows.Forms.Button btnAltaSocio;
        private System.Windows.Forms.Button btnInscribirActividad;
        private System.Windows.Forms.Label lblIdSocio;
        private System.Windows.Forms.Label lblNombreSocio;
        private System.Windows.Forms.Label lblNombreActividad;

        /// <summary>
        /// Limpiar cualquier recurso siendo utilizado.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben ser eliminados; false en caso contrario.</param>
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
        /// Método requerido para el soporte del Diseñador - no modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdSocio = new System.Windows.Forms.TextBox();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.txtNombreActividad = new System.Windows.Forms.TextBox();
            this.btnAltaSocio = new System.Windows.Forms.Button();
            this.btnInscribirActividad = new System.Windows.Forms.Button();
            this.lblIdSocio = new System.Windows.Forms.Label();
            this.lblNombreSocio = new System.Windows.Forms.Label();
            this.lblNombreActividad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            // 
            // txtIdSocio
            // 
            this.txtIdSocio.Location = new System.Drawing.Point(130, 30);
            this.txtIdSocio.Name = "txtIdSocio";
            this.txtIdSocio.Size = new System.Drawing.Size(150, 20);
            this.txtIdSocio.TabIndex = 0;
            
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Location = new System.Drawing.Point(130, 70);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.Size = new System.Drawing.Size(150, 20);
            this.txtNombreSocio.TabIndex = 1;
            
            // 
            // txtNombreActividad
            // 
            this.txtNombreActividad.Location = new System.Drawing.Point(130, 110);
            this.txtNombreActividad.Name = "txtNombreActividad";
            this.txtNombreActividad.Size = new System.Drawing.Size(150, 20);
            this.txtNombreActividad.TabIndex = 2;
            
            // 
            // btnAltaSocio
            // 
            this.btnAltaSocio.Location = new System.Drawing.Point(50, 160);
            this.btnAltaSocio.Name = "btnAltaSocio";
            this.btnAltaSocio.Size = new System.Drawing.Size(100, 30);
            this.btnAltaSocio.TabIndex = 3;
            this.btnAltaSocio.Text = "Registrar Socio";
            this.btnAltaSocio.UseVisualStyleBackColor = true;
            this.btnAltaSocio.Click += new System.EventHandler(this.btnAltaSocio_Click);
            
            // 
            // btnInscribirActividad
            // 
            this.btnInscribirActividad.Location = new System.Drawing.Point(180, 160);
            this.btnInscribirActividad.Name = "btnInscribirActividad";
            this.btnInscribirActividad.Size = new System.Drawing.Size(100, 30);
            this.btnInscribirActividad.TabIndex = 4;
            this.btnInscribirActividad.Text = "Inscribir Actividad";
            this.btnInscribirActividad.UseVisualStyleBackColor = true;
            this.btnInscribirActividad.Click += new System.EventHandler(this.btnInscribirActividad_Click);

            // 
            // lblIdSocio
            // 
            this.lblIdSocio.AutoSize = true;
            this.lblIdSocio.Location = new System.Drawing.Point(50, 30);
            this.lblIdSocio.Name = "lblIdSocio";
            this.lblIdSocio.Size = new System.Drawing.Size(50, 13);
            this.lblIdSocio.TabIndex = 5;
            this.lblIdSocio.Text = "ID Socio:";

            // 
            // lblNombreSocio
            // 
            this.lblNombreSocio.AutoSize = true;
            this.lblNombreSocio.Location = new System.Drawing.Point(50, 70);
            this.lblNombreSocio.Name = "lblNombreSocio";
            this.lblNombreSocio.Size = new System.Drawing.Size(44, 13);
            this.lblNombreSocio.TabIndex = 6;
            this.lblNombreSocio.Text = "Nombre:";

            // 
            // lblNombreActividad
            // 
            this.lblNombreActividad.AutoSize = true;
            this.lblNombreActividad.Location = new System.Drawing.Point(50, 110);
            this.lblNombreActividad.Name = "lblNombreActividad";
            this.lblNombreActividad.Size = new System.Drawing.Size(74, 13);
            this.lblNombreActividad.TabIndex = 7;
            this.lblNombreActividad.Text = "Actividad:";

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.lblNombreActividad);
            this.Controls.Add(this.lblNombreSocio);
            this.Controls.Add(this.lblIdSocio);
            this.Controls.Add(this.btnInscribirActividad);
            this.Controls.Add(this.btnAltaSocio);
            this.Controls.Add(this.txtNombreActividad);
            this.Controls.Add(this.txtNombreSocio);
            this.Controls.Add(this.txtIdSocio);
            this.Name = "MainForm";
            this.Text = "Club Deportivo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}




/*
 * Created by SharpDevelop.
 * User: Estudiante
 * Date: 24/9/2024
 * Time: 20:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 *
namespace DSOO_TP1_ComX_GrupoX
{
	partial class MainForm
	{

////


// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "DSOO_TP1_ComX_GrupoX";
			this.Name = "MainForm";
		}
	}
}
*/