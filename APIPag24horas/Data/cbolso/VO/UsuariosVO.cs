using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Tapioca.HATEOAS;

namespace APIPag24horas.Data.cbolso.VO
{
    public partial class UsuariosVO : ISupportsHyperMedia
    {
        public int id_usuario { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public int tipo { get; set; }
        public int fg_ativo { get; set; }
        public string plano { get; set; }
        public string tempo { get; set; }
        public DateTime? ate_quando { get; set; }
        public string cnpj { get; set; }
        public string nome { get; set; }
        public DateTime? data_assinatura { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
