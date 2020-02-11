using Curso2_BuenasPracticas.Models;
using System.Collections.Generic;

namespace Curso2_BuenasPracticas.Services.ConvertToEntity.Interfaces
{
    public interface IConvertToEventEntity
    {
        /// <summary>
        /// Convierte el tipo de archivo a 
        /// </summary>
        /// <returns></returns>
        List<EventEntity> ConvertToEventEntity();
    }
}
