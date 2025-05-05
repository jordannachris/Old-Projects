using Iteris.AppEventos.API.DAL;
using Iteris.AppEventos.API.DAL.Repositories;
using Iteris.AppEventos.API.Domain.DTO;
using Iteris.AppEventos.API.Domain.Entity;
using Iteris.AppEventos.API.Services.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.AppEventos.API.Services
{
    public class CategoriasServices
    {
        private readonly projeto_app_eventosContext _eventosContext;
        //private readonly StatusEventosRepository _statusEventosRepository;

        public CategoriasServices(projeto_app_eventosContext eventosContext)
        {
            _eventosContext = eventosContext;
        }
        public IEnumerable<CategoriaResponse> ListarTodos()
        {
            
            var retornoDoBanco = _eventosContext.CategoriaEventos.Include(x => x.Eventos).ToList();

            
            IEnumerable<CategoriaResponse> lista = retornoDoBanco.Select(x => new CategoriaResponse(x));

            return lista;
        }
    }
}