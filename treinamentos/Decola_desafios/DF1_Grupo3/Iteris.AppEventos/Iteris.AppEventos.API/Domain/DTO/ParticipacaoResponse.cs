using Iteris.AppEventos.API.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.AppEventos.API.Domain.DTO
{
	public class ParticipacaoResponse
	{
		public ParticipacaoResponse(Participacao baseModel)
		{
			Id = baseModel.IdParticipacao;

		}
		public int Id { get; set; }
		
	}
}

