using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPIdesafio03.Domain.Entity
{
    public partial class Video
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string UrlVideo { get; set; }
        public int? IdadeMinima { get; set; }
        public int IdResponsavel { get; set; }
    }
}
