using APIPag24horas.Model.cbolso.Base;
using APIPag24horas.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIPag24horas.Repository.cbolso.Generic
{
	public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MySQLCbolsoContext _context;
        protected DbSet<T> dataset;

        public GenericRepository(MySQLCbolsoContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }


        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }

        public void Delete(int id)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(id));
            try
            {
                if (result != null) dataset.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Exists(int? id)
        {
            return dataset.Any(b => b.Id.Equals(id));
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(int id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        public T Update(T item)
        {
            if (!Exists(item.Id)) return null;
            var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }
    }
}
