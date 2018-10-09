using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Description { get; set; }
        public int Unit { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
