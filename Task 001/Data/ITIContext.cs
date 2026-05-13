using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_001
{
    public class ApplicationUser : IdentityUser
    {
        public int? StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
    public class ITIContext : IdentityDbContext<ApplicationUser>
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
                .UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=efcorev1;Integrated Security=True;Trust Server Certificate=True")
                .ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning)); // بدون سيميكولون قبلها

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>(r =>
            {
                r.HasData(
                    new IdentityRole() { Id = "1", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = "1" },
                    new IdentityRole() { Id = "2", Name = "Student", NormalizedName = "STUDENT", ConcurrencyStamp = "2" },
                    new IdentityRole() { Id = "3", Name = "Instructor", NormalizedName = "INSTRUCTOR", ConcurrencyStamp = "3" }
                );
            });

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
                d.HasData(
                    new Department { DeptId = 100, Capacity = 50, MgrId = null, Name = ".net", Status = true },
                    new Department { DeptId = 200, Capacity = 30, MgrId = null, Name = "pd", Status = true },
                    new Department { DeptId = 300, Capacity = 25, MgrId = null, Name = "os", Status = true }
                );
            });

            modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

            var hasher = new PasswordHasher<ApplicationUser>();

            var users = new List<ApplicationUser>
            {
                new ApplicationUser { Id = "u1",  UserName = "aly@iti.gov",        NormalizedUserName = "ALY@ITI.GOV",        Email = "aly@iti.gov",        NormalizedEmail = "ALY@ITI.GOV",        StudentId = 1,  SecurityStamp = "u1",  ConcurrencyStamp = "u1" },
                new ApplicationUser { Id = "u2",  UserName = "sara@iti.gov",       NormalizedUserName = "SARA@ITI.GOV",       Email = "sara@iti.gov",       NormalizedEmail = "SARA@ITI.GOV",       StudentId = 2,  SecurityStamp = "u2",  ConcurrencyStamp = "u2" },
                new ApplicationUser { Id = "u3",  UserName = "ahmed@iti.gov",      NormalizedUserName = "AHMED@ITI.GOV",      Email = "ahmed@iti.gov",      NormalizedEmail = "AHMED@ITI.GOV",      StudentId = 3,  SecurityStamp = "u3",  ConcurrencyStamp = "u3" },
                new ApplicationUser { Id = "u8",  UserName = "khaled@iti.gov",     NormalizedUserName = "KHALED@ITI.GOV",     Email = "khaled@iti.gov",     NormalizedEmail = "KHALED@ITI.GOV",     StudentId = 8,  SecurityStamp = "u8",  ConcurrencyStamp = "u8" },
                new ApplicationUser { Id = "u9",  UserName = "metwally@iti.gov",   NormalizedUserName = "METWALLY@ITI.GOV",   Email = "metwally@iti.gov",   NormalizedEmail = "METWALLY@ITI.GOV",   StudentId = 9,  SecurityStamp = "u9",  ConcurrencyStamp = "u9" },
                new ApplicationUser { Id = "u10", UserName = "mt@m.com",           NormalizedUserName = "MT@M.COM",           Email = "mt@m.com",           NormalizedEmail = "MT@M.COM",           StudentId = 10, SecurityStamp = "u10", ConcurrencyStamp = "u10" },
                new ApplicationUser { Id = "u11", UserName = "b@mail.com",         NormalizedUserName = "B@MAIL.COM",         Email = "b@mail.com",         NormalizedEmail = "B@MAIL.COM",         StudentId = 11, SecurityStamp = "u11", ConcurrencyStamp = "u11" },
                new ApplicationUser { Id = "u13", UserName = "A@B.C",              NormalizedUserName = "A@B.C",              Email = "A@B.C",              NormalizedEmail = "A@B.C",              StudentId = 13, SecurityStamp = "u13", ConcurrencyStamp = "u13" },
            };

            foreach (var user in users)
                user.PasswordHash = hasher.HashPassword(user, user.Email);

            modelBuilder.Entity<ApplicationUser>().HasData(users);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "u1", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "u2", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "u3", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "u8", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "u9", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "u10", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "u11", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "u13", RoleId = "2" }
            );
        }
    }
}
