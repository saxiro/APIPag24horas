using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Franquias
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Endereco { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeResponsavel { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
    }
}
