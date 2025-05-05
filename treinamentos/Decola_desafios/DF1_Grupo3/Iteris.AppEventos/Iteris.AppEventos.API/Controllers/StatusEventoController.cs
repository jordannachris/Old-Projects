using Iteris.AppEventos.API.Domain.DTO;
using Iteris.AppEventos.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.AppEventos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusEventoController : ControllerBase
    {
		private readonly StatusEventosService statusEventoService;

		public StatusEventoController(StatusEventosService statusEventoService)
		{
			this.statusEventoService = statusEventoService;
		}
		[HttpGet("{id}/StatusEvento")]
		public IEnumerable<StatusEventoResponse> Get()
		{
			return statusEventoService.AllList();
		}
		/*[HttpPut("{id}/StatusEvento")]
		public IActionResult Put(int id, [FromBody] StatusEventoUpdateRequest putModel)
		{
			//Validação modelo de entrada
			if (ModelState.IsValid)
			{
				var retorno = statusEventoService.EditarStatus(id, putModel);
				if (!retorno.Sucesso)
					return BadRequest(retorno.Mensagem);
				return Ok(retorno.ObjetoRetorno);
			}
			else
			{
				return BadRequest(ModelState);
			}

		}*/
	}
}
