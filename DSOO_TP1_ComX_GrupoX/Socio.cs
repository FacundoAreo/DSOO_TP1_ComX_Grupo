/*
 * Created by SharpDevelop.
 * User: Estudiante
 * Date: 24/9/2024
 * Time: 20:11
 * 
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
