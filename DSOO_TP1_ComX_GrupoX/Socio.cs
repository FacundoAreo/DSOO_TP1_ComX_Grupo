/*
 * Materia : Desarrollo de Sistemas Orientado a Objetos 1º C
 * User: Estudiante Equipo 5
 * Sanchez, Facundo Areo , facundo.areo@dgmail.com
 * Briant Alcides Gauna, gauna.br@gmail.com
 * Esteban Tomás González. ebanban77@gmail.com
 * Poli Agostina Milena poliagostinamilena@gmail.com
 * link https://github.com/FacundoAreo/DSOO_TP1_ComX_Grupo
 * Date: 24/9/2024
 * Time: 20:08
 * DSOO_TP1_ComC_Grupo5_Sanchez_Poli_Gauna_Gonzalez_Ap
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DSOO_TP1_ComX_GrupoX
{
	/// <summary>
	/// Description of Socio.
	/// </summary>
	public class Socio
	{
		public int IdSocio { get; set; }
    public string Nombre { get; set; }
    public List<Actividad> ActividadesInscritas { get; set; }

    public Socio(int id, string nombre)
    {
        IdSocio = id;
        Nombre = nombre;
        ActividadesInscritas = new List<Actividad>();
    }

    // Este método permite al socio inscribirse en una nueva actividad.
    public bool InscribirEnActividad(Actividad actividad)
    {
        if (ActividadesInscritas.Count < 3)
        {
            ActividadesInscritas.Add(actividad);
            return true;
        }
        return false;
    }
	}
}
