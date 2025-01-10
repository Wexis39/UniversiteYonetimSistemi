using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniversiteYonetimSistemi.Entities.Abstractions;

namespace UniversiteYonetimSistemi.DAL.Abstractions
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid Id);
        T GetById(Guid Id);
        IEnumerable<T> GetAll();
        bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}
