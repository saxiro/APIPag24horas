using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class ImpostosEmpresas
    {
        public int IdImposto { get; set; }
        public int IdEmpresa { get; set; }
        public int? FgAtivo { get; set; }
        public int IdLink { get; set; }
        public int? IdConta { get; set; }
    }
}
