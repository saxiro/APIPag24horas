using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Impostos
    {
        public int IdImposto { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public string Nome { get; set; }
        public string Conta { get; set; }
        public int FgAtivo { get; set; }
        public string ContaOrigen { get; set; }
        public string ContaReter { get; set; }
        public string ContaTotalizadora { get; set; }
        public string Uso { get; set; }
        public int? Tipo { get; set; }
        public sbyte TipoTributacao { get; set; }
        public sbyte FgReter { get; set; }
        public int? IdConta { get; set; }
        public int? IdContaorigen { get; set; }
        public int? IdContareter { get; set; }
        public int? IdContatotalizadora { get; set; }
        public int? IdContapadre { get; set; }
        public string CodigoReceita { get; set; }
    }
}
