using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class ReciboFolhaPagamento
    {
        public int IdRecibo { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdRequisitado { get; set; }
        public int? TipoRequisitado { get; set; }
        public decimal? Prolabore { get; set; }
        public decimal? Inss { get; set; }
        public decimal? Ir { get; set; }
        public string DataMa { get; set; }
        public int? FgAtivo { get; set; }
        public decimal? PercentualInss { get; set; }
        public decimal? PercentualIr { get; set; }
        public decimal? ValorDependente { get; set; }
    }
}
