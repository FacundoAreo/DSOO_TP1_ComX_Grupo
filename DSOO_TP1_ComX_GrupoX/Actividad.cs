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

namespace DSOO_TP1_ComX_GrupoX
{
	/// <summary>
	/// Description of Actividad.
	/// </summary>
	public class Actividad
	{
		 public int IdActividad { get; set; }
    public string NombreActividad { get; set; }
    public string HoraActividad { get; set; }
    public float PrecioActividad { get; set; }
    public int CuposDisponibles { get; set; }

    public Actividad(int id, string nombre, string hora, float precio, int cupos)
    {
        IdActividad = id;
        NombreActividad = nombre;
        HoraActividad = hora;
        PrecioActividad = precio;
        CuposDisponibles = cupos;
    }
	}
}
