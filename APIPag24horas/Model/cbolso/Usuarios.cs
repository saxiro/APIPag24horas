using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIPag24horas.Model.cbolso
{
    [Table("usuarios")]
    public partial class Usuarios
    {
        [Key]
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
    }
}
