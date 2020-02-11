

using System;

namespace Curso2_BuenasPracticas.Services.Interfaces
{
    /// <summary>
    /// Me devuelve el formato de los tiempos en minutos.
    /// </summary>
    public interface ITimeFormat
    {
        /// <summary>
        /// Método que convierte la fecha indicada en algún formato.
        /// </summary>
        /// <param name="time">Fecha</param>
        /// <returns>Cadena con el formato deseado.</returns>
        string GetTimeFormat(TimeSpan time);
    }
}
