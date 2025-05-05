using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPIdesafio02.Domain.DTO
{
	public class TarefaCreateRequest
	{

		[Required(AllowEmptyStrings = false, ErrorMessage = "O Título é obrigatório!")]
		public string Titulo { get; set; }


		public string Descricao { get; set; } 


		//public bool Concluido { get; set; } ------> Não precisa colocar o "bool Concluido" aqui no CREATE REQUEST
		//									  ------> CREATE REQUEST é usado para coisas que o usuário precisa digitar/infomar
		//									  ------> O usuário não vai precisar informar que a tarefa foi Concluída


		
		public int? Prioridade { get; set; } //Tem que ser um número entre 1 e 5, por isso coloquei [Required]

		//int? is nullable
		//int? e Required????
		//Sem isso este erro nunca vai acontecer.
		//Com um int normal, o valor padrão vai sempre ser 0
		//e nunca vamos saber se é o valor passado ou o padrão
	}
}
