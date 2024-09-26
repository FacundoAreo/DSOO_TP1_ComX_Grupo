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
	/// Description of ClubDeportivo.
	/// </summary>
	public class ClubDeportivo
	{
		private List<Socio> socios = new List<Socio>();
    private List<Actividad> actividades = new List<Actividad>();

    // Método que da de alta a un socio en la colección del club.
    public string AltaSocio(int id, string nombre)
    {
        // Verifica si el socio ya está registrado.
        if (socios.Any(s => s.IdSocio == id))
        {
            return "SOCIO YA REGISTRADO";
        }

        // Agrega al nuevo socio.
        socios.Add(new Socio(id, nombre));
        return "SOCIO REGISTRADO CON ÉXITO";
    }

    // Método que inscribe al socio en una actividad específica.
    public string InscribirActividad(string nombreActividad, int idSocio)
    {
        // Busca la actividad por su nombre.
        Actividad actividad = actividades.FirstOrDefault(a => a.NombreActividad == nombreActividad);

        if (actividad == null)
        {
            return "ACTIVIDAD INEXISTENTE";
        }

        // Busca el socio por su ID.
        Socio socio = socios.FirstOrDefault(s => s.IdSocio == idSocio);

        if (socio == null)
        {
            return "SOCIO INEXISTENTE";
        }

        // Verifica si el socio ya está inscrito en tres actividades.
        if (socio.ActividadesInscritas.Count >= 3)
        {
            return "TOPE DE ACTIVIDADES ALCANZADO";
        }

        // Verifica si hay cupos disponibles en la actividad.
        if (actividad.CuposDisponibles <= 0)
        {
            return "NO HAY CUPOS DISPONIBLES";
        }

        // Inscribe al socio en la actividad y reduce el número de cupos disponibles.
        if (socio.InscribirEnActividad(actividad))
        {
            actividad.CuposDisponibles--;
            return "INSCRIPCIÓN EXITOSA";
        }
        else
        {
            return "INSCRIPCIÓN FALLIDA";
        }
    }

    // Agregar actividad al club
    public void AgregarActividad(Actividad actividad)
    {
        actividades.Add(actividad);
    }
	}
}
