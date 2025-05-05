using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPIdesafio02.Domain.DTO
{
	public class TarefaUpdateRequestStatus
	{
		public bool Concluido { get; set; } = false; //tem que atualizar Concluido
	}
}
