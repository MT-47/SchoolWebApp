using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task_001
{
    public class StudentCourse
    {
        [ForeignKey("Student")]
        public int StdId { get; set; }
        [ForeignKey("Course")]
        public int CrsId { get; set; }
        public int? Degree { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

    }
}
