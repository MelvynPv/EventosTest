using System;

namespace Curso2_BuenasPracticas.Models
{
    /// <summary>
    /// Interface de la entidad del evento.
    /// </summary>
    public interface IEventEntity
    {
        /// <summary>
        /// Titulo del evento.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Fecha en la que se realiza el evento.
        /// </summary>
        public DateTime DateStart { get; set; }
    }
}
