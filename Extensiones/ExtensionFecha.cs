using System;

namespace Extensiones
{
    public static class ExtensionFecha
    {
        /// <summary>
        /// metodo de extensión en la clase DateTime para que nos devuelva la hora actual formateada
        /// </summary>
        /// <param name="fecha">objeto datetime que devolverá la hora actual</param>
        /// <returns>hora actual formateada</returns>
        public static string HoraActualFormateada(this DateTime fecha)
        {
            return fecha.ToString("HH_mm_ss");
        }
    }
}
