using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Task_001
{
    public class Course
    {
        public int CrsId { get; set; }

        public string Name { get; set; }

        public int Duration { get; set; }


        public virtual List<Department> CourseDepartments { get; set; }
        public virtual List<Instructor> CourseInstructors { get; set; }

        public virtual List<StudentCourse> CourseStudents { get; set; }

        public override string ToString()
        {
            return $"Course : {CrsId} , {Name} , {Duration}";
        }
    }
}
