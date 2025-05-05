using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDespensaAPI.Domain.DTO;
using WebDespensaAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDespensaAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProdutoController : ControllerBase
	{
		private readonly ProdutoService produtoService;
		public ProdutoController(ProdutoService produtoService)
		{
			this.produtoService = produtoService;
		}



		[HttpGet]
		public IEnumerable<ProdutoResponse> Get()
		{
			return produtoService.ListarTodos();
		}



		[HttpPost]
		public IActionResult Post([FromBody] ProdutoCreateRequest postModel)
		{
			if (ModelState.IsValid)
			{
				var retorno = produtoService.CadastrarNovo(postModel);
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



		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] ProdutoUpdateRequest putModel)
		{
			if (ModelState.IsValid)
			{
				var retorno = produtoService.Editar(id, putModel);
				if (!retorno.Sucesso)
					return BadRequest(retorno.Mensagem);
				return Ok(retorno.ObjetoRetorno);
			}
			else
			{
				return BadRequest(ModelState);
			}

		}



		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var retorno = produtoService.Deletar(id);
			if (!retorno.Sucesso)
				return BadRequest(retorno.Mensagem);
			return Ok();
		}

	}
}
