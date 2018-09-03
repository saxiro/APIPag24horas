using System.Collections.Generic;
using APIPag24horas.Data.Converters;
using APIPag24horas.Data.VO;
using APIPag24horas.Repository.Generic;

namespace APIPag24horas.Business.Implementattions
{
	public class PersonBusinessImpl : IPersonBusiness
    {
        private IPersonRepository _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImpl(IPersonRepository repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public List<PersonVO> FindByName(string firstName, string lastName)
        {
            return _converter.ParseList(_repository.FindByName(firstName,lastName));
        }


        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }
    }
}
