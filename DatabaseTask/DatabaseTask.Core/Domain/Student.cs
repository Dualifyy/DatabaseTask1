using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Email { get; set; }

        public int ClassID { get; set; }
        public Class Class { get; set; }

        public ICollection<Grade> Grades { get; set; }
    }
}
