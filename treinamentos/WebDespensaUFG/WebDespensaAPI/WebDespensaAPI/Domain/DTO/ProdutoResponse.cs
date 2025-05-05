using WebDespensaAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDespensaAPI.Domain.DTO
{
	public class ProdutoResponse
	{
		public ProdutoResponse(Produto produto)
		{
			id = produto.id;
			idUsuario = produto.idUsuario;
			nome = produto.nome;
		}
		public int id { get; set; }
		public int idUsuario { get; set; }
		public string nome { get; set; }
	}
}