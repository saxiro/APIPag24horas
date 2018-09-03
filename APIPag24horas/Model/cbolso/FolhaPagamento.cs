using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class FolhaPagamento
    {
        public int Id { get; set; }
        public int? IdFuncionario { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdVerba { get; set; }
        public int? Mes { get; set; }
        public float? Valor { get; set; }
        public float? Referencia { get; set; }
    }
}
