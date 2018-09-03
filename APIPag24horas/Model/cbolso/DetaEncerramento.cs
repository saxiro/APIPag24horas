using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class DetaEncerramento
    {
        public int IdDeta { get; set; }
        public int IdEncerramento { get; set; }
        public string Conta { get; set; }
        public decimal Credito { get; set; }
        public decimal Debito { get; set; }
        public int IdSaldo { get; set; }
        public int IdUsuario { get; set; }
    }
}
