using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Saldos
    {
        public int IdSaldo { get; set; }
        public string Conta { get; set; }
        public decimal Saldo { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public int FgAtivo { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime DataContabil { get; set; }
        public DateTime DataCaixa { get; set; }
        public decimal Credito { get; set; }
        public decimal Debito { get; set; }
        public int IdPlanegamento { get; set; }
        public string Historico { get; set; }
        public int FgRetencao { get; set; }
        public int? IdConta { get; set; }
    }
}
