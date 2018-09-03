using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class ReciboGps
    {
        public int IdRecibo { get; set; }
        public int? IdEmpresa { get; set; }
        public decimal? ValorInss { get; set; }
        public DateTime? DataRegistro { get; set; }
        public string DataMa { get; set; }
        public int? FgAtivo { get; set; }
    }
}
