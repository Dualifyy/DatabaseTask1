using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int SubjectID { get; set; }
        public Subject Subject { get; set; }

        public ICollection<Class> Classes { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
