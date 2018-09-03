using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Bancos
    {
        public int IdBanco { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public string Nome { get; set; }
        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public decimal SaldoPlanegado { get; set; }
        public int FgAtivo { get; set; }
        public string Conta { get; set; }
        public int IdSaldo { get; set; }
        public DateTime DataContabil { get; set; }
        public int? IdConta { get; set; }
    }
}
