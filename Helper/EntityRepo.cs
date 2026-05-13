using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Task_001;

namespace Helper
{
    public class EntityRepo<T> : IEntityRepo<T> where T : BaseEntity
    {
        ITIContext db;
        DbSet<T> set;
        public EntityRepo(ITIContext _db) 
        { 
            db = _db;
            set = db.Set<T>();
        }
        public void Add(T entity) => set.Add(entity);
        public void Delete(int id) => GetById(id).Status = false;
        public virtual List<T> GetAll() => set.Where(e => e.Status).ToList();
        public virtual T GetById(int id) => set.Find(id);
        public List<T> Find(Expression<Func<T, bool>> cond) => set.Where(cond).ToList();
        public void Update(T entity) => set.Update(entity);
        public void Save() => db.SaveChanges();
    }
}
