using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Task_001;

namespace Helper
{

    public class StudentRepo : EntityRepo<Student>
    {
        ITIContext db;

        public StudentRepo(ITIContext _db) : base(_db) => db = _db;
        public override List<Student> GetAll() => db.Students.Where(s => s.Status).Include(s => s.Department).ToList();

        public override Student GetById(int id) => db.Students.Include(s => s.Department).FirstOrDefault(s => s.Id == id);
    }
}
