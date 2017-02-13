using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Groups
{
    public class Town
    {
        public string Name { get; set; }
        public int SeatCount { get; set; }
        public List<Student> Students = new List<Student>();
    }
}
