using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class DasEmpresas
    {
        public int IdEmpresa { get; set; }
        public DateTime? DataDas { get; set; }
        public int? FgAtivo { get; set; }
        public DateTime? DataEnvio { get; set; }
        public int? FgEmail { get; set; }
        public int? FgGerado { get; set; }
        public int IdDas { get; set; }
    }
}
