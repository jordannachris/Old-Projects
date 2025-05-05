using Iteris.AppEventos.API.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.AppEventos.API.DAL.Repositories
{
    public class CategoriasEventosRepository
    {
        private readonly projeto_app_eventosContext _eventosContext;

        public CategoriasEventosRepository(projeto_app_eventosContext eventosContext)
        {
            _eventosContext = eventosContext;

        }

        public async Task<CategoriaEvento> PesquisarPorCategoria(string categoria)
        {
            return await _eventosContext.CategoriaEventos.FindAsync(categoria);
        }

    }
}
