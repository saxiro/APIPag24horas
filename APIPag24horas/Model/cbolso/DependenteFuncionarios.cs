using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class DependenteFuncionarios
    {
        public int Id { get; set; }
        public int? IdFuncionario { get; set; }
        public string NomeDependente { get; set; }
        public DateTime? DataNascimento { get; set; }
        public sbyte? Parentesco { get; set; }
    }
}
