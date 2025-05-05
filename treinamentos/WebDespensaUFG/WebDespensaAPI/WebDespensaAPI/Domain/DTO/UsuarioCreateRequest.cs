using System;
using System.ComponentModel.DataAnnotations;

namespace WebDespensaAPI.Domain.DTO
{
	public class UsuarioCreateRequest
	{
		[Required(AllowEmptyStrings = false, ErrorMessage = "O nome do usuario é obrigatório!")]
		public string nome { get; set; }


		[Required(AllowEmptyStrings = false, ErrorMessage = "A senha do usuario é obrigatória!")]
		public string senha { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "O email do usuario é obrigatório!")]
        public string email { get; set; }


		public string numCartao { get; set; }

	}
}
