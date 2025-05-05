using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.Domain.DTO
{
    public class EventoParticipacaoUpdateRequest
    {
        [Required]
        public int IdEvento { get; set; }

        [Required]
        public string LoginParticipante { get; set; }

        public int? Nota { get; set; }

        public string Comentario { get; set; }
    }
}
