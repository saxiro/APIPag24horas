using APIPag24horas.Data.cbolso.VO;
using APIPag24horas.Data.Converter;
using APIPag24horas.Model.cbolso;
using System.Collections.Generic;
using System.Linq;

namespace APIPag24horas.Data.cbolso.Converters
{
    public class UsuariosConverter : IParser<UsuariosVO, Usuarios>, IParser<Usuarios, UsuariosVO>
    {
        public Usuarios Parse(UsuariosVO origin)
        {
            if (origin == null) return new Usuarios();
            return new Usuarios
            {
               id_usuario = origin.id_usuario,
               email = origin.email,
               senha = origin.senha,
               tipo = origin.tipo,
               fg_ativo = origin.fg_ativo,
               plano = origin.plano,
               tempo = origin.tempo,
               ate_quando = origin.ate_quando,
               cnpj = origin.cnpj,
               nome = origin.nome,
               data_assinatura = origin.data_assinatura
            };
        }

        public UsuariosVO Parse(Usuarios origin)
        {
            if (origin == null) return new UsuariosVO();
            return new UsuariosVO
            {
                id_usuario = origin.id_usuario,
                email = origin.email,
                senha = origin.senha,
                tipo = origin.tipo,
                fg_ativo = origin.fg_ativo,
                plano = origin.plano,
                tempo = origin.tempo,
                ate_quando = origin.ate_quando,
                cnpj = origin.cnpj,
                nome = origin.nome,
                data_assinatura = origin.data_assinatura
            };
        }

        public List<Usuarios> ParseList(List<UsuariosVO> origin)
        {
            if (origin == null) return new List<Usuarios>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<UsuariosVO> ParseList(List<Usuarios> origin)
        {
            if (origin == null) return new List<UsuariosVO>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
