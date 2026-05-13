using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task_001
{
    public class Department : BaseEntity
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.None)] public int DeptId { get; set; }
        [Required, StringLength(50, MinimumLength = 3)] public string Name { get; set; }
        [Required, Range(1, 100)] public int Capacity { get; set; }
        public int? MgrId { get; set; }

        public virtual List<Student> Students { get; set; }
        public virtual List<Course> DepartmentCourses { get; set; }
        public virtual List<Instructor> Instructors { get; set; }
        [ForeignKey("MgrId")] public virtual Instructor Manager { get; set; }

        public override string ToString() => $"Department [DeptId={DeptId}, Name={Name}, Capacity={Capacity}, Status={Status}]";
    }
}
