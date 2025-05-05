using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.AppEventos.API.Domain.DTO
{
    public class ParticipacaoNotaUpdateRequest
    {
        public int? Nota { get; set; }
        public string Comentario { get; set; }
    }
}
