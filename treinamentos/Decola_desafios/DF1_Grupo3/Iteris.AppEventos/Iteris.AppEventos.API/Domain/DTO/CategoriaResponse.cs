using Iteris.AppEventos.API.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.AppEventos.API.Domain.DTO
{
    public class CategoriaResponse
    {
        public CategoriaResponse(CategoriaEvento categoriaevento)
        {
            IdCategoriaEvento = categoriaevento.IdCategoriaEvento;
            NomeCategoria = categoriaevento.NomeCategoria;

            if (categoriaevento.Eventos != null && categoriaevento.Eventos.Any())
            {

                Eventos = new List<EventoResponse>();
                Eventos.AddRange(categoriaevento.Eventos.Select(x => new EventoResponse(x)));
            }
        }
        public int IdCategoriaEvento { get; set; }
        public string NomeCategoria { get; set; }
        public List<EventoResponse> Eventos { get; set; }
    }
}