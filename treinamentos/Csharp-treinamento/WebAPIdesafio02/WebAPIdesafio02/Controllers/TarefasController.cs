using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIdesafio02.Domain.DTO;
using WebAPIdesafio02.Services;
using WebAPIdesafio02.Domain.Entity;


namespace WebAPIdesafio02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly TarefasService tarefasService;

        public TarefasController(TarefasService tarefasService)
        {
            this.tarefasService = tarefasService;
        }


        //Get para listar todas as tarefas
        [HttpGet]
        public IEnumerable<Tarefa> Get()
        {
            return tarefasService.ListarTodos();
        }


        //Get para obter somente uma tarefa por Id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var retorno = tarefasService.PesquisarPorId(id);

            if (retorno.Sucesso)
            {
                return Ok(retorno.ObjetoRetorno);
            }
            else
            {
                return NotFound(retorno.Mensagem);
            }
        }



        //Post para criação ( deve receber somente Título, Descrição e Prioridade)

        [HttpPost]
        // FromBody para indicar de o corpo da requisição deve ser mapeado para o modelo
        public IActionResult Post([FromBody] TarefaCreateRequest postModel)
        {
            //Validação modelo de entrada
            if (ModelState.IsValid)
            {
                var retorno = tarefasService.CadastrarNovo(postModel);
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
  

        [HttpPut("{id}/status")] 
        // FromBody para indicar de o corpo da requisição deve ser mapeado para o modelo
        public IActionResult Put(int id, [FromBody] TarefaUpdateRequestStatus putModel)
        {
            //Validação modelo de entrada
            if (ModelState.IsValid)
            {
                var retorno = tarefasService.atualizarStatus(id, putModel);
                if (!retorno.Sucesso)
                    return BadRequest(retorno.Mensagem);
                return Ok(retorno.ObjetoRetorno);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }

        [HttpPut("{id}/prioridade")]
        // FromBody para indicar de o corpo da requisição deve ser mapeado para o modelo
        public IActionResult Put(int id, [FromBody] TarefaUpdateRequestPrioridade putModel)
        {
            //Validação modelo de entrada
            if (ModelState.IsValid)
            {
                var retorno = tarefasService.atualizarPrioridade(id, putModel);
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
            var retorno = tarefasService.Deletar(id);
            if (!retorno.Sucesso)
                return BadRequest(retorno.Mensagem);
            return Ok();

        }


    }
}
