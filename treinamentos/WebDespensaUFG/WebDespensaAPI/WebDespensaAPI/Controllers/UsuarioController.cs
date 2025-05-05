using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDespensaAPI.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDespensaAPI.Services;
using WebDespensaAPI.Domain.Entity;

namespace WebDespensaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
		private readonly UsuarioService usuarioService;

		public UsuarioController(UsuarioService usuarioService)
		{
			this.usuarioService = usuarioService;
		}

		[HttpGet]
		public IEnumerable<UsuarioResponse> Get()
		{
			return usuarioService.ListarTodos();
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var retorno = usuarioService.PesquisarPorId(id);

			if (retorno.Sucesso)
			{
				return Ok(retorno.ObjetoRetorno);
			}
			else
			{
				return NotFound(retorno);
			}
		}

        //[HttpGet("nome/{nomeParam}")]
        //public IActionResult GetByNome(string nomeParam)
        //{
        //    var retorno = usuarioService.PesquisarPorNome(nomeParam);

        //    if (retorno.Sucesso)
        //    {
        //        return Ok(retorno.ObjetoRetorno);
        //    }
        //    else
        //    {
        //        return NotFound(retorno);
        //    }
        //}


        //[HttpGet("email/{emailParam}")]
        //public IActionResult GetByEmail(string emailParam) 
        //{
        //    var retorno = usuarioService.PesquisarPorEmail(emailParam);

        //    if (retorno.Sucesso)
        //    {
        //        return Ok(retorno.ObjetoRetorno);
        //    }
        //    else
        //    {
        //        return NotFound(retorno);
        //    }
        //}


        //[HttpGet("senha/{senhaParam}")]
        //public IActionResult GetBySenha(string senhaParam)
        //{
        //    var retorno = usuarioService.PesquisarPorSenha(senhaParam);

        //    if (retorno.Sucesso)
        //    {
        //        return Ok(retorno.ObjetoRetorno);
        //    }
        //    else
        //    {
        //        return NotFound(retorno);
        //    }
        //}



        [HttpGet("login/{emailParam}/{senhaParam}")]
		public IActionResult GetByEmailSenha(string emailParam, string senhaParam) 
		{
			var retorno = usuarioService.PesquisarPorEmailSenha(emailParam, senhaParam);

			if (retorno.Sucesso)
			{
				return Ok(retorno.ObjetoRetorno);
			}
			else
			{
				return NotFound(retorno);
			}
		}



		[HttpPost]
		public IActionResult Post([FromBody] UsuarioCreateRequest postModel)
		{
			if (ModelState.IsValid)
			{
				var retorno = usuarioService.CadastrarNovo(postModel);
				if (!retorno.Sucesso)
					return BadRequest(retorno.Mensagem);
				else
					return Ok(retorno);
			}
			else
			{
				return BadRequest(ModelState);
			}

		}



		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] UsuarioUpdateRequest putModel)
		{
			if (ModelState.IsValid)
			{
				var retorno = usuarioService.Editar(id, putModel);
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
            var retorno = usuarioService.Deletar(id);
            if (!retorno.Sucesso)
                return BadRequest(retorno.Mensagem);
            return Ok();
        }

    }
}
