using Mersus.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Mersus.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntityBase, new()
    {       
        IEnumerable<T> GetAll();
        int Count();
        T GetSingle(int id);
        T GetSingle(Expression<Func<T, bool>> filter);     
        IEnumerable<T> FindBy(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteWhere(Expression<Func<T, bool>> filter);        
    }
}
