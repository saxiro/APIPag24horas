using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Noticias
    {
        public int IdNoticia { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public int? FgAtivo { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public int? Views { get; set; }
    }
}
