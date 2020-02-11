using Curso2_BuenasPracticas.Models;
using Curso2_BuenasPracticas.Services.ConvertToEntity.Interfaces;
using Curso2_BuenasPracticas.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Curso2_BuenasPracticas.Services.ConvertToEntity
{
    /// <summary>
    /// Clase que se encarga de convertir un archivo a una lista de <see cref="EventEntity"/>
    /// </summary>
    public class FileToEventEntity : IConvertToEventEntity
    {
        private readonly IFileReaderEvent _fileReaderEvent;
        private readonly char _fieldSeparator;
        private readonly char _recordSeparator;

        public FileToEventEntity(IFileReaderEvent fileReaderEvent,
                                 char fieldSeparator,
                                 char recordSeparator)
        {
            _fileReaderEvent = fileReaderEvent ?? throw new ArgumentNullException(nameof(fileReaderEvent));
            _fieldSeparator = fieldSeparator;
            _recordSeparator = recordSeparator;
        }


        /// <summary>
        /// Convierte el archivo a un alista de entidades.
        /// </summary>
        /// <returns></returns>
        public List<EventEntity> ConvertToEventEntity()
        {
            List<EventEntity> eventEntities = new List<EventEntity>();

            // lee el archivo   
            string events = _fileReaderEvent.ReadFile();

            string[] eventsArray = events.Split(_recordSeparator);
            foreach (string eventStirng in eventsArray)
            {
                if (LogicConvertionValid(eventStirng))
                {
                    string[] keyValueEvent = GetProperties(eventStirng);

                    eventEntities.Add(new EventEntity() { Title = keyValueEvent[0], DateStart = DateTime.Parse(keyValueEvent[1]) });
                }

            }

            return eventEntities;
        }

        private string[] GetProperties(string eventStirng)
        {
            return eventStirng.Split(_fieldSeparator);
        }

        private bool LogicConvertionValid(string eventString)
        {
            return GetProperties(eventString).Length == 2;
        }
    }
}
