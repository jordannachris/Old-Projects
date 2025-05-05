using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using SistemaEventos.Services;
using SistemaEventos.Domain.DTO;

namespace SistemaEventos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private readonly EventoService eventoService;

        public EventosController(EventoService eventoService)
        {
            this.eventoService = eventoService;
        }

        [HttpGet("disponiveis")]
        public IEnumerable<EventoResponse> Get()
        {
            return eventoService.ListarTodosDisponiveis();
        }


        [HttpGet("{id}/categoria")]

        public IActionResult GetByCat(int id)
        {
            return Ok(eventoService.PesquisarPorCategoria(id));
        }


        [HttpGet("data/{data}")]

        public IActionResult GetByData(DateTime data)
        {
            return Ok(eventoService.PesquisarPorData(data.Date));
        }

        [HttpPost]
        public IActionResult Post([FromBody] EventoCreateRequest postModel)
        {
            if (ModelState.IsValid)
            {
                var retorno = eventoService.CadastrarNovo(postModel);
                if (!retorno.Sucesso)
                {
                    return BadRequest(retorno.Mensagem);
                }
                else
                {
                    return Ok(retorno);
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [HttpPut("{id}/iniciar")]
        public IActionResult Iniciar(int id)
        {
            if (ModelState.IsValid)
            {
                var retorno = eventoService.IniciarEvento(id);
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
        [HttpPut("{id}/concluir")]
        public IActionResult Concluir(int id)
        {
            if (ModelState.IsValid)
            {
                var retorno = eventoService.ConcluirEvento(id);
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
        [HttpPut("{id}/cancelar")]
        public IActionResult Canc(int id)
        {
            if (ModelState.IsValid)
            {
                var retorno = eventoService.CancelarEvento(id);
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