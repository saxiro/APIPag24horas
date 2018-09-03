using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Inadimplencias
    {
        public int IdInadimplencia { get; set; }
        public int? IdEmpresa { get; set; }
        public string Descricao { get; set; }
        public int? FgVotoconfianca { get; set; }
        public DateTime? DataConfianca { get; set; }
        public int? Tipo { get; set; }
        public int? FgAtivo { get; set; }
        public int? Status { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
