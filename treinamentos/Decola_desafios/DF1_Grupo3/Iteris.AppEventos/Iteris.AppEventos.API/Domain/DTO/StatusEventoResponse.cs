using Iteris.AppEventos.API.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.AppEventos.API.Domain.DTO
{
    public class StatusEventoResponse
    {
		public StatusEventoResponse(StatusEvento statusevento)
		{
			IdEventoStatus = statusevento.IdEventoStatus;
			NomeStatus = statusevento.NomeStatus;

			if (statusevento.Eventos != null && statusevento.Eventos.Any())
			{

				Eventos = new List<EventoResponse>();
				Eventos.AddRange(statusevento.Eventos.Select(x => new EventoResponse(x)));
			}
		}
		public int IdEventoStatus { get; set; }
		public string NomeStatus { get; set; }
		public List<EventoResponse> Eventos { get; set; }
	}
}
