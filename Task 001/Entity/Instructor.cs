using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task_001
{
    public class Instructor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InsId { get; set; }

        public string Name { get; set; }

        public int? DeptNo { get; set; }

        [ForeignKey("DeptNo")]
        public virtual Department Department { get; set; }

        public virtual List<Course> InstructorCourses { get; set; }

        public virtual Department ManagedDepartment { get; set; }

        public override string ToString()
        {
            return $"Instructor id : {InsId} , name : {Name} , deptno : {DeptNo}";
        }
    }
}
