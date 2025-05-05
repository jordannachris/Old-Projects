using Microsoft.AspNetCore.Mvc;
using SistemaEventos.Domain.DTO;
using SistemaEventos.Services.Base;

namespace SistemaEventos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipacaoController : ControllerBase
    {
        private readonly ParticipacaoService participacaoService;
        public ParticipacaoController(ParticipacaoService participacaoService)
        {
            this.participacaoService = participacaoService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(participacaoService.ListarTodos());
        }
        [HttpGet("evento/{idevento}")]
        public IActionResult ParticipantePorEvento(int idevento)
        {
            return Ok(participacaoService.ParticipantePorEvento(idevento));
        }
        [HttpGet("{id}")]
        public IActionResult ParticipantePorId(int id)
        {
            var retorno = participacaoService.ParticipantePorId(id);

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
        public IActionResult Post([FromBody] ParticipacaoCreateRequest postModel)
        {
            if (ModelState.IsValid)
            {
                var retorno = participacaoService.CadastrarNovoParticipante(postModel);
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
        [HttpPut("{id}/flagPresente")]
        public IActionResult Put(int id)
        {
            if (ModelState.IsValid)
            {
                var retorno = participacaoService.EditarParticipacao(id);
                if (!retorno.Sucesso)
                    return BadRequest(retorno.Mensagem);
                return Ok(retorno.ObjetoRetorno);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        [HttpPut("{id}/avaliacao")]
        public IActionResult Put(int id, [FromBody] ParticipacaoUpdateRequest putModel)
        {
            if (ModelState.IsValid)
            {
                var retorno = participacaoService.AvaliacaoEvento(id, putModel);
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
