using WebDespensaAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDespensaAPI.Domain.DTO
{
	public class UsuarioResponse
	{
		public UsuarioResponse(Usuario usuario)
		{
			id = usuario.id;
			nome = usuario.nome;
			senha = usuario.senha;
			email = usuario.email;
			numCartao = usuario.numCartao;

			if (usuario.Produtos != null && usuario.Produtos.Any())
			{
				Produtos = new List<ProdutoResponse>();
				Produtos.AddRange(usuario.Produtos.Select(x => new ProdutoResponse(x)));
			}
		}

		public int id { get; set; }
		public string nome { get; set; }
		public string senha { get; set; }
		public string email { get; set; }
		public string numCartao { get; set; }

		public List<ProdutoResponse> Produtos { get; set; }
	}
}
