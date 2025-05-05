using Microsoft.EntityFrameworkCore;
using SistemaEventos.DAL;
using SistemaEventos.Domain.DTO;
using SistemaEventos.Domain.Entity;
using SistemaEventos.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SistemaEventos.Services
{
    public class EventoService
    {
        private readonly SistemaEventosContext _dbContext;
        public EventoService(SistemaEventosContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ServiceResponse<EventoResponse> CadastrarNovo(EventoCreateRequest model)
		{
            var resultadoCategoria = _dbContext.CategoriaEventos.FirstOrDefault(x => x.IdCategoriaEvento == model.Categoria); 

            if (resultadoCategoria == null)
            {
                return new ServiceResponse<EventoResponse>("Categoria inválida.");
            }

            if (model.DataHoraInicio.Date <= DateTime.Now)
            {
                return new ServiceResponse<EventoResponse>("A data de ínicio deve ser superior ao dia atual.");
			}
            else if (model.DataHoraFim.Date != model.DataHoraInicio.Date)
            {
                return new ServiceResponse<EventoResponse>("A data final do evento deve ser no mesmo dia da data de ínicio");
            }

            if (!model.LimiteVagas.HasValue || model.LimiteVagas.Value <= 0)
            {
                return new ServiceResponse<EventoResponse>("O limite de vagas deve ser maior que 0.");
            }

            var novoEvento = new Evento()
            {
                Nome = model.Nome,
                DataHoraInicio = model.DataHoraInicio,
                DataHoraFim = model.DataHoraFim,
                Local = model.Local,
                Descricao = model.Descricao,
                LimiteVagas = model.LimiteVagas.Value,
                IdCategoriaEvento = model.Categoria.Value,
                IdEventoStatus = 1
            };
            _dbContext.Add(novoEvento);
            _dbContext.SaveChanges();
            var retorno = new EventoResponse(novoEvento);
            return new ServiceResponse<EventoResponse>(retorno);
        }

        public IEnumerable<EventoResponse> ListarTodosDisponiveis()
        {
            var retornoDoBanco = _dbContext.Eventos.Where(x => x.IdEventoStatus == 1).ToList();

            IEnumerable<EventoResponse> lista = retornoDoBanco.Select(x => new EventoResponse(x));

            return lista;
        }

        public List<EventoResponse> PesquisarPorCategoria(int idCategoria)
        {
            List<Evento> resultado = _dbContext.Eventos.Where(x => x.IdCategoriaEvento == idCategoria).ToList();
            List<EventoResponse> eventoResponse = resultado.ConvertAll(evento => new EventoResponse(evento));
            return eventoResponse;
        }
        public List<EventoResponse> PesquisarPorData(DateTime data)
        {
            List<Evento> resultado = _dbContext.Eventos.Where(x => x.DataHoraInicio.Date == data.Date).ToList();
            List<EventoResponse> eventoResponse = resultado.ConvertAll(evento => new EventoResponse(evento));
            return eventoResponse;
        }
        public ServiceResponse<EventoResponse> IniciarEvento(int id)
        {

            var evento = _dbContext.Eventos.FirstOrDefault(x => x.IdEvento == id);
            if (evento == null)
            {
                return new ServiceResponse<EventoResponse>("Evento não encontrado!");
            }

            if(evento.DataHoraInicio.Date != DateTime.Now.Date)
            {
                return new ServiceResponse<EventoResponse>("Somente é possível iniciar o evento no dia de ínicio.");
            }

            evento.IdEventoStatus = 2;
            _dbContext.Eventos.Add(evento).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return new ServiceResponse<EventoResponse>(new EventoResponse(evento));
        }
        public ServiceResponse<EventoResponse> ConcluirEvento(int id)
        {

            var evento = _dbContext.Eventos.FirstOrDefault(x => x.IdEvento == id);
            if (evento == null)
            {
                return new ServiceResponse<EventoResponse>("Evento não encontrado!");
            }

            if (evento.IdEventoStatus != 2)
            {
                return new ServiceResponse<EventoResponse>("O evento só pode ser concluído após ser iniciado.");
            }

            evento.IdEventoStatus = 3;
            _dbContext.Eventos.Add(evento).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return new ServiceResponse<EventoResponse>(new EventoResponse(evento));
        }
        public ServiceResponse<EventoResponse> CancelarEvento(int id)
        {
            var evento = _dbContext.Eventos.FirstOrDefault(x => x.IdEvento == id);
            if (evento == null)
            {
                return new ServiceResponse<EventoResponse>("Não encontrado!");
            }

            if (evento.DataHoraInicio.Date <= DateTime.Now.Date) { return new ServiceResponse<EventoResponse>("Só é possível cancelar o evento antes do dia de início!"); }

            evento.IdEventoStatus = 4;
            _dbContext.Eventos.Add(evento).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return new ServiceResponse<EventoResponse>(new EventoResponse(evento));

        }
    }
}