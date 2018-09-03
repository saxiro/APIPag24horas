using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Dependentes
    {
        public int IdDependente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Matricula { get; set; }
        public string LocalNascimento { get; set; }
        public string IdCidade { get; set; }
        public string NomeCidade { get; set; }
        public string Cartorio { get; set; }
        public string NumRegistro { get; set; }
        public string NumLivro { get; set; }
        public string NumFolha { get; set; }
        public DateTime DataEntrega { get; set; }
        public string Cpf { get; set; }
        public int TipoDependencia { get; set; }
        public DateTime DataBaixa { get; set; }
        public DateTime DataIrAte { get; set; }
        public int GrauParentesco { get; set; }
        public int? FgAtivo { get; set; }
        public int? Invalido { get; set; }
    }
}
