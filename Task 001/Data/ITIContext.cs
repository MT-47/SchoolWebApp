using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_001
{
    public class ITIContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }

        public ITIContext()
        {
            
        }
        public ITIContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //.UseLazyLoadingProxies()
                .UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=efcorev1;Integrated Security=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StdId, sc.CrsId });
            
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithOne(i => i.ManagedDepartment)
                .HasForeignKey<Department>(d => d.MgrId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.DeptNo)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>(d =>
            {
                d.HasData(  new Department { DeptId = 100, Capacity = 50, MgrId = null, Name = ".net" },
                            new Department { DeptId = 200, Capacity = 30, MgrId = null, Name = "pd" },
                            new Department { DeptId = 300, Capacity = 25, MgrId = null, Name = "os" });
            });

            modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
