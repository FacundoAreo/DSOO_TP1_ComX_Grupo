/*
 * User: Estudiante Equipo 5
 * Sanchez, Facundo Areo , facundo.areo@dgmail.com
 * Briant Alcides Gauna, gauna.br@gmail.com
 * Esteban Tomás González. ebanban77@gmail.com
 * Agostina Milena poliagostinamilena@gmail.com
 * link https://github.com/FacundoAreo/DSOO_TP1_ComX_Grupo
 * Date: 24/9/2024
 * Time: 20:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DSOO_TP1_ComX_GrupoX
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		 private ClubDeportivo clubDeportivo = new ClubDeportivo();

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			 InitializeComponent();

        // Inicialización de ejemplo de actividades del club
        clubDeportivo.AgregarActividad(new Actividad(1, "Fútbol", "10:00 AM", 500, 20));
        clubDeportivo.AgregarActividad(new Actividad(2, "Natación", "3:00 PM", 300, 15));
        clubDeportivo.AgregarActividad(new Actividad(3, "Tenis", "5:00 PM", 400, 10));
  
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		// Botón para dar de alta a un socio
    private void btnAltaSocio_Click(object sender, EventArgs e)
    {
        int idSocio = int.Parse(txtIdSocio.Text);
        string nombre = txtNombreSocio.Text;

        string resultado = clubDeportivo.AltaSocio(idSocio, nombre);
        MessageBox.Show(resultado);
    }

    // Botón para inscribir un socio a una actividad
    private void btnInscribirActividad_Click(object sender, EventArgs e)
    {
        int idSocio = int.Parse(txtIdSocio.Text);
        string nombreActividad = txtNombreActividad.Text;

        string resultado = clubDeportivo.InscribirActividad(nombreActividad, idSocio);
        MessageBox.Show(resultado);
    }
	}
}
