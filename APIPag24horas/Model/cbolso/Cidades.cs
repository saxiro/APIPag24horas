using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Cidades
    {
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public sbyte Estado { get; set; }
        public int? Codmun { get; set; }
        public string SiteNfe { get; set; }
    }
}
