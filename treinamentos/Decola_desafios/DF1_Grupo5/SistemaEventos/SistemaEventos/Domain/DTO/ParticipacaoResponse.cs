using SistemaEventos.Domain.Entity;

namespace SistemaEventos.Domain.DTO
{
    public class ParticipacaoResponse
    {
        public ParticipacaoResponse(Participacao participacao)
        {

            IdParticipacao = participacao.IdParticipacao;
            IdEvento = participacao.IdEvento;
            LoginParticipante = participacao.LoginParticipante;
            FlagPresente = participacao.FlagPresente;
            Nota = participacao.Nota;
            Comentario = participacao.Comentario;
        }

        public int IdParticipacao { get; set; }
        public int IdEvento { get; set; }
        public string LoginParticipante { get; set; }
        public bool FlagPresente { get; set; }
        public int? Nota { get; set; }
        public string Comentario { get; set; }
    }
}

