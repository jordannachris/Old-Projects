using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDespensaAPI.Domain.DTO
{
	public class ProdutoCreateRequest
	{
		[Required]
		public int idUsuario { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "É preciso informar o nome do Produto.")]
		public string nome { get; set; }
	}
}
