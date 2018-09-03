using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class ImpostosBoletos
    {
        public int IdBoleto { get; set; }
        public int? IdEmpresa { get; set; }
        public decimal? Valor { get; set; }
        public int? TipoImposto { get; set; }
        public int? IdPlanegamento { get; set; }
        public int? FgPago { get; set; }
        public int? FgAtivo { get; set; }
        public string DataMa { get; set; }
        public decimal? ValorFaturamento { get; set; }
        public DateTime? DataApuracao { get; set; }
        public decimal? BaseCalculo { get; set; }
    }
}
