using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEventos.Domain.DTO
{
    public class ParticipacaoUpdateRequest
    {
        public int? Nota { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage ="O comentário é obrigatório!")]
        public string Comentario { get; set; }
    }
}
