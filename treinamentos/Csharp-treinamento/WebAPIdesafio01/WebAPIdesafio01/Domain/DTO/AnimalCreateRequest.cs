using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPIdesafio01.Domain.DTO
{
	public class AnimalCreateRequest
	{
		[Required(AllowEmptyStrings = false, ErrorMessage = "O Nome é obrigatório!")]
		public string Nome { get; set; }


		[Required]
		public int? Idade { get; set; }


		[Required(AllowEmptyStrings = false, ErrorMessage = "A Espécie é obrigatório!")]
		public string Especie { get; set; }


		public DateTime? DataNascimento { get; set; }


		[Required]
		public int? NivelFofura { get; set; }


		[Required]
		public int? NivelCarinho { get; set; }

		[EmailAddress]
		public string Email { get; set; }




		//int? e Required????
		//Sem isso este erro nunca vai acontecer.
		//Com um int normal, o valor padrão vai sempre ser 0
		//e nunca vamos saber se é o valor passado ou o padrão
	}
}
