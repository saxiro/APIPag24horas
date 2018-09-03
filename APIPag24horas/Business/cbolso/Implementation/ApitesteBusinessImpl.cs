

using APIPag24horas.Business.cbolso.Implementations;
using APIPag24horas.Data.cbolso.Converters;
using APIPag24horas.Data.cbolso.VO;
using APIPag24horas.Model.cbolso;
using APIPag24horas.Repository.cbolso.Generic;
using System.Collections.Generic;

namespace APIPag24horas.Business.cbolso.Implementattions
{
    public class ApitesteBusinessImpl : IApitesteBusiness
    {
        private IRepository<Apiteste> _repository;
        private readonly ApitesteConverter _converter;

        public ApitesteBusinessImpl(IRepository<Apiteste> repository)
        {
            _repository = repository;
            _converter = new ApitesteConverter();
        }

        public ApitesteVO Create(ApitesteVO item)
        {
            var ApitesteEntity = _converter.Parse(item);
            ApitesteEntity = _repository.Create(ApitesteEntity);
            return _converter.Parse(ApitesteEntity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<ApitesteVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }


        public ApitesteVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public ApitesteVO Update(ApitesteVO item)
        {
            var ApitesteEntity = _converter.Parse(item);
            ApitesteEntity = _repository.Update(ApitesteEntity);
            return _converter.Parse(ApitesteEntity);
        }
        public bool Exists(int id)
        {
            return _repository.Exists(id);
        }
    }
}
