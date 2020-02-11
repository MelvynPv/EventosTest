using Curso2_BuenasPracticas.Models;
using Curso2_BuenasPracticas.Services.Interfaces;
using Curso2_BuenasPracticas.Utils;
using System;

namespace Curso2_BuenasPracticas.Services.FormatMessage
{
    public class FormatFuture : IMessageFormat
    {
        public string CreateMessage(IEventEntity eventEntity, ITimeFormat timeFormat)
        {
            TimeSpan timeDifference = DateTimeUtilities.GetTimeDifferencDateToDateActual(eventEntity.DateStart, new DateTime());

            return string.Format("{0} ocurrirá dentro de {1}", eventEntity.Title, timeFormat.GetTimeFormat(timeDifference));
        }
    }
}
