using APIPag24horas.Business;
using APIPag24horas.Model;
using APIPag24horas.Model.Context;
using APIPag24horas.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIPag24horas.Repository.Implementattions
{
    public class PersonRepositoryImpl: GenericRepository<Person>,IPersonRepository
    {

        public PersonRepositoryImpl(MySQLContext context) : base (context){}

        public List<Person> FindByName(string firstName, string lastName)
        {
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                return _context.Persons.Where(p =>
                p.FirstName.Contains(firstName)
                            &&
                p.LastName.Contains(lastName))
                .ToList();
            } else if (string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                return _context.Persons.Where(p =>
                p.LastName.Contains(lastName))
                .ToList();
            } else if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
            {
                return _context.Persons.Where(p =>
                p.FirstName.Contains(firstName))
                .ToList();
            } else
            {
                return _context.Persons.ToList();
            }
        }

    }
}
