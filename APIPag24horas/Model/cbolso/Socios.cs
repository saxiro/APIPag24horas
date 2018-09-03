using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Socios
    {
        public int IdSocio { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Ci { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string LocalNascimento { get; set; }
        public string Pai { get; set; }
        public string Mae { get; set; }
        public string EstadoCivil { get; set; }
        public int Regime { get; set; }
        public int FgAtivo { get; set; }
        public string Pis { get; set; }
        public sbyte? Admin { get; set; }
        public float? PercentualCapital { get; set; }
        public float? ValorCapital { get; set; }
        public string Endereco { get; set; }
        public string Profissao { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Nr { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int? IdCidade { get; set; }
        public sbyte? Validado { get; set; }
        public string MotivoRecusa { get; set; }
        public string Orgao { get; set; }
        public int? EstadoOrgao { get; set; }
        public string Identidade { get; set; }
        public string Nomepai { get; set; }
        public string Nomemae { get; set; }
        public DateTime? DataDemissao { get; set; }
        public decimal? Prolabore { get; set; }
        public DateTime? DataAdmissao { get; set; }
        public sbyte? FgProlabore { get; set; }
        public int? QtdDependentes { get; set; }
    }
}
