using WebDespensaAPI.Domain.DTO;
using WebDespensaAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using WebDespensaAPI.Services.Base;
using Microsoft.EntityFrameworkCore;
using WebDespensaAPI.DAL;

namespace WebDespensaAPI.Services
{
	public class UsuarioService
	{
		private readonly AppDbContext _dbContext;
		public UsuarioService(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		

		public IEnumerable<UsuarioResponse> ListarTodos()
		{

            var retornoDoBanco = _dbContext.Usuarios.Include(x => x.Produtos).ToList();

			// Converter para UsuarioResponse
			IEnumerable<UsuarioResponse> lista = retornoDoBanco.Select(x => new UsuarioResponse(x));

			return lista;
		}


		public ServiceResponse<UsuarioResponse> PesquisarPorId(int id)
		{
            // Lambda Expression / Expressões lambda
            // Operação em conjunto de dados
            var resultado = _dbContext.Usuarios.Include(x => x.Produtos).FirstOrDefault(x => x.id == id);

            if (resultado == null)
				return new ServiceResponse<UsuarioResponse>("Usuario não encontrado!");
			else
				return new ServiceResponse<UsuarioResponse>(new UsuarioResponse(resultado));

		}

        //public ServiceResponse<UsuarioResponse> PesquisarPorNome(string nome)
        //{
        //    var resultado = _dbContext.Usuarios.Include(x => x.Produtos).FirstOrDefault(x => x.nome == nome);
        //    if (resultado == null)
        //        return new ServiceResponse<UsuarioResponse>("Usuario não encontrado!");
        //    else
        //        return new ServiceResponse<UsuarioResponse>(new UsuarioResponse(resultado));
        //}


        //public ServiceResponse<UsuarioResponse> PesquisarPorEmail(string email)
        //{
        //    var resultado = _dbContext.Usuarios.Include(x => x.Produtos).FirstOrDefault(x => x.email == email);
        //    if (resultado == null)
        //        return new ServiceResponse<UsuarioResponse>("Email de usuário não encontrado!");
        //    else
        //        return new ServiceResponse<UsuarioResponse>(new UsuarioResponse(resultado));
        //}


        //public ServiceResponse<UsuarioResponse> PesquisarPorSenha(string senha)
        //{
        //    var resultado = _dbContext.Usuarios.Include(x => x.Produtos).FirstOrDefault(x => x.senha == senha);
        //    if (resultado == null)
        //        return new ServiceResponse<UsuarioResponse>("Senha inválida!");
        //    else
        //        return new ServiceResponse<UsuarioResponse>(new UsuarioResponse(resultado));
        //}


        public ServiceResponse<UsuarioResponse> PesquisarPorEmailSenha(string email, string senha)
		{
			var resultadoEmail = _dbContext.Usuarios.Include(x => x.Produtos).FirstOrDefault(x => x.email == email);
			var resultadoSenha = _dbContext.Usuarios.Include(x => x.Produtos).FirstOrDefault(x => x.senha == senha);

			if (resultadoEmail == null || resultadoSenha == null)
				return new ServiceResponse<UsuarioResponse>("Erro ao efetuar login! Verifique se o e-mail e/ou senha estão corretos!");
			else
				return new ServiceResponse<UsuarioResponse>(new UsuarioResponse(resultadoEmail));
		}



		public ServiceResponse<Usuario> CadastrarNovo(UsuarioCreateRequest model)
		{
			var novoUsuario = new Usuario()
			{
				nome = model.nome,
				senha = model.senha,
				email = model.email,
				numCartao = model.numCartao
			};


			_dbContext.Add(novoUsuario);
			_dbContext.SaveChanges();

			return new ServiceResponse<Usuario>(novoUsuario);
		}


		public ServiceResponse<Usuario> Editar(int id, UsuarioUpdateRequest model)
		{
			var resultado = _dbContext.Usuarios.FirstOrDefault(x => x.id == id);

			if (resultado == null)
				return new ServiceResponse<Usuario>("Usuario não encontrado!");

			resultado.email = model.email;
			resultado.senha = model.senha;

			//tudo certo, só atualizar
			_dbContext.Usuarios.Add(resultado).State = EntityState.Modified;
			_dbContext.SaveChanges();

			return new ServiceResponse<Usuario>(resultado);
		}



        public ServiceResponse<bool> Deletar(int id)
        {
            var resultado = _dbContext.Usuarios.FirstOrDefault(x => x.id == id);

            if (resultado == null)
                return new ServiceResponse<bool>("Usuario não encontrado!");


            //tudo certo, só atualizar
            _dbContext.Usuarios.Remove(resultado);
            _dbContext.SaveChanges();

            return new ServiceResponse<bool>(true);
        }
    }
}
