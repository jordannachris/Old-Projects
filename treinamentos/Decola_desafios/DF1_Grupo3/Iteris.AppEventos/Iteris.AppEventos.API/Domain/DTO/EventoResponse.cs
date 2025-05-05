using Iteris.AppEventos.API.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.AppEventos.API.Domain.DTO
{
    public class EventoResponse
    {
        public EventoResponse(Evento baseModel)
        {
            IdEvento = baseModel.IdEvento;
            IdEventoStatus = baseModel.IdEventoStatus;
            IdCategoriaEvento = baseModel.IdCategoriaEvento;
            Nome = baseModel.Nome;
            DataHoraInicio = baseModel.DataHoraInicio;
            DataHoraFim = baseModel.DataHoraFim;
            Local = baseModel.Local;
            Descricao = baseModel.Descricao;
            LimiteVagas = baseModel.LimiteVagas;
        }
        public int IdEvento { get; set; }
        public int IdEventoStatus { get; set; }
        public int IdCategoriaEvento { get; set; }
        public string Nome { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public int LimiteVagas { get; set; }
    }

}



