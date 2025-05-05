using System.ComponentModel.DataAnnotations;


namespace SistemaEventos.Domain.DTO
{
    public class ParticipacaoCreateRequest
    {
        public int IdEvento { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O login do participante deve ser obrigatório")]
        public string LoginParticipante { get; set; }
    }
}
