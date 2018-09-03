using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class FranquiasBancos
    {
        public int Id { get; set; }
        public int? IdFranquia { get; set; }
        public int? CodigoBanco { get; set; }
        public string NomeBanco { get; set; }
        public int? Agencia { get; set; }
        public int? Conta { get; set; }
        public int? Convenio { get; set; }
    }
}
