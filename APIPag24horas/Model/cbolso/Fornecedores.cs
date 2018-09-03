using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Fornecedores
    {
        public int IdFornecedor { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public int IdCategoria { get; set; }
        public string Conta { get; set; }
        public int FgAtivo { get; set; }
        public string ContaOrigen { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public string Historico { get; set; }
        public int? IdConta { get; set; }
        public int? IdContaorigen { get; set; }
    }
}
