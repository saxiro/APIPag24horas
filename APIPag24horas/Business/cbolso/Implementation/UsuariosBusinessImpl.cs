

using APIPag24horas.Business.cbolso.Implementations;
using APIPag24horas.Data.cbolso.Converters;
using APIPag24horas.Data.cbolso.VO;
using APIPag24horas.Repository.cbolso;
using System.Collections.Generic;

namespace APIPag24horas.Business.cbolso.Implementattions
{
    public class UsuariosBusinessImpl : IUsuariosBusiness
    {
        private IUsuariosRepository _repository;
        private readonly UsuariosConverter _converter;

        public UsuariosBusinessImpl(IUsuariosRepository repository)
        {
            _repository = repository;
            _converter = new UsuariosConverter();
        }

        public UsuariosVO Create(UsuariosVO item)
        {
            var UsuariosEntity = _converter.Parse(item);
            UsuariosEntity = _repository.Create(UsuariosEntity);
            return _converter.Parse(UsuariosEntity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<UsuariosVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }


        public UsuariosVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public UsuariosVO Update(UsuariosVO item)
        {
            var UsuariosEntity = _converter.Parse(item);
            UsuariosEntity = _repository.Update(UsuariosEntity);
            return _converter.Parse(UsuariosEntity);
        }
        public bool Exists(int id)
        {
            return _repository.Exists(id);
        }
    }
}
