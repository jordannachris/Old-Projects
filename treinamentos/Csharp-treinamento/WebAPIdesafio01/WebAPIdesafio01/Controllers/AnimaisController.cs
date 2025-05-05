using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIdesafio01.Domain.DTO;
using WebAPIdesafio01.Services;
using WebAPIdesafio01.Domain.Entity;

namespace WebAPIdesafio01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {

        private readonly AnimalService animalService;

        public AnimaisController(AnimalService animalService)
        {
            this.animalService = animalService;
        }



        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return animalService.ListarTodos();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var retorno = animalService.PesquisarPorId(id);

            if (retorno.Sucesso)
            {
                return Ok(retorno.ObjetoRetorno);
            }
            else
            {
                return NotFound(retorno.Mensagem);
            }
        }


        [HttpGet("nome/{nomeParam}")]
        public IActionResult GetByNome(string nomeParam) // nome do parametro deve ser o mesmo do {}
        {
            var retorno = animalService.PesquisarPorNome(nomeParam);

            if (retorno.Sucesso)
            {
                return Ok(retorno.ObjetoRetorno);
            }
            else
            {
                return NotFound(retorno.Mensagem);
            }
        }



        [HttpPost]
        // FromBody para indicar de o corpo da requisição deve ser mapeado para o modelo
        public IActionResult Post([FromBody] AnimalCreateRequest postModel)
        {
            //Validação modelo de entrada
            if (ModelState.IsValid)
            {
                var retorno = animalService.CadastrarNovo(postModel);

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
		// FromBody para indicar de o corpo da requisição deve ser mapeado para o modelo
		public IActionResult Put(int id, [FromBody] AnimalUpdateRequest putModel)
		{
			//Validação modelo de entrada
			if (ModelState.IsValid)
			{
				var retorno = animalService.Editar(id, putModel);
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
		// FromBody para indicar de o corpo da requisição deve ser mapeado para o modelo
		public IActionResult Delete(int id)
		{
			//Validação modelo de entrada
			var retorno = animalService.Deletar(id);
			if (!retorno.Sucesso)
				return BadRequest(retorno.Mensagem);
			return Ok();

		}


    }
}
