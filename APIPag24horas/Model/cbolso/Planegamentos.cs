using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Planegamentos
    {
        public int IdPlanegamento { get; set; }
        public int TipoPago { get; set; }
        public int TipoExtra { get; set; }
        public decimal Extra { get; set; }
        public decimal Total { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public int Tipo { get; set; }
        public int IdFornecedor { get; set; }
        public string Conta { get; set; }
        public DateTime Data { get; set; }
        public string Historico { get; set; }
        public decimal Valor { get; set; }
        public int FgAtivo { get; set; }
        public int IdSaldo { get; set; }
        public int IdMovimento { get; set; }
        public string Origen { get; set; }
        public DateTime DataBaixa { get; set; }
        public DateTime DataReferencia { get; set; }
        public int FgDireto { get; set; }
        public int FgParcelado { get; set; }
        public decimal Retencao { get; set; }
        public string NotaFiscal { get; set; }
        public int TipoOrigen { get; set; }
        public int? IdPlanegamentoOrigen { get; set; }
        public int? IdConta { get; set; }
        public int? IdContaorigen { get; set; }
        public int? NumDoc { get; set; }
    }
}
