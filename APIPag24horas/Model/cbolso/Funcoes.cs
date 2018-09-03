using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Funcoes
    {
        public int IdFuncao { get; set; }
        public int IdFuncionario { get; set; }
        public int NumFuncao { get; set; }
        public string DescFuncao { get; set; }
        public int FgAtivo { get; set; }
        public string CodigoCbo { get; set; }
        public string Cbo { get; set; }
    }
}
