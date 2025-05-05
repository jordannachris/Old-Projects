using Iteris.Eventos.API.DAL;
using Iteris.Eventos.API.DAL.Respositories;
using Iteris.Eventos.API.Domain.DTO;
using Iteris.Eventos.API.Domain.Entity;
using Iteris.Eventos.API.Services.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.Services
{
    public class EventosService
    {
        private readonly EventosRepository _eventosRepository;
		private readonly CategoriasEventosRepository _categoriasEventosRepository;
        private readonly projeto_app_eventosContext _projeto_App_EventosContext;


        

        public EventosService(EventosRepository eventosRepository, CategoriasEventosRepository categoriasEventosRepository, projeto_app_eventosContext projeto_app_eventosContext)
        {
            _eventosRepository = eventosRepository;
            _categoriasEventosRepository = categoriasEventosRepository;
            _projeto_App_EventosContext = projeto_app_eventosContext;
            
  
        }

        
       
        public IEnumerable<EventoResponse> ListarTodos()
        {
            return _eventosRepository.ListarTodos();
        }

        public IEnumerable<EventoResponse> ListarPorCategoria(int categoria)
        {
            return _eventosRepository.ListarEventoCategoria(categoria);
        }

        public IEnumerable<EventoResponse> ListarPorData(DateTime dataEvento)
        {
            return _eventosRepository.ListarEventoData(dataEvento);
        }



        public async Task<ServiceResponse<EventoResponse>> PesquisaPorId(int id)
		{
			var resultado = await _eventosRepository.PesquisaPorId(id);
			if (resultado != null)
			{
				return new ServiceResponse<EventoResponse>(new EventoResponse(resultado));
			}
			return new ServiceResponse<EventoResponse>("Não encontrado");
		}

		public async Task<ServiceResponse<EventoResponse>> Cadastrar(EventoCreateRequest novo)
		{

            if ((novo.DataHoraInicio != novo.DataHoraFim))
            {
				return new ServiceResponse<EventoResponse>("O evento deve começar e terminar na mesma data");
            }
			else if (DateTime.Compare(novo.DataHoraInicio.Date, DateTime.Today) <= 0)
            {
				return new ServiceResponse<EventoResponse>("As datas do evento devem ser superior a data de hoje");
            }

            if(novo.LimiteDeVagas <= 0)
            {
                return new ServiceResponse<EventoResponse>("O limite de vagas deve ser superior a 0");
            }

			var categoriaEvento = await _categoriasEventosRepository.PesquisaPorId(novo.IdCategoriaEvento);
			if (categoriaEvento == null)
				return new ServiceResponse<EventoResponse>("A categoria não foi encontrada. ID: " + novo.IdCategoriaEvento);


			var modeloDb = new Evento
			{
				IdCategoriaEvento = novo.IdCategoriaEvento,
				Nome = novo.Nome.Trim(),
				DataHoraInicio = novo.DataHoraInicio,
				DataHoraFim = novo.DataHoraFim,
				Local = novo.Local.Trim(),
				Descricao = novo.Descricao.Trim(),
				LimiteVagas = novo.LimiteDeVagas.Value,
				IdEventoStatus = 1
			};

			await _eventosRepository.Cadastrar(modeloDb);

			return new ServiceResponse<EventoResponse>(new EventoResponse(modeloDb));
		}

        public ServiceResponse<Evento> EditarStatus(int id, EventoUpdateRequest status)
        {

            var resultado = _projeto_App_EventosContext.Eventos.FirstOrDefault(x => x.IdEvento == id);
         

            if (resultado == null)
            {

                return new ServiceResponse<Evento>("Evento não encontrado!");
            }

            else if (DateTime.Compare(resultado.DataHoraInicio.Date, DateTime.Today) == 0 && status.IdEventoStatus == 4)
            {
                return new ServiceResponse<Evento>("Não é possivel cancelar no dia do evento");
            } else if (DateTime.Compare(resultado.DataHoraInicio.Date, DateTime.Today) > 0 && status.IdEventoStatus == 2 )
            {
                return new ServiceResponse<Evento>("Só pode iniciar evento no dia de inicio");
            } else if (resultado.IdEventoStatus != 2 && status.IdEventoStatus == 3)
            {
                return new ServiceResponse<Evento>("Só pode concluir quando for iniciado");
            }



                //tudo certo, só atualizar
                resultado.IdEventoStatus = status.IdEventoStatus;
            _projeto_App_EventosContext.Eventos.Add(resultado).State = EntityState.Modified;
            _projeto_App_EventosContext.SaveChanges();

            return new ServiceResponse<Evento>(resultado);
        }
    }
}
