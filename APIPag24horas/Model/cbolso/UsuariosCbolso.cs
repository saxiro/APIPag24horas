using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class UsuariosCbolso
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int? IdArea { get; set; }
    }
}
