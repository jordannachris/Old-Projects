using Iteris.AppEventos.API.DAL;
using Iteris.AppEventos.API.DAL.Repositories;
using Iteris.AppEventos.API.Domain.DTO;
using Iteris.AppEventos.API.Domain.Entity;
using Iteris.AppEventos.API.Services.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Iteris.AppEventos.API.Services
{
	public class ParticipacoesService
	{
		private readonly ParticipacoesRepository _participacoesRepository;
		private readonly projeto_app_eventosContext _eventosContext;

		public ParticipacoesService(ParticipacoesRepository participacoesRepository)
		{
			_participacoesRepository = participacoesRepository;
		}




		/*
		//Listar todas as participacoes
		public List<Participacao> ListarTodos()
		{
			// select  * from participacoes
			return _participacoesRepository.Participacoes.ToList();
		}
		*/


		/*
		public async Task<ServiceResponse<ParticipacaoResponse>> PesquisaPorId(int id)
		{
			var participacao = await _participacoesRepository.PesquisaPorId(id);

			if (participacao != null)
			{
				return new ServiceResponse<ParticipacaoResponse>(new ParticipacaoResponse(participacao));
			}

			return new ServiceResponse<ParticipacaoResponse>("Não encontrado");

		}
		*/



		/******************** COMEÇO DO CADASTRAR PARTICIPACAO ********************/

		public async Task<ServiceResponse<ParticipacaoResponse>> CadastrarParticipacao(ParticipacaoCreateRequest novo)
		{

			// validação de integridade
			var resultado = _eventosContext.Eventos.FirstOrDefault(x => x.IdEvento == novo.IdEvento);
			
			if (resultado == null)
				return new ServiceResponse<ParticipacaoResponse>("Evento não encontrado");

			//REGRAS

			//Colocar regra sobre a quantidade de vagas.
			//Não dá para fazer cadastro de novo participante se já estiver estourado o limite de vagas daquele Evento.
			/*
			if (id da Participacao >= limite de vagas)
			{
				return new ServiceResponse<PartipacaoResponse>("Não há mais vagas para este evento.");
			}
			*/

			//TUDO CERTO, SÓ CADASTRAR
			var modeloDb = new Participacao
			{
				IdEvento = novo.IdEvento,
				LoginParticipante = novo.LoginParticipante,
				FlagPresente = false
			};


			await _participacoesRepository.CadastrarParticipacao(modeloDb);

			return new ServiceResponse<ParticipacaoResponse>(new ParticipacaoResponse(modeloDb));
		}
		/******************** FIM DO CADASTRAR PARTICIPACAO ********************/



		/******************** Atualizar Flag Presente **********************/
		public ServiceResponse<Participacao> AtualizarPresenca(int id, ParticipacaoPresencaUpdateRequest model)
		{
		
			var resultado = _eventosContext.Participacaos.FirstOrDefault(x => x.IdParticipacao == id);

			if (resultado == null)
				return new ServiceResponse<Participacao>("Participante não encontrado!");

			resultado.FlagPresente = model.FlagPresente;

			//tudo certo, só atualizar
			_eventosContext.Participacaos.Add(resultado).State = EntityState.Modified;
			_eventosContext.SaveChanges();

			return new ServiceResponse<Participacao>(resultado);
		}



		/******************** Atualizar Nota e Comentario********************/

		public ServiceResponse<Participacao> AtualizarNotaComentario(int id, ParticipacaoNotaUpdateRequest model)
		{

			var resultado = _eventosContext.Participacaos.FirstOrDefault(x => x.IdParticipacao == id);


			if (resultado == null)
				return new ServiceResponse<Participacao>("Participante não encontrado!");


			resultado.Nota = model.Nota;
			resultado.Comentario = model.Comentario;


			//tudo certo, só atualizar
			_eventosContext.Participacaos.Add(resultado).State = EntityState.Modified;
			_eventosContext.SaveChanges();

			return new ServiceResponse<Participacao>(resultado);
		}








	}
}
