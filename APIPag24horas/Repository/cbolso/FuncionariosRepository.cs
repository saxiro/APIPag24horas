using APIPag24horas.Model.cbolso;
using APIPag24horas.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIPag24horas.Repository.cbolso
{
	public class FuncionariosRepository : IFuncionariosRepository
    {
        protected readonly MySQLCbolsoContext _context;
        protected DbSet<Funcionarios> dataset;

        public FuncionariosRepository(MySQLCbolsoContext context)
        {
            _context = context;
            dataset = _context.Set<Funcionarios>();
        }


        public Funcionarios Create(Funcionarios item)
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
            var result = dataset.SingleOrDefault(p => p.id_funcionario.Equals(id));
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
            return dataset.Any(b => b.id_funcionario.Equals(id));
        }

        public List<Funcionarios> FindAll()
        {
            return dataset.ToList();
        }

        public Funcionarios FindById(int id)
        {
            return dataset.SingleOrDefault(p => p.id_funcionario.Equals(id));
        }

        public Funcionarios Update(Funcionarios item)
        {
            if (!Exists(item.id_funcionario)) return null;
            var result = dataset.SingleOrDefault(p => p.id_funcionario.Equals(item.id_funcionario));
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
