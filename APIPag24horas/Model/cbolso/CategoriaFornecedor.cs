using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class CategoriaFornecedor
    {
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public string Conta { get; set; }
        public int FgAtivo { get; set; }
        public string ContaPadre { get; set; }
        public int? IdConta { get; set; }
        public int? IdContapadre { get; set; }
    }
}
