using Iteris.Eventos.API.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.Domain.DTO
{
    public class ParticipacaoResponse
    {
        public ParticipacaoResponse(Participacao participacao)
        {
            this.IdParticipacao = participacao.IdParticipacao;
            this.IdEvento = participacao.IdEvento;
            this.LoginParticipante = participacao.LoginParticipante;
            this.FlagPresente = participacao.FlagPresente;
            this.Nota = participacao.Nota;
            this.Comentario = participacao.Comentario;
        }

       

        public int IdParticipacao { get; set; }
        public int? IdEvento { get; set; }
        public string LoginParticipante { get; set; }
        public bool FlagPresente { get; set; }
        public int? Nota { get; set; }
        public string Comentario { get; set; }
 
    }
}
