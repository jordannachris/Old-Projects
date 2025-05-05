using SistemaEventos.Domain.Entity;
using System;

namespace SistemaEventos.Domain.DTO
{
    public class EventoResponse
	{ 
			public EventoResponse(Evento evento)
			{
            IdEvento = evento.IdEvento;
			Nome = evento.Nome;
			DataHoraInicio = evento.DataHoraInicio;
			DataHoraFim = evento.DataHoraFim;
			Local = evento.Local;
			Descricao = evento.Descricao;
			LimiteVagas = evento.LimiteVagas;
            Categoria = evento.IdCategoriaEvento;
			EventoStatus = evento.IdEventoStatus;
			}

        public int IdEvento { get; set; }
		public string Nome { get; set; }
		public DateTime DataHoraInicio { get; set; }
		public DateTime DataHoraFim { get; set; }
		public string Local { get; set; }
		public string Descricao { get; set; }
		public int LimiteVagas { get; set; }
        public int Categoria { get; set; }
		public int EventoStatus { get; set; }
	}
}
