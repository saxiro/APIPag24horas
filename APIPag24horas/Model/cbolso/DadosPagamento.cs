using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class DadosPagamento
    {
        public int Id { get; set; }
        public long? Numero { get; set; }
        public sbyte? Cvv { get; set; }
        public string Vencimento { get; set; }
        public int? IdEmpresa { get; set; }
    }
}
