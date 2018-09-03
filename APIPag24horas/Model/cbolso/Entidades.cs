using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Entidades
    {
        public int IdEntidad { get; set; }
        public string CodEntidad { get; set; }
        public string Entidad { get; set; }
        public string NomeEntidad { get; set; }
        public string Apelido { get; set; }
        public string TipoEntidad { get; set; }
        public string AgenciaGrcs { get; set; }
        public string CodCedente { get; set; }
        public string Logradouro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string IdCidade { get; set; }
        public string NomeCidade { get; set; }
        public string Estado { get; set; }
        public string Ddd { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public string Cnpj { get; set; }
        public string Site { get; set; }
        public string Email { get; set; }
        public int? FgAtivo { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }
    }
}
