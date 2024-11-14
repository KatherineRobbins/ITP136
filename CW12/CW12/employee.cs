using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW12
{
    public class employee
    {
        int employeeNum;
        double salary;
        string fname, lname, position;

        public employee(int EmpNum, double s, string ln, string fn, string pos)
        {
            employeeNum = EmpNum;
            salary = s;
            lname = ln;
            fname = fn;
            position = pos;
        }

        public int EmployeeNumber
        {
            get { return employeeNum; }
            set { employeeNum = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }

        public string FirstName
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

    }
}
