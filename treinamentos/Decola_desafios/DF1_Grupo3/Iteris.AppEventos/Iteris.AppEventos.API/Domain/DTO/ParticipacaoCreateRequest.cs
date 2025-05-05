using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.AppEventos.API.Domain.DTO
{
	public class ParticipacaoCreateRequest
	{
		public int IdEvento { get; set; }
	
		public string LoginParticipante { get; set; }
	}
}







