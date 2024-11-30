using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    public class Student : Person
    {
        public Student(int id, string fn, string adrs, string major, string advisor) : base (id, fn, adrs)

        {
            Major = major;
            Advisor = advisor;
        }

        public string Major { get; set; }
        public string Advisor { get; set; } 
    }
}
