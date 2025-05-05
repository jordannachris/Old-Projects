using System;
using System.ComponentModel.DataAnnotations;

namespace WebDespensaAPI.Domain.DTO
{
	public class UsuarioUpdateRequest
	{

        [Required(AllowEmptyStrings = false, ErrorMessage = "É preciso informar o email do Usuario.")]
        public string email { get; set; }


		[Required(AllowEmptyStrings = false, ErrorMessage = "É preciso informar a senha do Usuario.")]
		public string senha { get; set; }
	}
}
