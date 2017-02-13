using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Groups
{
    public class Group
    {
        public Town Town { get; set; }
        public List<Student> Students = new List<Student>();
    }
}
