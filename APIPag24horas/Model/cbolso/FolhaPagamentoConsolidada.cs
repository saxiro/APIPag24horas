using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class FolhaPagamentoConsolidada
    {
        public int Id { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdFuncionario { get; set; }
        public int? Mes { get; set; }
        public float? BaseInss { get; set; }
        public float? BaseIrpf { get; set; }
        public float? BaseFgts { get; set; }
        public float? ValorLiquido { get; set; }
        public float? ValorFgts { get; set; }
        public float? ValorInss { get; set; }
        public float? ValorIrpf { get; set; }
    }
}
