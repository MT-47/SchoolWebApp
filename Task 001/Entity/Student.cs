using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task_001
{
    public class Student : BaseEntity
    {
        public int Id { get; set; }
        [Required, StringLength(50,MinimumLength = 3)] public string Name { get; set; }
        [Required, Range(18, 40)] public int Age { get; set; }
        [Required, EmailAddress, MaxLength(100)] public string Email { get; set; }
        public int? DeptNo { get; set; }

        [ForeignKey("DeptNo")] public virtual Department Department { get; set; }
        public virtual List<StudentCourse> StudentCourses { get; set; }

        public override string ToString() => $"Id : {Id} , Name : {Name} , Age : {Age} , Email : {Email} , DeptNo : {DeptNo} , Status : {Status}";

    }
}
