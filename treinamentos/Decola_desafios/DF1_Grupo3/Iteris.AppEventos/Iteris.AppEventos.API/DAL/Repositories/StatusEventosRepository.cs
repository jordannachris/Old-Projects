using Iteris.AppEventos.API.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.AppEventos.API.DAL.Repositories
{
    public class StatusEventosRepository
    {
        private readonly projeto_app_eventosContext _eventosContext;

        public StatusEventosRepository(projeto_app_eventosContext eventosContext)
        {
            _eventosContext = eventosContext;
        }

        public async Task<StatusEvento> PesquisaPorStatus(string Nome)
        {
            return await _eventosContext.StatusEventos.FindAsync(Nome);
        }
        public async Task<StatusEvento> EditarStatus(StatusEvento update)
        {
            _eventosContext.StatusEventos.Add(update).State = EntityState.Modified;
            await _eventosContext.SaveChangesAsync();
            return update;
        }
    }
}
