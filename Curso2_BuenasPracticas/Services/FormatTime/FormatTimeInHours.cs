using Curso2_BuenasPracticas.Services.Interfaces;
using System;

namespace Curso2_BuenasPracticas.Services.FormatTime
{
    public class FormatTimeInHours : ITimeFormat
    {
        public string GetTimeFormat(TimeSpan time)
        {
            int hours = (int)Math.Ceiling(Math.Abs(time.TotalHours));
            return string.Format("{0} hora(s)", hours);
        }
    }
}
