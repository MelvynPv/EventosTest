using System;

namespace Curso2_BuenasPracticas.Utils
{
    /// <summary>
    /// Responsabilidad de facilidades con el manejo de las fechas.
    /// </summary>
    public static class DateTimeUtilities
    {
        /// <summary>
        /// Obtiene el enumerador adecuado a la diferencia la lejanía de las fechas (con respecto a la actual).
        /// </summary>
        /// <param name="dateEvent">Fecha principal.</param>
        /// <returns>Enumerador que indica que tan lejana están las dos fechas</returns>
        public static TimeFormat GetTimeEnum(DateTime dateEvent, DateTime dateActual)
        {

            var time = dateEvent.Subtract(dateActual);

            if (Math.Abs(time.TotalMinutes) < 60)
            {
                return TimeFormat.Minutos;
            }
            else if (Math.Abs(time.TotalHours) < 24)
            {
                return TimeFormat.Horas;
            }
            else if (Math.Abs(time.TotalDays) < 30)
            {
                return TimeFormat.Dias;
            }

            return TimeFormat.Meses;
        }

        /// <summary>
        /// Determina si una fecha es anterior a la fecha actual.
        /// </summary>
        /// <param name="dateStart">Fecha deseada.</param>
        /// <returns>Indica si la fecha es anterior.</returns>
        public static bool DateIsPreviousToToday(DateTime dateStart, DateTime dateActual) 
        {
            return dateStart.CompareTo(dateActual) < 0;
        }


        public static TimeSpan GetTimeDifferencDateToDateActual(DateTime dateStart, DateTime dateActual) 
        {
            return dateStart.Subtract(dateActual);
        }
    }
}
