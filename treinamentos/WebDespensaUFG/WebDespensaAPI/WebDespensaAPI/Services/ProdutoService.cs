using WebDespensaAPI.DAL;
using WebDespensaAPI.Domain.DTO;
using WebDespensaAPI.Domain.Entity;
using WebDespensaAPI.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WebDespensaAPI.Services
{
	public class ProdutoService
	{
		private readonly AppDbContext _dbContext;
		public ProdutoService(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}



		public ServiceResponse<ProdutoResponse> CadastrarNovo(ProdutoCreateRequest model)
		{
			// validação de integridade
			var resultado = _dbContext.Usuarios.FirstOrDefault(x => x.id == model.idUsuario);
			if (resultado == null)
				return new ServiceResponse<ProdutoResponse>("Usuario não encontrado");

			//tudo certo, só cadastrar
			var novoProduto = new Produto()
			{
				idUsuario = model.idUsuario,
				nome = model.nome
			};

			_dbContext.Add(novoProduto);
			_dbContext.SaveChanges();

			var retorno = new ProdutoResponse(novoProduto);
			return new ServiceResponse<ProdutoResponse>(retorno);
		}



		public IEnumerable<ProdutoResponse> ListarTodos()
		{
			var retornoDoBanco = _dbContext.Produtos.ToList();

			IEnumerable<ProdutoResponse> lista = retornoDoBanco.Select(x => new ProdutoResponse(x));

			return lista;
		}



		public ServiceResponse<Produto> Editar(int id, ProdutoUpdateRequest model)
		{
			var resultado = _dbContext.Produtos.FirstOrDefault(x => x.id == id);

			if (resultado == null)
				return new ServiceResponse<Produto>("Produto não encontrado!");

			resultado.nome = model.nome;


			//tudo certo, só atualizar
			_dbContext.Produtos.Add(resultado).State = EntityState.Modified;
			_dbContext.SaveChanges();

			return new ServiceResponse<Produto>(resultado);
		}



		public ServiceResponse<bool> Deletar(int id)
		{
			var resultado = _dbContext.Produtos.FirstOrDefault(x => x.id == id);

			if (resultado == null)
				return new ServiceResponse<bool>("Produto não encontrado!");

			//tudo certo, só atualizar
			_dbContext.Produtos.Remove(resultado);
			_dbContext.SaveChanges();

			return new ServiceResponse<bool>(true);
		}
		
	}
}
