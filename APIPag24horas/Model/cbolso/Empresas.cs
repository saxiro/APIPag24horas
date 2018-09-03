using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Empresas
    {
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Inscripcao { get; set; }
        public string Senha { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public string Nr { get; set; }
        public string Complemento { get; set; }
        public string Barrio { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Nire { get; set; }
        public string CnaeP { get; set; }
        public string DescripcaoP { get; set; }
        public string CnaeS { get; set; }
        public string DescripcaoS { get; set; }
        public int FgAtivo { get; set; }
        public DateTime DataRegistro { get; set; }
        public string Orgao { get; set; }
        public int IdCidade { get; set; }
        public DateTime DataAutomatica { get; set; }
        public DateTime? DataAssinatura { get; set; }
        public sbyte? QuantSocios { get; set; }
        public sbyte? QuantFuncionarios { get; set; }
        public int? IdFaturamentoMensal { get; set; }
        public string NaturalezaJur { get; set; }
        public sbyte? Tributacao { get; set; }
        public string LoginPrefeitura { get; set; }
        public string SenhaPrefeitura { get; set; }
        public sbyte? PrefeituraValidado { get; set; }
        public string MotivoRecusa { get; set; }
        public sbyte? TipoEmpresa { get; set; }
        public string NomeFantasia { get; set; }
        public int? Iptu { get; set; }
        public float? ValorCapital { get; set; }
        public string Atividade { get; set; }
        public sbyte? Aprovado { get; set; }
        public DateTime? MesResponsabilidade { get; set; }
        public sbyte? DocIdentidade { get; set; }
        public sbyte? DocContrato { get; set; }
        public sbyte? DocIptu { get; set; }
        public sbyte? DocBomb { get; set; }
        public sbyte? FlagSocios { get; set; }
        public sbyte? FlagFuncionarios { get; set; }
        public sbyte? FlagResumo { get; set; }
        public sbyte? ValidadoEmp { get; set; }
        public sbyte? FgRetencoes { get; set; }
        public sbyte? TipoCadastro { get; set; }
        public sbyte? Status { get; set; }
        public sbyte? FgDocssocio { get; set; }
        public string Telefone { get; set; }
        public DateTime? DataAprovacao { get; set; }
        public sbyte? RegimeCaixa { get; set; }
        public DateTime? DataRecisao { get; set; }
    }
}
