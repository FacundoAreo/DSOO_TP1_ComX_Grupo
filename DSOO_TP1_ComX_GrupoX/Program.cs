/*
 * Materia : Desarrollo de Sistemas Orientado a Objetos 1º C
 * User: Estudiante Equipo 5 comision C
 * Sanchez, Facundo Areo , facundo.areo@dgmail.com
 * Briant, Alcides Gauna, gauna.br@gmail.com
 * González, Esteban Tomás. ebanban77@gmail.com
 * Poli, Agostina Milena poliagostinamilena@gmail.com
 * link https://github.com/FacundoAreo/DSOO_TP1_ComX_Grupo
 * Date: 24/9/2024
 * Time: 20:08
 * DSOO_TP1_ComC_Grupo5_Sanchez_Poli_Gauna_Gonzalez_Ap
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
