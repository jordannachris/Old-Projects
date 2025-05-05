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
    public class ParticipacoesController : ControllerBase
    {
		private readonly ParticipacoesService _service;

        public ParticipacoesController(ParticipacoesService service)
        {
			_service = service;
		}

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ParticipacaoCreateRequest postModel)
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

		[HttpPut("DetalharEvento/{id}")]
		public async Task<IActionResult> Put(int id, [FromBody] ParticipacaoAvaliacaoUpdateRequest postModel)
        {
            if (ModelState.IsValid)
            {
                var retorno = await _service.DetalharEvento(id, postModel);
                if (!retorno.Sucesso)
                    return BadRequest(retorno.Mensagem);
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
