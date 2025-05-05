using Iteris.Eventos.API.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.DAL.Respositories
{
    public class CategoriasEventosRepository
    {
		private readonly projeto_app_eventosContext _eventoContext;

		public CategoriasEventosRepository(projeto_app_eventosContext eventosContext)
		{
			_eventoContext = eventosContext;
		}

		public async Task<CategoriaEvento> PesquisaPorId(int id)
		{
			return await _eventoContext.CategoriaEventos.FindAsync(id);
		}
	}
}
