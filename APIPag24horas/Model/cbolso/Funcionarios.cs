using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIPag24horas.Model.cbolso
{
    [Table("funcionarios")]
    public partial class Funcionarios
    {
        [Key]
        public int id_funcionario { get; set; }

        public int id_empresa { get; set; }
        public int id_usuario { get; set; }
        public string nome { get; set; }
        public string cep { get; set; }
        public string rua { get; set; }
        public string nr { get; set; }
        public string complemento { get; set; }
        public string barrio { get; set; }
        public int id_cidade { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public int fg_ativo { get; set; }
        public string tipo_sanguineo { get; set; }
        public string raca { get; set; }
        public string cor_cabelo { get; set; }
        public string cor_olhos { get; set; }
        public string sexo { get; set; }
        public string deficiencia { get; set; }
        public decimal altura { get; set; }
        public decimal peso { get; set; }
        public string cidade_nasc { get; set; }
        public string tipo { get; set; }
        public decimal salario { get; set; }
        public int prazo_exp { get; set; }
        public DateTime fin_prazo { get; set; }
        public int prorrogacao { get; set; }
        public DateTime fin_prorrogacao { get; set; }
        public string nome_pai { get; set; }
        public string nome_mae { get; set; }
        public string nome_conjuge { get; set; }
        public DateTime data_chegada { get; set; }
        public string nacionalidade { get; set; }
        public DateTime data_nascimento { get; set; }
        public sbyte grau_inst { get; set; }
        public DateTime admissao { get; set; }
        public string tipo_admissao { get; set; }
        public int id_contrato { get; set; }
        public string natureza_ocupacao { get; set; }
        public sbyte estado_civil { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_aposentadoria { get; set; }
        public DateTime cadastro { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string pis { get; set; }
        public DateTime data_emissao_pis { get; set; }
        public string uf_rg { get; set; }
        public string orgao_rg { get; set; }
        public DateTime data_emissao_rg { get; set; }
        public string carteira { get; set; }
        public string serie { get; set; }
        public string digito { get; set; }
        public DateTime data_emissao_carteira { get; set; }
        public string uf_carteira { get; set; }
        public string cnh { get; set; }
        public string categoria_cnh { get; set; }
        public string estado_nasc { get; set; }
        public decimal insalubridade { get; set; }
        public string insalubridade_i { get; set; }
        public decimal periculosidade { get; set; }
        public string periculosidade_i { get; set; }
        public decimal noturno { get; set; }
        public string noturno_i { get; set; }
        public string conta { get; set; }
        public string cargo { get; set; }
        public int? id_funcao { get; set; }
        public bool? validado { get; set; }
        public string motivo_recusa { get; set; }
        public int? id_conta { get; set; }
        public int? idPais_nacionalidade { get; set; }
        public int? idPais_nascimento { get; set; }
        public int? idCidade_nascimento { get; set; }
        public int? fg_primero_emprego { get; set; }
        public string nis { get; set; }
        public int? id_condicao_ext { get; set; }
        public int? fg_casado_ext { get; set; }
        public int? fg_filhos_ext { get; set; }
        public bool? fg_aposentadoria { get; set; }
        public int? id_estado { get; set; }
        public DateTime? data_aviso { get; set; }
        public DateTime? data_demissao { get; set; }
        public DateTime? data_cadastro { get; set; }
        public bool? dependente { get; set; }
        public bool? tipo_horario_trabalho { get; set; }
        public int horas { get; set; }
    }
}
