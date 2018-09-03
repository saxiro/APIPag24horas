using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class TabelaIr
    {
        public int Id { get; set; }
        public float? ValorInicio { get; set; }
        public float? ValorFim { get; set; }
        public string Percentual { get; set; }
    }
}
