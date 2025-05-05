using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPIdesafio01.Domain.DTO
{
	public class AnimalUpdateRequest
	{
		[Required(AllowEmptyStrings = false, ErrorMessage = "A Espécie é obrigatório!")]
		public string Especie { get; set; }
		
	}
}
