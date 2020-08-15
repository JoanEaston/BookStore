using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Domain
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);
        void Remove(T entity);
        
    }
}
