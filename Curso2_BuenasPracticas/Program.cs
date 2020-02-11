using Curso2_BuenasPracticas.Factorys;
using Curso2_BuenasPracticas.Models;
using Curso2_BuenasPracticas.Services;
using Curso2_BuenasPracticas.Services.ConvertToEntity.Interfaces;
using Curso2_BuenasPracticas.Services.Interfaces;
using Curso2_BuenasPracticas.Utils;
using System;

namespace Curso2_BuenasPracticas
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicesFactory serviceFactory = new ServicesFactory();
            IConvertToEventEntity convert = serviceFactory.GetConvert("file");
            IMessageFormat formatMessage;
            ITimeFormat timeFormat;
            DateTime dateActual = DateTime.Now;
            foreach (EventEntity eventEntity in convert.ConvertToEventEntity())
            {
                formatMessage = serviceFactory.GetFormatMessage(
                    DateTimeUtilities.DateIsPreviousToToday(eventEntity.DateStart, dateActual));

                timeFormat = serviceFactory.GetTimeFormat(
                    DateTimeUtilities.GetTimeEnum(eventEntity.DateStart, dateActual));

                //se crea el mensaje.
                string message = formatMessage.CreateMessage(eventEntity, timeFormat);


                Console.WriteLine(message);
            }

        }
    }
}
