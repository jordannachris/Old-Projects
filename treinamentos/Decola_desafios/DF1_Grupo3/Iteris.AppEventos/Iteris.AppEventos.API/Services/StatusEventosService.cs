using Iteris.AppEventos.API.DAL;
using Iteris.AppEventos.API.DAL.Repositories;
using Iteris.AppEventos.API.Domain.DTO;
using Iteris.AppEventos.API.Domain.Entity;
using Iteris.AppEventos.API.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.AppEventos.API.Services
{
    public class StatusEventosService
    {
        private readonly projeto_app_eventosContext _eventosContext;
        //private readonly StatusEventosRepository _statusEventosRepository;

        public StatusEventosService(projeto_app_eventosContext eventosContext)
        {
            _eventosContext = eventosContext;
        }

        /*public async Task<ServiceResponse<StatusEventoResponse>> PesquisaPorStatus(string Status)
        {
            var status = await _statusEventosRepository.PesquisaPorStatus(Status);
            if (status != null)
            {
                return new ServiceResponse<StatusEventoResponse>(new StatusEventoResponse(status));
            }
            return new ServiceResponse<StatusEventoResponse>("Não encontrado");
        }*/
        public IEnumerable<StatusEventoResponse> AllList()
        {
            // select  * from albuns x
            // left join avaliacoes a on a.idAlbum = x.idAlbum

            var retornoDoBanco = _eventosContext.StatusEventos.Include(x => x.Eventos).ToList();

            // Conveter para AlbumResponse
            IEnumerable<StatusEventoResponse> lista = retornoDoBanco.Select(x => new StatusEventoResponse(x));

            return lista;
        }
        /*public ServiceResponse<StatusEvento> EditarStatus(int id, StatusEventoUpdateRequest model)
        {
            string[] status = { "aberto para inscrições", "em andamento", "concluído", "cancelado" };
            var resultado = _eventosContext.StatusEventos.FirstOrDefault(x => x.IdEventoStatus == id);

            if (resultado == null)
            {
                return new ServiceResponse<StatusEvento>("Status não encontrado!");
            }
            else if (!status.Contains(model.NomeStatus.ToLower()))
            {
                return new ServiceResponse<StatusEvento>("Escolha entre: aberto para inscrições, em andamento, concluído ou cancelado!");
            }
            //tudo certo, só atualizar
            _eventosContext.StatusEventos.Add(resultado).State = EntityState.Modified;
            _eventosContext.SaveChanges();

            return new ServiceResponse<StatusEvento>(resultado);
        }
        public async Task<ServiceResponse<StatusEventoResponse>> EditarStatus(StatusEventoUpdateRequest update)
      {
          string[] status = { "aberto para inscrições", "em andamento", "concluído", "cancelado" };
           var listaPesquisa = await _statusEventosRepository.EditarStatus(update);
           var updateStatus = listaPesquisa.Select(x => new StatusEventoResponse(x)).ToList();

           if (updateStatus == null)
          {
              return new ServiceResponse<StatusEventoResponse>("Status não encontrado!");
          }
          else if (!status.Contains(update.NomeStatus.ToLower()))
          {
              return new ServiceResponse<StatusEventoResponse>("Escolha entre: aberto para inscrições, em andamento, concluído ou cancelado!");
          }
          //tudo certo, só atualizar
          _eventosContext.StatusEventos.Add(updateStatus).State = EntityState.Modified;
          _eventosContext.SaveChanges();

          return new ServiceResponse<StatusEvento>(updateStatus);
      }*/
    }
}
