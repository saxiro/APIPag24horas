using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class CnaesTemporal
    {
        public string Codigo { get; set; }
        public string Cnae { get; set; }
        public int? Fpas { get; set; }
        public int? Rat { get; set; }
        public int Id { get; set; }
        public decimal? Fap { get; set; }
        public int? IdCidade { get; set; }
    }
}
