using APIPag24horas.Model.cbolso.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIPag24horas.Model.cbolso
{
    [Table("apiteste")]
    public partial class Apiteste : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
