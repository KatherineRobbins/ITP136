using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    public class Teacher : Person 
    {
        public Teacher (int ID, string FN, string add , int salary, int yearsService) : base (ID, FN, add)
        {
            Salary = salary;
            YearsService = yearsService;
        }
        public int Salary { get; set;}
        public int YearsService { get; set;}
    }
}
