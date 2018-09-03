using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class NotaFiscal
    {
        public int IdNota { get; set; }
        public int? IdEmpresa { get; set; }
        public string Codver { get; set; }
        public int? Numero { get; set; }
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal? ValorCredito { get; set; }
        public DateTime? Competencia { get; set; }
        public decimal? ValorServicos { get; set; }
        public decimal? ValorDeducoes { get; set; }
        public decimal? ValorPis { get; set; }
        public decimal? ValorCofins { get; set; }
        public decimal? ValorInss { get; set; }
        public decimal? ValorIr { get; set; }
        public decimal? ValorCsll { get; set; }
        public decimal? OutrasReten { get; set; }
        public decimal? ValorIss { get; set; }
        public decimal? Aliquota { get; set; }
        public decimal? DescontoCondicionado { get; set; }
        public int? FgImportado { get; set; }
        public int? IdCliente { get; set; }
        public int? FgIssretido { get; set; }
        public int? FgCancelado { get; set; }
        public string Discriminacao { get; set; }
        public string Cnae { get; set; }
        public int? FgExigibilidade { get; set; }
        public string CodigoServico { get; set; }
    }
}
