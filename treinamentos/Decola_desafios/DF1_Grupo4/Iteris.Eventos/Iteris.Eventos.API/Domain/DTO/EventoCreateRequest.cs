using Iteris.Eventos.API.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.Domain.DTO
{
    public class EventoCreateRequest
    {
        [Required]
        public int IdCategoriaEvento { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome obrigatório")]
        [StringLength(255)]
        public string Nome { get; set; }
        [Required]
        public DateTime DataHoraInicio { get; set; }
        [Required]
        public DateTime DataHoraFim { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Local obrigatório")]
        [StringLength(255)]
        public string Local { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Descrição obrigatório")]
        [StringLength(255)]
        public string Descricao { get; set; }
        [Required]
        public int? LimiteDeVagas { get; set; }
    }
}
