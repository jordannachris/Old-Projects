using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace WebDespensaAPI.Domain.Entity
{
	[Table("Produto")]
	public class Produto
	{
		[Key]
		public int id { get; set; }


		public int idUsuario{ get; set; }


		[StringLength(255)]
		public string nome { get; set; }


		// virtual para indicar o relacionamento
		public virtual Usuario Usuario { get; set; }
	}
}