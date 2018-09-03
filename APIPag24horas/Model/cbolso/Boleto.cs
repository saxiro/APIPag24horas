using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Boleto
    {
        public int Id { get; set; }
        public int? IdEmpresa { get; set; }
        public decimal Valor { get; set; }
        public sbyte? Situacao { get; set; }
        public sbyte? Remessa { get; set; }
        public sbyte? FgGerado { get; set; }
        public sbyte? FgPrimeiro { get; set; }
        public int? IdFaturamento { get; set; }
        public int? NumSocios { get; set; }
        public int? NumFuncionarios { get; set; }
        public decimal? ValorAdicional { get; set; }
        public DateTime? DataBoleto { get; set; }
        public string MesReferencia { get; set; }
        public sbyte? FgEmail { get; set; }
        public string CodMovimento { get; set; }
        public string MotivoOcorrencia { get; set; }
        public float? ValorPago { get; set; }
        public DateTime? DataPagamento { get; set; }
        public sbyte? TipoServico { get; set; }
    }
}
