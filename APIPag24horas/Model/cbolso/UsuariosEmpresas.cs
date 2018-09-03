using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class UsuariosEmpresas
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public sbyte TipoUsuario { get; set; }
        public string Nome { get; set; }
        public sbyte? Estado { get; set; }
        public sbyte? FaseCadastro { get; set; }
        public string Telefone { get; set; }
        public sbyte? FgAtivo { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int? FgAddwords { get; set; }
        public sbyte? FlagWhatsFeira { get; set; }
    }
}
