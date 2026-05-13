using Microsoft.EntityFrameworkCore;

namespace Task_001
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //ITIContext context = new ITIContext();

            ////1. Select all Students
            //Console.WriteLine("1. Select all Students \n");

            //var res01 = await context.Students.ToListAsync();
            
            //foreach (var item in res01)
            //    Console.WriteLine(item);
            //Console.WriteLine("\n");

            ////2. Select all Departments
            //Console.WriteLine("2. Select all Departments \n");

            //var res02 = await context.Departments.ToListAsync();
            
            //foreach (var item in res02)
            //    Console.WriteLine(item);
            //Console.WriteLine("\n");

            ////3. Select all Courses
            //Console.WriteLine("3. Select all Courses \n");

            //var res03 = await context.Courses.ToListAsync();
            
            //foreach (var item in res03)
            //    Console.WriteLine(item);
            //Console.WriteLine("\n");

            ////4. Select Students with age > 20
            //Console.WriteLine("4. Select Students with age > 20 \n");

            //var res04 = await context.Students.Where(s => s.Age > 20).ToListAsync();
            
            //foreach (var item in res04)
            //    Console.WriteLine(item);
            //Console.WriteLine("\n");

            ////5. Select Student id name where deptno = 100
            //Console.WriteLine("5. Select Student id name where deptno = 100 \n");

            //var res05 = await context.Students.Where(s => s.DeptNo == 100).Select(s => new { s.Id, s.Name }).ToListAsync();

            //foreach (var item in res05)
            //    Console.WriteLine(item);
            //Console.WriteLine("\n");

            ////6. Select Student and department [ eager loading ]
            //Console.WriteLine("6. Select Student and department [ eager loading ] \n");

            //var res06 = await context.Students.Include(s => s.Department).ToListAsync();

            //foreach (var item in res06)
            //    Console.WriteLine($"Student: {item.Name}, Department: {item.Department.Name}");
            //Console.WriteLine("\n");

            ////7. Select Student and department [ lazy loading ]
            //Console.WriteLine("7. Select Student and department [ lazy loading ] \n");

            ////var res07 = await context.Students.ToListAsync();

            ////foreach (var item in res07)
            ////    Console.WriteLine($"Student: {item.Name}, Department: {item.Department.Name}");
            ////Console.WriteLine("\n");

            ////8. Select Student and department [ explicit loading ]
            //Console.WriteLine("8. Select Student and department [ explicit loading ] \n");

            //var res8 = await context.Students.ToListAsync();

            //foreach (var item in res8)
            //{
            //    context.Entry(item).Reference(s => s.Department).Load();
            //    Console.WriteLine($"Student: {item.Name}, Department: {item.Department.Name}");
            //}
            //Console.WriteLine("\n");

            ////9. Select Student and department [ explicit select ]
            //Console.WriteLine("9. Select Student and department [ explicit select ] \n");

            //var res9 = await context.Students.Select(s => new { Name = s.Name, Department =  s.Department.Name }).ToListAsync();

            //foreach (var item in res9)
            //    Console.WriteLine($"Student: {item.Name}, Department: {item.Department}");
            //Console.WriteLine("\n");

            ////10. Insert new Student
            //Console.WriteLine("10. Insert new Student \n");

            ////Student NewStudent1 = new Student() { Name = "Khaled", Age = 25, Email = "khaled@iti.gov", DeptNo = 200 };
            ////Console.WriteLine(context.Entry(NewStudent1).State);
            ////context.Students.Add(NewStudent1);
            ////Console.WriteLine($"{context.Entry(NewStudent1).State}\n");
            ////context.SaveChanges();

            ////11. Add new Student to department list
            //Console.WriteLine("11. Add new Student to department list \n");

            ////Department dept = context.Departments.Single(s => s.DeptId == 100);
            ////dept.Students.Add(new Student() { Name = "Metwally", Age = 27, Email = "metwally@iti.gov" });
            ////context.SaveChanges();

            ////12. Delete Student where id = 5
            //Console.WriteLine("12. Delete Student where id = 5 \n");

            ////var StudentToRemove = context.Students.SingleOrDefault(s => s.Id == 7);
            ////if (StudentToRemove != null)
            ////{
            ////    context.Students.Remove(StudentToRemove);
            ////    context.SaveChanges();
            ////}

            ////13. Update Student where id = 4
            //Console.WriteLine("13. Update Student where id = 4 \n");

            ////var StudentToUpdate = context.Students.SingleOrDefault(s => s.Id == 6);
            ////if (StudentToUpdate != null)
            ////{
            ////    StudentToUpdate.Name = "Omar";
            ////    context.SaveChanges();
            ////}

        }
    }
}
