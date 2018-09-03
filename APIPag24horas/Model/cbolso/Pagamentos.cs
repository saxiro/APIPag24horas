using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Pagamentos
    {
        public int IdPagamento { get; set; }
        public int IdUsuario { get; set; }
        public string Plano { get; set; }
        public DateTime Data { get; set; }
        public string Token { get; set; }
        public int FgAtivo { get; set; }
        public DateTime? InicioPeriodo { get; set; }
        public DateTime? FimPeriodo { get; set; }
        public int IdEmpresa { get; set; }
        public string Referencia { get; set; }
    }
}
