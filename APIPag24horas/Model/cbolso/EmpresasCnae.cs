using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class EmpresasCnae
    {
        public int Id { get; set; }
        public int? IdEmpresa { get; set; }
        public string Descricao { get; set; }
        public string Numero { get; set; }
        public sbyte? FgPrincipal { get; set; }
        public string CodigoServico { get; set; }
    }
}
