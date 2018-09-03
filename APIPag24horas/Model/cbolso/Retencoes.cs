using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Retencoes
    {
        public int IdRetencao { get; set; }
        public int IdPlanegamento { get; set; }
        public int IdImposto { get; set; }
        public decimal Valor { get; set; }
        public int FgAtivo { get; set; }
    }
}
