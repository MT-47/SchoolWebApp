using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Task_001;

namespace Helper
{

    public class DepartmentRepo : IEntityRepo<Department>
    {
        public void Add(Department entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> Find(Expression<Func<Department, bool>> cond)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public Department GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
