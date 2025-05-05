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
    public class AdministrarEventosController : ControllerBase
    {

        private readonly EventosService _service;
		private readonly ParticipacoesService _participacoes;

        public AdministrarEventosController(EventosService service, ParticipacoesService participacoesService)
        {
            _service = service;
			_participacoes = participacoesService;

		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var retorno = await _service.PesquisaPorId(id);

			if (retorno.Sucesso)
			{
				return Ok(retorno.ObjetoRetorno);
			}
			else
			{
				return NotFound(retorno);
			}
		}

		[HttpGet("EventosParticipantes/{id}")] 
		public IActionResult ParticipantePorEvento(int id) { 
			return Ok(_participacoes.ParticipantePorEvento(id)); 
		}


		[HttpPut("{id}/Prioridade")]
		// FromBody para indicar de o corpo da requisição deve ser mapeado para o modelo
		public IActionResult Put(int id, [FromBody] EventoUpdateRequest putModel)
		{
			//Validação modelo de entrada
			if (ModelState.IsValid)
			{
				var retorno = _service.EditarStatus(id, putModel);
				if (!retorno.Sucesso)
					return BadRequest(retorno.Mensagem);
				return Ok(retorno.ObjetoRetorno);
			}
			else
			{
				return BadRequest(ModelState);
			}

		}

		[HttpPut("{id}/EditarFlagDoParticipante")]
		public async Task<IActionResult> PutFLag(int id, [FromBody] ParticipacaoFlagPresenteUpdateRequest putModel)
		{
			//Validação modelo de entrada
			if (ModelState.IsValid)
			{
				var retorno = await _participacoes.EditarFlag(id, putModel);
				if (!retorno.Sucesso)
					return BadRequest(retorno.Mensagem);
				return Ok(retorno.ObjetoRetorno);
			}
			else
			{
				return BadRequest(ModelState);
			}

		}
	}
}
