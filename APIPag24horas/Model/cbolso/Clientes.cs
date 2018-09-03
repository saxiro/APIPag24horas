using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Clientes
    {
        public int IdCliente { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Nr { get; set; }
        public string Complemento { get; set; }
        public string Barrio { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Conta { get; set; }
        public int FgAtivo { get; set; }
        public string ContaOrigen { get; set; }
        public string Calsificacao { get; set; }
        public int? IdConta { get; set; }
        public int? IdContaorigen { get; set; }
    }
}
