using Iteris.Eventos.API.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.Domain.DTO
{
    public class EventoResponse
    {

        public EventoResponse(Evento evento)
        {
            this.IdEvento = evento.IdEvento;
            this.IdEventoStatus = evento.IdEventoStatus;
            this.IdCategoriaEvento = evento.IdCategoriaEvento;
            this.Nome = evento.Nome;
            this.DataHoraInicio = evento.DataHoraInicio;
            this.DataHoraFim = evento.DataHoraFim;
            this.Local = evento.Local;
            this.Descricao = evento.Descricao;
            this.LimiteVagas = evento.LimiteVagas;
        }
        public int? IdEvento { get; set; }
        public int IdEventoStatus { get; set; }
        public int IdCategoriaEvento { get; set; }
        public string Nome { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public int LimiteVagas { get; set; }
    }
}
