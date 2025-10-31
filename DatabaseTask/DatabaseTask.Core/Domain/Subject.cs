using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
