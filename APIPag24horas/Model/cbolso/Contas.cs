using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Contas
    {
        public string Conta { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public int IdUsuario { get; set; }
        public int IdConta { get; set; }
        public int FgAtivo { get; set; }
        public int? IdEmpresa { get; set; }
        public int? NumContafilha { get; set; }
        public int? IdContapadre { get; set; }
    }
}
