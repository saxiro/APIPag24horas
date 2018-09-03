using APIPag24horas.Model.cbolso;
using APIPag24horas.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIPag24horas.Repository.cbolso
{
	public class UsuariosRepository : IUsuariosRepository
    {
        protected readonly MySQLCbolsoContext _context;
        protected DbSet<Usuarios> dataset;

        public UsuariosRepository(MySQLCbolsoContext context)
        {
            _context = context;
            dataset = _context.Set<Usuarios>();
        }


        public Usuarios Create(Usuarios item)
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
            var result = dataset.SingleOrDefault(p => p.id_usuario.Equals(id));
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
            return dataset.Any(b => b.id_usuario.Equals(id));
        }

        public List<Usuarios> FindAll()
        {
            return dataset.ToList();
        }

        public Usuarios FindById(int id)
        {
            return dataset.SingleOrDefault(p => p.id_usuario.Equals(id));
        }

        public Usuarios Update(Usuarios item)
        {
            if (!Exists(item.id_usuario)) return null;
            var result = dataset.SingleOrDefault(p => p.id_usuario.Equals(item.id_usuario));
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
