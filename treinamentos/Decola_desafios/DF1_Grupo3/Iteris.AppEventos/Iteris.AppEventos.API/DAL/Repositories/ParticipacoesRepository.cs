using Iteris.AppEventos.API.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.AppEventos.API.DAL.Repositories
{
	public class ParticipacoesRepository
	{
		private readonly projeto_app_eventosContext _eventosContext;

		public ParticipacoesRepository(projeto_app_eventosContext eventosContext)
		{
			_eventosContext = eventosContext;
		}

		//Async é a forma de usar programação assincrona
		//Isso otimiza o uso do processador
		public async Task<Participacao> PesquisaPorId(int id)
		{
			// select top 1 * from Customers
			return await _eventosContext.Participacaos.FindAsync(id);
		}



		// se o metodo é async sempre devemos retornar uma Task
		public async Task<Participacao> CadastrarParticipacao(Participacao novo)
		{
			_eventosContext.Participacaos.Add(novo);
			await _eventosContext.SaveChangesAsync(); // Todo o Entiy está preparado para isso
			return novo;
		}

		/*
		public async Task<List<Participacao>> Pesquisar(int paginaAtual, int qtdPagina)
		{

			// Estou na página 4 (começando em 0), e tem 20 itens por página
			// descarto os primeiro 80, pego os próximos 20
			int qtaPaginasAnteriores = paginaAtual * qtdPagina;

			return await _eventosContext.Participacaos.Skip(qtaPaginasAnteriores).Take(qtdPagina).ToListAsync();
		}*/
	}
}
