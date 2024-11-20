using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw13
{
    public class Employee
    {
        public Employee(int empNum, string fullName)
        {
            EmployeeNum =  empNum;
            FullName = fullName;

        }

        public int EmployeeNum { get; set; }
        public string FullName { get; set; }
    }
}
