using SistemaEventos.DAL;
using System;
using SistemaEventos.Domain.DTO;
using System.Collections.Generic;
using System.Linq;
using SistemaEventos.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace SistemaEventos.Services.Base
{
    public class ParticipacaoService
    {
        private readonly SistemaEventosContext _dbContext;
        public ParticipacaoService(SistemaEventosContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<ParticipacaoResponse> ListarTodos()
        {

            List<Participacao> participantes = _dbContext.Participacaos.ToList();
            List<ParticipacaoResponse> participacaoResponse = participantes.ConvertAll(categoria => new ParticipacaoResponse(categoria));

            return participacaoResponse;
        }
        public List<ParticipacaoResponse> ParticipantePorEvento(int id)
        {
            List<Participacao> retorno = _dbContext.Participacaos.Where(x => x.IdEvento == id).ToList();


            List<ParticipacaoResponse> eventoResponse = retorno.ConvertAll(evento => new ParticipacaoResponse(evento));

            return eventoResponse;
        }
        public ServiceResponse<Participacao> ParticipantePorId(int id)
        {
            var participante = _dbContext.Participacaos.FirstOrDefault(x => x.IdParticipacao == id);
            if (participante == null)
            {
                return new ServiceResponse<Participacao>("Participante não encontrado!");
            }
            else
            {
                return new ServiceResponse<Participacao>(participante);
            }
        }
        public ServiceResponse<ParticipacaoResponse> EditarParticipacao(int id)
        {
            var resultado = _dbContext.Participacaos.FirstOrDefault(x => x.IdParticipacao == id);

            if (resultado == null)
            {
                return new ServiceResponse<ParticipacaoResponse>("Participante não encontrado!");
            }
            var retornoDoBanco = _dbContext.Participacaos.Include(x => x.IdEventoNavigation).FirstOrDefault(x => x.IdParticipacao == id);
            if (retornoDoBanco.IdEventoNavigation.IdEventoStatus != 2)
            {
                return new ServiceResponse<ParticipacaoResponse>("Evento com status não iniciado");
            }
            resultado.FlagPresente = true;
            _dbContext.Participacaos.Add(resultado).State = EntityState.Modified;
            _dbContext.SaveChanges();
            ParticipacaoResponse participacaoResponse = new ParticipacaoResponse(resultado);
            return new ServiceResponse<ParticipacaoResponse>(participacaoResponse);
        }
        public ServiceResponse<ParticipacaoResponse> AvaliacaoEvento(int id, ParticipacaoUpdateRequest model)
        {
            var resultado = _dbContext.Participacaos.FirstOrDefault(x => x.IdParticipacao == id);
            if (resultado == null)
            {
                return new ServiceResponse<ParticipacaoResponse>("Participante não encontrado!");
            }
            if (model.Nota < 1 || model.Nota > 5)
            {
                return new ServiceResponse<ParticipacaoResponse>("A nota da avaliação deve ser um número entre 1 e 5");
            }
            var retornoDoBanco = _dbContext.Participacaos.Include(x => x.IdEventoNavigation).FirstOrDefault(x => x.IdParticipacao == id);
            if (retornoDoBanco.IdEventoNavigation.IdEventoStatus != 3)
            {
                return new ServiceResponse<ParticipacaoResponse>("A avaliação estará disponível somente após o evento");
            }
            if (resultado.FlagPresente != true)
            {
                return new ServiceResponse<ParticipacaoResponse>("Somente é possível avaliar se participou do evento");
            }
            resultado.Nota = model.Nota;
            resultado.Comentario = model.Comentario;

            _dbContext.Participacaos.Add(resultado).State = EntityState.Modified;
            _dbContext.SaveChanges();
            ParticipacaoResponse participacaoResponse = new ParticipacaoResponse(resultado);
            return new ServiceResponse<ParticipacaoResponse>(participacaoResponse);
        }
        public ServiceResponse<ParticipacaoResponse> CadastrarNovoParticipante(ParticipacaoCreateRequest model)
        {
            
            var resultadoCategoria = _dbContext.Eventos.FirstOrDefault(x => x.IdEvento == model.IdEvento);  

            if (resultadoCategoria == null)
            {
                return new ServiceResponse<ParticipacaoResponse>("Evento não encontrado.");
            }

            var retornoDoBanco = _dbContext.Eventos.Where(x => x.IdEvento == model.IdEvento).FirstOrDefault();

            var contadorVagas = _dbContext.Participacaos.Include(x => x.IdEventoNavigation).Where(x => x.IdEvento == model.IdEvento).Count();


            if (contadorVagas >= retornoDoBanco.LimiteVagas)
            {
                return new ServiceResponse<ParticipacaoResponse>("Evento esgotado!");
            }

            var novaParticipacao = new Participacao()
            {
            IdEvento = model.IdEvento,
            LoginParticipante = model.LoginParticipante,
            FlagPresente = false,
            Nota = null,
            Comentario = null
        };
            _dbContext.Add(novaParticipacao);
            _dbContext.SaveChanges();
            var retorno = new ParticipacaoResponse(novaParticipacao);
            return new ServiceResponse<ParticipacaoResponse>(retorno);

        }
    }
}
