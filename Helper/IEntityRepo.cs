using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Task_001;

namespace Helper
{
    public interface IEntityRepo<T>
    {
        List<T> GetAll();
        T GetById(int id);
        List<T> Find(Expression<Func<T, bool>> cond);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void Save();
    }
}
