using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDespensaAPI.Domain.Entity
{
	[Table("Usuario")]
	public class Usuario
	{
		[Key]
		public int id { get; set; }


		[StringLength(255)]
		public string nome { get; set; }


		[StringLength(255)]
		public string senha { get; set; }


		[StringLength(255)]
		public string email { get; set; }


		[StringLength(150)]
		public string numCartao { get; set; }


		public virtual ICollection<Produto> Produtos { get; set; }
	}

}
