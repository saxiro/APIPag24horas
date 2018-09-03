using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class ConfigEmpresa
    {
        public int IdEmpresa { get; set; }
        public int? DiasEmailVencimento { get; set; }
        public int? TipoImpostoIss { get; set; }
    }
}
