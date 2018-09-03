using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class GrauInstitucao
    {
        public int IdGrau { get; set; }
        public string DescGrau { get; set; }
        public string CodigoGrau { get; set; }
        public int? FgAtivo { get; set; }
    }
}
