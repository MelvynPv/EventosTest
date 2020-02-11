using System;
using Curso2_BuenasPracticas.Utils;

namespace Curso2_BuenasPracticas.Models
{
    /// <summary>
    /// Entidad que almacena la información de un evento.
    /// </summary>
    public class EventEntity: IEventEntity
    {
        /// <summary>
        /// Titulo del evento.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Fecha en la que se realiza el evento.
        /// </summary>
        public DateTime DateStart {get; set;}
    }
}
