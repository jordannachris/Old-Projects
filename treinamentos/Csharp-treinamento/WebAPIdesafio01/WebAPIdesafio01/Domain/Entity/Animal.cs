using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIdesafio01.Domain.Entity
{
    public class Animal
    {
		public int IdAnimal { get; set; }

		public string Nome { get; set; }

		public int? Idade { get; set; }

		public string Especie { get; set; }

		public DateTime? DataNascimento { get; set; }

		public int? NivelFofura { get; set; }

		public int? NivelCarinho { get; set; }

		public string Email { get; set; }

	}
}
