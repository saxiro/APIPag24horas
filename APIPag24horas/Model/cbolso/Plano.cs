using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Plano
    {
        public int IdEmpresa { get; set; }
        public int QtdSocios { get; set; }
        public int? QtdFuncionarios { get; set; }
        public int IdFaturamento { get; set; }
        public sbyte IdTipo { get; set; }
    }
}
