using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.DAL.Abstractions;
using UniversiteYonetimSistemi.DAL.Context;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.DAL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly UniversiteDbContext _universiteDbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(UniversiteDbContext universiteDbContext)
        {
            _universiteDbContext = universiteDbContext;
            _dbSet= _universiteDbContext.Set<T>();

        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _universiteDbContext.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            _dbSet.Remove(GetById(Id));
            _universiteDbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(Guid Id)
        {
            var found = _dbSet.Find(Id);
            if (found == null)
            {
                throw new Exception("Bulunamadi");
            }
            return found;
        }

        public bool IfEntityExists(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Any(filter);
        }

        public void Update(T entity)
        {
            _universiteDbContext.SaveChanges();
        }
    }
}
