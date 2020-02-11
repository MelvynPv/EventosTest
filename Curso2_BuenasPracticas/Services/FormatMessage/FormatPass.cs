using Curso2_BuenasPracticas.Models;
using Curso2_BuenasPracticas.Services.Interfaces;
using Curso2_BuenasPracticas.Utils;
using System;

namespace Curso2_BuenasPracticas.Services.FormatMessage
{
    /// <summary>
    /// Servicios que contiene el evento.
    /// </summary>
    public class FormatPass : IMessageFormat
    {
        /// <summary>
        /// Si la fecha del evento ya paso lo indica y si no ha pasado también.
        /// </summary>
        /// <param name="eventEntity">Evento</param>
        /// <returns></returns>
        public string CreateMessage(IEventEntity eventEntity, ITimeFormat timeFormat)
        {
            TimeSpan timeDifference = DateTimeUtilities.GetTimeDifferencDateToDateActual(eventEntity.DateStart, new DateTime());

            return string.Format("{0} ocurrió hace {1}", eventEntity.Title, timeFormat.GetTimeFormat(timeDifference));

        }
    }
}
