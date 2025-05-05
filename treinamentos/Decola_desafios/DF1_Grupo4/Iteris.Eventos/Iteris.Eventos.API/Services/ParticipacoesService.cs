using Iteris.Eventos.API.DAL;
using Iteris.Eventos.API.DAL.Respositories;
using Iteris.Eventos.API.Domain.DTO;
using Iteris.Eventos.API.Domain.Entity;
using Iteris.Eventos.API.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.Services
{
    public class ParticipacoesService
    {
        private readonly EventosRepository _eventosRepository;
        private readonly ParticipacoesRepository _participacoesRepository;
        private readonly projeto_app_eventosContext _projeto_App_EventosContext;

        public ParticipacoesService(EventosRepository eventosRepository, ParticipacoesRepository participacoesRepository, projeto_app_eventosContext projeto_app_eventosContext)
        {
            _eventosRepository = eventosRepository;
            _participacoesRepository = participacoesRepository;
            _projeto_App_EventosContext = projeto_app_eventosContext;

        }

        public List<ParticipacaoResponse> ParticipantePorEvento(int id)
        {
            List<Participacao> retorno = _projeto_App_EventosContext.Participacaos.Where(x => x.IdEvento == id).ToList();

            List<ParticipacaoResponse> eventoResponse = retorno.ConvertAll(evento => new ParticipacaoResponse(evento));

            return eventoResponse;
        }

        public async Task<ServiceResponse<ParticipacaoResponse>> Cadastrar(ParticipacaoCreateRequest model)
        {

            if (!model.IdEvento.HasValue)
                return new ServiceResponse<ParticipacaoResponse>("O ID do evento é obrigatório");

            var resultado = await _eventosRepository.PesquisaPorId(model.IdEvento);

            if (resultado == null)
                return new ServiceResponse<ParticipacaoResponse>("O evento de ID [" + model.IdEvento + "] não foi encontrado.");

            var participantes = await _participacoesRepository.QuantidadeParticipantes(model.IdEvento);

            if (participantes == resultado.LimiteVagas)
            {
                return new ServiceResponse<ParticipacaoResponse>("Não há vagas disponível");
            }

            var novoParticipante = new Participacao()
            {
                IdEvento = model.IdEvento,
                LoginParticipante = model.LoginParticipante
            };

            await _participacoesRepository.Cadastrar(novoParticipante);

            return new ServiceResponse<ParticipacaoResponse>(new ParticipacaoResponse(novoParticipante));
        }

        public async Task<ServiceResponse<ParticipacaoResponse>> DetalharEvento(int idEvento, ParticipacaoAvaliacaoUpdateRequest model)
        {
            var resultado = await _eventosRepository.PesquisaPorId(idEvento);

            //O evento existe?
            if (resultado == null)
            {
                return new ServiceResponse<ParticipacaoResponse>("O evento não foi econtrado");
            }

            //
            var participante = await _participacoesRepository.PesquisaPorId(model.IdParticipacao);

            if (participante == null)
            {
                return new ServiceResponse<ParticipacaoResponse>("O participante não foi encontrado");
            }

            //Ainda não se inscreveu nesse evento
            if (participante.IdEvento != resultado.IdEvento)
            {
                //Será possível   se inscrever   no evento, somente se houver vagas disponíveis.
                var participantes = await _participacoesRepository.QuantidadeParticipantes(idEvento);

                if (participantes == resultado.LimiteVagas)
                {
                    return new ServiceResponse<ParticipacaoResponse>("Não há vagas disponível.");
                }

                if(resultado.IdEventoStatus == 3)
                {
                    return new ServiceResponse<ParticipacaoResponse>("O evento já foi concluido.");
                } else if (resultado.IdEventoStatus == 4)
                {
                    return new ServiceResponse<ParticipacaoResponse>("O evento foi cancelado.");
                }

                var retornoBd = await _participacoesRepository.InscreverParticipante(model.IdParticipacao, idEvento);

                return new ServiceResponse<ParticipacaoResponse>(retornoBd);
            }

            if (!participante.FlagPresente)
            {
                return new ServiceResponse<ParticipacaoResponse>("O Participante não compareceu ao evento!");
            }

            var retorno = await _participacoesRepository.CadastrarAvaliacao(model.IdParticipacao, model.Nota, model.Comentario);

            return new ServiceResponse<ParticipacaoResponse>(retorno);
        }

        public async Task<ServiceResponse<ParticipacaoResponse>> EditarFlag(int idEvento, ParticipacaoFlagPresenteUpdateRequest model)
        {
            var eventoDb = await _eventosRepository.PesquisaPorId(idEvento);
            if (eventoDb == null)
                return new ServiceResponse<ParticipacaoResponse>("O evento de ID [" + model.IdEvento + "] não foi encontrado.");

            if (eventoDb.IdEventoStatus == 1 || eventoDb.IdEventoStatus == 4)
            {
                return new ServiceResponse<ParticipacaoResponse>("O evento ainda não iniciol.");
            }

            var participanteDb = await _participacoesRepository.PesquisaPorId(model.IdParticipacao);
            if (participanteDb == null)
                return new ServiceResponse<ParticipacaoResponse>("O participante de ID [" + model.IdEvento + "] não foi encontrado.");

            if (participanteDb.IdEvento != eventoDb.IdEvento)
            {
                return new ServiceResponse<ParticipacaoResponse>("O participante e o evento existem, porém o participante de ID: [" + participanteDb.IdParticipacao + "] não se inscreveu no evento de ID:[" + eventoDb.IdEvento + "].");
            }

            var flagModificada = await _participacoesRepository.AlterarFlag(model.IdParticipacao);

            return new ServiceResponse<ParticipacaoResponse>(flagModificada);
        }
    }
}
