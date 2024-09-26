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
using System.Windows.Forms;

namespace DSOO_TP1_ComX_GrupoX
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
