using Iteris.Eventos.API.Domain.DTO;
using Iteris.Eventos.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private readonly EventosService _service;

        public EventosController(EventosService service)
        {
            _service = service;
        }

        [HttpPost]
		public async Task<IActionResult> Post([FromBody] EventoCreateRequest postModel)
		{
			if (ModelState.IsValid)
			{
				var retorno = await _service.Cadastrar(postModel);
				if (!retorno.Sucesso)
					return BadRequest(retorno);
				else
					return Ok(retorno.ObjetoRetorno);
			}
			else
			{
				return BadRequest(ModelState);
			}
		}
	}
}
