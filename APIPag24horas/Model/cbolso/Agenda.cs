using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Agenda
    {
        public int IdObligacao { get; set; }
        public string Titulo { get; set; }
        public string Dia { get; set; }
        public string Mes { get; set; }
        public string Ano { get; set; }
        public sbyte? Tipo { get; set; }
        public int? IdEmpresa { get; set; }
        public string Descricao { get; set; }
    }
}
