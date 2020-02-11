

using Curso2_BuenasPracticas.Services.Interfaces;
using System;

namespace Curso2_BuenasPracticas.Services.FormatTime
{
    public class FormatTimeInMinutes : ITimeFormat
    {
        public string GetTimeFormat(TimeSpan time)
        {
            int minutes = (int)Math.Ceiling(time.TotalMinutes);

            return string.Format("{0} minutos", minutes);
        }
    }
}
