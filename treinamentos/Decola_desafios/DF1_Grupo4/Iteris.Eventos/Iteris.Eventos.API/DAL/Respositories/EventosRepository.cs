using Iteris.Eventos.API.Domain.DTO;
using Iteris.Eventos.API.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.DAL.Respositories
{
	public class EventosRepository
	{
		private readonly projeto_app_eventosContext _eventoContext;

		public EventosRepository(projeto_app_eventosContext eventosContext)
		{
			_eventoContext = eventosContext;
		}

		//Async é a forma de usar programação assincrona
		//Isso otimiza o uso do processador
		public async Task<Evento> PesquisaPorId(int? id)
		{
			// select top 1 * from Evento
			return await _eventoContext.Eventos.FindAsync(id);
		}

		public async Task<Evento> Cadastrar(Evento novo)
		{
			_eventoContext.Eventos.Add(novo);
			await _eventoContext.SaveChangesAsync(); // Todo o Entiy está preparado para isso
			return novo;
		}

		public IEnumerable<EventoResponse> ListarTodos()
		{
			var retornodobanco = _eventoContext.Eventos.ToList();
			IEnumerable<EventoResponse> lista = retornodobanco.Select(x => new EventoResponse(x));
			return lista;
		}

		public IEnumerable<EventoResponse> ListarEventoCategoria(int categoria)
		{
			var retornodobanco = _eventoContext.Eventos.Where(x => x.IdCategoriaEvento == categoria).ToList();
			IEnumerable<EventoResponse> lista = retornodobanco.Select(x => new EventoResponse(x));
			return lista;
		}

        public IEnumerable<EventoResponse> ListarEventoData(DateTime dataEvento)
        {
            var retornodobanco = _eventoContext.Eventos.Where(x => x.DataHoraInicio.Date == dataEvento).ToList();
            IEnumerable<EventoResponse> lista = retornodobanco.Select(x => new EventoResponse(x));
            return lista;
        }
    }


}
