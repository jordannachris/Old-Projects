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
	public class ParticipacoesController : ControllerBase
	{
		private readonly ParticipacoesService _participacoesService;

		public ParticipacoesController(ParticipacoesService participacoesService)
		{
			_participacoesService = participacoesService;
		}


		/*
		[HttpGet]
		public async Task<IActionResult> Get(int index, int qtd)
		{
			var retorno = await _service.Pesquisar(index, qtd);

			if (retorno.Sucesso)
			{
				return Ok(retorno.ObjetoRetorno);
			}
			else
			{
				return BadRequest(retorno);
			}
		}
		*/

		/*
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
		*/


		[HttpPost]
		// FromBody para indicar de o corpo da requisição deve ser mapeado para o modelo
		public async Task<IActionResult> Post([FromBody] ParticipacaoCreateRequest postModel)
		{
			//Validação modelo de entrada
			if (ModelState.IsValid)
			{
				var retorno = await _participacoesService.CadastrarParticipacao(postModel);
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


		[HttpPut("{id}/PresencaParticipante")]
		// FromBody para indicar de o corpo da requisição deve ser mapeado para o modelo
		public IActionResult Put(int id, [FromBody] ParticipacaoPresencaUpdateRequest putModel)
		{
			//Validação modelo de entrada
			if (ModelState.IsValid)
			{
				var retorno = _participacoesService.AtualizarPresenca(id, putModel);
				if (!retorno.Sucesso)
					return BadRequest(retorno.Mensagem);
				return Ok(retorno.ObjetoRetorno);
			}
			else
			{
				return BadRequest(ModelState);
			}

		}




		[HttpPut("{id}/ComentarioParticipante")]
		// FromBody para indicar de o corpo da requisição deve ser mapeado para o modelo
		public IActionResult Put(int id, [FromBody] ParticipacaoNotaUpdateRequest putModel)
		{
			//Validação modelo de entrada
			if (ModelState.IsValid)
			{
				var retorno = _participacoesService.AtualizarNotaComentario(id, putModel);
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
