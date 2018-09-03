using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Cnaes
    {
        public string Codigo { get; set; }
        public string Cnae { get; set; }
        public int? Fpas { get; set; }
        public int? Rat { get; set; }
        public int Id { get; set; }
        public decimal? Fap { get; set; }
        public int? IdCidade { get; set; }
        public decimal? PresuncaoIrpj { get; set; }
        public decimal? AliquotaIrpj { get; set; }
        public decimal? PresuncaoCsll { get; set; }
        public decimal? AliquotaCsll { get; set; }
        public decimal? AliquotaPis { get; set; }
        public decimal? AliquotaCofins { get; set; }
    }
}
