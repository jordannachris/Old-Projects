using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIdesafio01.Domain.DTO;
using WebAPIdesafio01.Domain.Entity;
using WebAPIdesafio01.Services.Base;

namespace WebAPIdesafio01.Services
{
    public class AnimalService
    {
		

		private static List<Animal> listaDeAnimais; // fake, só para aprendizado
		private static int proximoId = 1;


		//iniciar a lista de albuns no construtor da classe
		
		public AnimalService()
		{

			if (listaDeAnimais == null)
			{
				listaDeAnimais = new List<Animal>();	

			} //FIM DO IF
		}


		public ServiceResponse<Animal> CadastrarNovo(AnimalCreateRequest model)
		{
			//REGRAS

			// REGRAS DE ESPÉCIE
			if(	(model.Especie == null) || 
				( (model.Especie != "Cachorro" && model.Especie != "cachorro") && 
				(model.Especie != "Gato" && model.Especie != "gato") && 
				(model.Especie != "Coelho" && model.Especie != "coelho") && 
				(model.Especie != "Capivara" && model.Especie != "capivara")) )
			{
				return new ServiceResponse<Animal>("Jordanna, você está cagando na parte da ESPÉCIE.");
			}


			//REGRAS DE NÍVEL DE FOFURA
			if (!model.NivelFofura.HasValue || (model.NivelFofura < 1 || model.NivelFofura > 5))
			{
				return new ServiceResponse<Animal>("Jordanna, você está cagando na parte do NÍVEL DE FOFURA.");
			}


			//REGRAS DE NÍVEL DE CARINHO
			if (!model.NivelCarinho.HasValue || (model.NivelCarinho < 1 || model.NivelCarinho > 5))
			{
				return new ServiceResponse<Animal>("Jordanna, você está cagando na parte do NÍVEL DE CARINHO.");
			}



			//tudo certo, só cadastrar
			var novoAnimal = new Animal()
			{
				IdAnimal = proximoId++,

				Nome = model.Nome,

				Idade = model.Idade.Value,

				Especie = model.Especie,

				DataNascimento = model.DataNascimento, 

				NivelFofura = model.NivelFofura.Value,

				NivelCarinho = model.NivelCarinho.Value,

				Email = model.Email
			};

			listaDeAnimais.Add(novoAnimal);

			return new ServiceResponse<Animal>(novoAnimal);

		} // FIM de CadastrarNovo()


		public List<Animal> ListarTodos()
		{
			return listaDeAnimais;
		}

		public ServiceResponse<Animal> PesquisarPorId(int id)
		{
			// Lambda Expression / Expressões lambda
			// Operação em conjunto de dados
			// select top 1 * from animais x where x.IdAnimal == id 
			var resultado = listaDeAnimais.Where(x => x.IdAnimal == id).FirstOrDefault();
			if (resultado == null)
				return new ServiceResponse<Animal>("Não encontrado!");
			else
				return new ServiceResponse<Animal>(resultado);

		}

		public ServiceResponse<Animal> PesquisarPorNome(string nome)
		{
			// Lambda Expression / Expressões lambda
			// Operação em conjunto de dados
			// select top 1 * from animais x where x.IdAnimal == id 
			var resultado = listaDeAnimais.Where(x => x.Nome == nome).FirstOrDefault();
			if (resultado == null)
				return new ServiceResponse<Animal>("Não encontrado!");
			else
				return new ServiceResponse<Animal>(resultado);
		}

		public ServiceResponse<Animal> Editar(int id, AnimalUpdateRequest model)
		{
			// select top 1 * from albuns x where x.IdAlbum == id 
			var resultado = listaDeAnimais.Where(x => x.IdAnimal == id).FirstOrDefault();

			if (resultado == null)
				return new ServiceResponse<Animal>("Animal não encontrado!");

			//tudo certo, só atualizar
			resultado.Especie = model.Especie;

			return new ServiceResponse<Animal>(resultado);
		}

		public ServiceResponse<bool> Deletar(int id)
		{
			// select top 1 * from animais x where x.IdAlbum == id 
			var resultado = listaDeAnimais.Where(x => x.IdAnimal == id).FirstOrDefault();

			if (resultado == null)
				return new ServiceResponse<bool>("Animal não encontrado!");

			//tudo certo, só atualizar
			listaDeAnimais.Remove(resultado);

			return new ServiceResponse<bool>(true);
		}


	}
}






