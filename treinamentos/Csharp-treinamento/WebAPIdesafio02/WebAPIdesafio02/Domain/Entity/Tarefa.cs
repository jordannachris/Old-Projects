using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIdesafio02.Domain.Entity
{
	[Table("Tarefas")]
	public class Tarefa
	{
		[Key]
		public int IdTarefa { get; set; }


		[Required]
		[StringLength(255)]
		public string Titulo { get; set; }


		[Required]
		[StringLength(1000)]
		public string Descricao { get; set; }

		public int? Prioridade { get; set; }

		public bool Concluido { get; set; } = false;
	}
}
