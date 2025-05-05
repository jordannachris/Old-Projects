using WebAPIdesafio02.Domain.DTO;
using WebAPIdesafio02.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPIdesafio02.Services.Base;
using Microsoft.EntityFrameworkCore;
using WebAPIdesafio02.DAL;



namespace WebAPIdesafio02.Services
{
	public class TarefasService
	{
		private readonly AppDbContext _dbContext;

		public TarefasService(AppDbContext dbContext) 
		{
			_dbContext = dbContext;
		}


		//Listar todas as tarefas
		public List<Tarefa> ListarTodos()
		{
			// select  * from tarefas
			return _dbContext.Tarefas.ToList();
		}



		//Obter somente uma tarefa por Id
		public ServiceResponse<Tarefa> PesquisarPorId(int id)
		{
			// Lambda Expression / Expressões lambda
			// Operação em conjunto de dados
			// select top 1 * from tarefas x where x.IdAlbum == id 
			var resultado = _dbContext.Tarefas.FirstOrDefault(x => x.IdTarefa == id);

			if (resultado == null)
				return new ServiceResponse<Tarefa>("Não encontrado!");
			else
				return new ServiceResponse<Tarefa>(resultado);

		}




		/**********************************************************/
		//Cadastrar
		public ServiceResponse<Tarefa> CadastrarNovo(TarefaCreateRequest model)
		{
			//REGRAS

			//REGRAS DE PRIORIDADE
			if (model.Prioridade == null)
			{
				model.Prioridade = 5;

			}

			if (model.Prioridade != null && (model.Prioridade < 1 || model.Prioridade > 5))
			{
				return new ServiceResponse<Tarefa>("A Prioridade da tarefa deve ser um número entre 1 a 5.");
			}


			//tudo certo, só cadastrar
			//Criação(deve receber somente Título, Descrição e Prioridade)
			var novaTarefa = new Tarefa()
			{

				Titulo = model.Titulo,

				Descricao = model.Descricao,

				Prioridade = model.Prioridade.Value

			};

			_dbContext.Add(novaTarefa);
			_dbContext.SaveChanges();

			return new ServiceResponse<Tarefa>(novaTarefa);
		}
		/**********************************************************/



		//Atualização de Concluido
		public ServiceResponse<Tarefa> atualizarStatus(int id, TarefaUpdateRequestStatus model)
		{
			// select top 1 * from tarefas x where x.IdTarefa == id 
			var resultado = _dbContext.Tarefas.FirstOrDefault(x => x.IdTarefa == id);


			if (resultado == null)
				return new ServiceResponse<Tarefa>("Tarefa não encontrada!");



			//tudo certo, só atualizar
			resultado.Concluido = model.Concluido;


			_dbContext.Tarefas.Add(resultado).State = EntityState.Modified;
			_dbContext.SaveChanges();

			return new ServiceResponse<Tarefa>(resultado);
		}



		//Atualização de Prioridade
		public ServiceResponse<Tarefa> atualizarPrioridade(int id, TarefaUpdateRequestPrioridade model)
		{
			// select top 1 * from tarefas x where x.IdTarefa == id 
			var resultado = _dbContext.Tarefas.FirstOrDefault(x => x.IdTarefa == id);


			if (resultado == null)
				return new ServiceResponse<Tarefa>("Tarefa não encontrada!");


			//REGRAS DE PRIORIDADE
			if (model.Prioridade == null)
			{
				model.Prioridade = 5;

			}

			if (model.Prioridade != null && (model.Prioridade < 1 || model.Prioridade > 5))
			{
				return new ServiceResponse<Tarefa>("A Prioridade da tarefa deve ser um número entre 1 a 5.");
			}


			//tudo certo, só atualizar
			resultado.Prioridade = model.Prioridade;


			_dbContext.Tarefas.Add(resultado).State = EntityState.Modified;
			_dbContext.SaveChanges();

			return new ServiceResponse<Tarefa>(resultado);
		}




		// Excluir uma tarefa por Id
		public ServiceResponse<bool> Deletar(int id)
		{
			// select top 1 * from tarefas x where x.IdTarefa == id 
			var resultado = _dbContext.Tarefas.FirstOrDefault(x => x.IdTarefa == id);
			

			if (resultado == null)
				return new ServiceResponse<bool>("Tarefa não encontrada!");


			//tudo certo, só atualizar
			_dbContext.Tarefas.Remove(resultado);
			_dbContext.SaveChanges();

			return new ServiceResponse<bool>(true);
		}


	}
}

