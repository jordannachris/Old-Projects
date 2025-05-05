using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.Domain.DTO
{
    public class ParticipacaoCreateRequest
    {
        [Required]
        public int? IdEvento { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Login Obrigatório")]
        [StringLength(255)]
        public string LoginParticipante { get; set; }
    }
}
