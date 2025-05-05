using Iteris.AppEventos.API.Domain.DTO;
using Iteris.AppEventos.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.AppEventos.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class AlbunsController : ControllerBase
	{

		private readonly CategoriasServices categoriaService;

		public AlbunsController(CategoriasServices categoriaService)
		{
			this.categoriaService = categoriaService;
		}

		[HttpGet]
		public IEnumerable<CategoriaResponse> Get()
		{
			return categoriaService.ListarTodos();
		}
	}
}
