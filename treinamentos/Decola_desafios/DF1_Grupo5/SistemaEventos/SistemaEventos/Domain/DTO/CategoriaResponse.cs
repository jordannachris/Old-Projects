﻿using SistemaEventos.Domain.Entity;

namespace SistemaEventos.Domain.DTO
{
    public class CategoriaResponse
    {
        public CategoriaResponse(CategoriaEvento categoriaResponse)
        {
            IdCategoria = categoriaResponse.IdCategoriaEvento;
            NomeCategoria = categoriaResponse.NomeCategoria;
        }

        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
    }
}
