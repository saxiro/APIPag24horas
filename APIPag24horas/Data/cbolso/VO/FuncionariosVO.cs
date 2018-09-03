using System;
using System.Collections.Generic;
using Tapioca.HATEOAS;

namespace APIPag24horas.Data.cbolso.VO
{
    public partial class FuncionariosVO : ISupportsHyperMedia
    {
        public int Idfuncionario { get; set; }
        public int Idempresa { get; set; }
        public int Idusuario { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Nr { get; set; }
        public string Complemento { get; set; }
        public string Barrio { get; set; }
        public int IdCidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public int FgAtivo { get; set; }
        public string TipoSanguineo { get; set; }
        public string Raca { get; set; }
        public string CorCabelo { get; set; }
        public string CorOlhos { get; set; }
        public string Sexo { get; set; }
        public string Deficiencia { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string CidadeNasc { get; set; }
        public string Tipo { get; set; }
        public decimal Salario { get; set; }
        public int PrazoExp { get; set; }
        public DateTime FinPrazo { get; set; }
        public int Prorrogacao { get; set; }
        public DateTime FinProrrogacao { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string NomeConjuge { get; set; }
        public DateTime DataChegada { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public sbyte GrauInst { get; set; }
        public DateTime Admissao { get; set; }
        public string TipoAdmissao { get; set; }
        public int IdContrato { get; set; }
        public string NaturezaOcupacao { get; set; }
        public sbyte EstadoCivil { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataAposentadoria { get; set; }
        public DateTime Cadastro { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Pis { get; set; }
        public DateTime DataEmissaoPis { get; set; }
        public string UfRg { get; set; }
        public string OrgaoRg { get; set; }
        public DateTime DataEmissaoRg { get; set; }
        public string Carteira { get; set; }
        public string Serie { get; set; }
        public string Digito { get; set; }
        public DateTime DataEmissaoCarteira { get; set; }
        public string UfCarteira { get; set; }
        public string Cnh { get; set; }
        public string CategoriaCnh { get; set; }
        public string EstadoNasc { get; set; }
        public decimal Insalubridade { get; set; }
        public string InsalubridadeI { get; set; }
        public decimal Periculosidade { get; set; }
        public string PericulosidadeI { get; set; }
        public decimal Noturno { get; set; }
        public string NoturnoI { get; set; }
        public string Conta { get; set; }
        public string Cargo { get; set; }
        public int? IdFuncao { get; set; }
        public bool? Validado { get; set; }
        public string MotivoRecusa { get; set; }
        public int? IdConta { get; set; }
        public int? IdPaisNacionalidade { get; set; }
        public int? IdPaisNascimento { get; set; }
        public int? IdCidadeNascimento { get; set; }
        public int? FgPrimeroEmprego { get; set; }
        public string Nis { get; set; }
        public int? IdCondicaoExt { get; set; }
        public int? FgCasadoExt { get; set; }
        public int? FgFilhosExt { get; set; }
        public bool? FgAposentadoria { get; set; }
        public int? IdEstado { get; set; }
        public DateTime? DataAviso { get; set; }
        public DateTime? DataDemissao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool? Dependente { get; set; }
        public bool? TipoHorarioTrabalho { get; set; }
        public int Horas { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
