using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class PlanoContaEstatico
    {
        public int Id { get; set; }
        public string Conta { get; set; }
        public string Nome { get; set; }
        public int? ContaTotalizadora { get; set; }
        public string ContaContrapartida { get; set; }
        public int? IdContrapartida { get; set; }
        public int? FgAtivo { get; set; }
    }
}
