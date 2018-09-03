

using APIPag24horas.Business.cbolso.Implementations;
using APIPag24horas.Data.cbolso.Converters;
using APIPag24horas.Data.cbolso.VO;
using APIPag24horas.Repository.cbolso;
using System.Collections.Generic;

namespace APIPag24horas.Business.cbolso.Implementattions
{
    public class FuncionariosBusinessImpl : IFuncionariosBusiness
    {
        private IFuncionariosRepository _repository;
        private readonly FuncionariosConverter _converter;

        public FuncionariosBusinessImpl(IFuncionariosRepository repository)
        {
            _repository = repository;
            _converter = new FuncionariosConverter();
        }

        public FuncionariosVO Create(FuncionariosVO item)
        {
            var FuncionariosEntity = _converter.Parse(item);
            FuncionariosEntity = _repository.Create(FuncionariosEntity);
            return _converter.Parse(FuncionariosEntity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<FuncionariosVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }


        public FuncionariosVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public FuncionariosVO Update(FuncionariosVO item)
        {
            var FuncionariosEntity = _converter.Parse(item);
            FuncionariosEntity = _repository.Update(FuncionariosEntity);
            return _converter.Parse(FuncionariosEntity);
        }
        public bool Exists(int id)
        {
            return _repository.Exists(id);
        }
    }
}
