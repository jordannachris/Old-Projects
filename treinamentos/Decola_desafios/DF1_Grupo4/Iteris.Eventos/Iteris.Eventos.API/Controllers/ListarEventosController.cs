using Iteris.Eventos.API.Domain.DTO;
using Iteris.Eventos.API.Domain.Entity;
using Iteris.Eventos.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListarEventosController : ControllerBase
    {
        private readonly EventosService _service;

        public ListarEventosController(EventosService service)
        {
            this._service = service;
        }

        [HttpGet]
        public IEnumerable<EventoResponse> Get()
        {
            return _service.ListarTodos();
        }

        [HttpGet("evento/{categoria}")]
        public IEnumerable<EventoResponse> ListarEventoCategoria(int categoria)
        {
            var retorno = _service.ListarPorCategoria(categoria);
            return retorno;
        }

        [HttpGet("pesquisar/{dataEvento}")]
        public IEnumerable<EventoResponse> ListarEventoData(DateTime dataEvento)
        {
            var retorno = _service.ListarPorData(dataEvento);
            return retorno;
        }
    }
}
