using System.ComponentModel.DataAnnotations;

namespace SistemaEventos.Domain.DTO
{
    public class EventoUpdateRequest
    {
        [Required]
        public int? EventoStatus { get; set; }
    }
}
