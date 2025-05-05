using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.Domain.DTO
{
    public class ParticipacaoAvaliacaoUpdateRequest
    {
        [Required]
        public int IdParticipacao { get; set; }
        [Required]
        public int? Nota { get; set; }
        public string Comentario { get; set; }
    }
}
