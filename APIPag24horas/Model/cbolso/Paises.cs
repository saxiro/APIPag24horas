using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Paises
    {
        public int IdPais { get; set; }
        public string Nome { get; set; }
        public string CiudadanoDes { get; set; }
        public string CodigoPais { get; set; }
        public int? FgAtivo { get; set; }
    }
}
