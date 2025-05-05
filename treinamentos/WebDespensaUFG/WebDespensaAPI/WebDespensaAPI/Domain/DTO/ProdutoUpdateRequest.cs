using System;
using System.ComponentModel.DataAnnotations;

namespace WebDespensaAPI.Domain.DTO
{
    public class ProdutoUpdateRequest
    {

        [Required(AllowEmptyStrings = false, ErrorMessage = "É preciso informar o nome do Produto.")]
        public string nome { get; set; }

    }
}
