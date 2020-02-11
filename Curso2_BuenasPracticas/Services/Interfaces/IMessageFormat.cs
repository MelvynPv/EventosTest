using Curso2_BuenasPracticas.Models;
using Curso2_BuenasPracticas.Services.Interfaces;

namespace Curso2_BuenasPracticas.Services
{
    /// <summary>
    /// Es la interfaz que decide el mensaje que se debe desplegar en la pantalla
    /// </summary>
    public interface IMessageFormat
    {
        /// <summary>
        /// Mensaje que se  mostrara en pantalla.
        /// </summary>
        /// <param name="eventEntity"></param>
        /// <param name="timeFormat"></param>
        /// <returns></returns>
        string CreateMessage(IEventEntity eventEntity, ITimeFormat timeFormat);
    }
}
