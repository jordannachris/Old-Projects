﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Loja.API.Domain.DTO
{
	public class CustomerCreateRequest
	{
		[Required]
		[StringLength(40)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(40)]
		public string LastName { get; set; }

		[StringLength(20)]
		public string City { get; set; }

		[StringLength(20)]
		public string Country { get; set; }

		[StringLength(20)]
		public string Phone { get; set; }
	}
}
