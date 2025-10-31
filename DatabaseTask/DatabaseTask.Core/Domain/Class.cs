using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Class
    {
        public int ClassID { get; set; }
        public string ClassNumber { get; set; }
        public string RoomNumber { get; set; }

        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
