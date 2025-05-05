using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.Domain.DTO
{
    public class ParticipacaoFlagPresenteUpdateRequest
    {
        [Required]
        public int IdParticipacao { get; set; }
        [Required]
        public int? IdEvento { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool FlagPresente { get; set; }
    }
}
