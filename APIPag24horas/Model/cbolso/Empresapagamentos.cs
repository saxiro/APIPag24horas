using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Empresapagamentos
    {
        public int IdEmpresa { get; set; }
        public int? IdFaturamento { get; set; }
        public int? NumFuncionarios { get; set; }
        public decimal? ValorAdicional { get; set; }
        public int? NumSocios { get; set; }
        public sbyte? DiaVencimento { get; set; }
        public sbyte? Tributacao { get; set; }
    }
}
