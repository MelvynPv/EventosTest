using Curso2_BuenasPracticas.Services;
using Curso2_BuenasPracticas.Services.ConvertToEntity;
using Curso2_BuenasPracticas.Services.ConvertToEntity.Interfaces;
using Curso2_BuenasPracticas.Services.FormatMessage;
using Curso2_BuenasPracticas.Services.FormatTime;
using Curso2_BuenasPracticas.Services.Interfaces;
using Curso2_BuenasPracticas.Utils;
using System;

namespace Curso2_BuenasPracticas.Factorys
{
    /// <summary>
    /// Fabrica que retorna la creación de los servicios.
    /// </summary>
    public class ServicesFactory
    {
        private readonly FileReaderFromPath fileReaderFormPath  = new FileReaderFromPath();
        public IMessageFormat GetFormatMessage(bool isPass)
        {
            if (isPass)
            {
                return new FormatPass();
            }

            return new FormatFuture();
        }

        public ITimeFormat GetTimeFormat(TimeFormat timeFormat)
        {
            return timeFormat switch
            {
                TimeFormat.Minutos => new FormatTimeInMinutes(),
                TimeFormat.Horas => new FormatTimeInHours(),
                TimeFormat.Dias => new FormatTimeDays(),
                TimeFormat.Meses => new FormatTimeMounts(),
                _ => throw new ArgumentException("No se encentro la instancia del formato del mensaje"),
            };
        }

        public IConvertToEventEntity GetConvert(string type)
        {
            return type switch
            {
                "file" => new FileToEventEntity(fileReaderFormPath, ',', '\n'),
                _ => null,
            };
        }
    }
}
