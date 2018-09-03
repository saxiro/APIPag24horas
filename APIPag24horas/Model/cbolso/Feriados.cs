using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Feriados
    {
        public int IdFeriado { get; set; }
        public string DescFeriado { get; set; }
        public string Dia { get; set; }
        public string Mes { get; set; }
        public string Ano { get; set; }
        public int? FgAtivo { get; set; }
    }
}
