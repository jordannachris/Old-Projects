using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.Domain.DTO
{
    public class EventoUpdateRequest
    {
        [Required]
        public int IdEventoStatus { get; set; }

     
    }
}
