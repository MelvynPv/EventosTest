using Curso2_BuenasPracticas.Services.Interfaces;
using System;

namespace Curso2_BuenasPracticas.Services.FormatTime
{
    public class FormatTimeDays : ITimeFormat
    {
        public string GetTimeFormat(TimeSpan time)
        {
            int days = (int)Math.Ceiling(Math.Abs(time.TotalDays));
            return string.Format("{0} Dia(s)", days);
        }
    }
}
