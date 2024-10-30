using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW10
{
    public class employee
    {

        //base class add properties
        // changed from internal to public , we want program class to see employee class


        int empId;
        string fName, lName;

        // add property Properties are like variables as they hold values for the class and can be accessed by other classes


        public int EmployeeId
        {

            // two methods get and set
            get { return empId; }
            set { empId = value; }
        }

        public string LastName
        {
            get { return lName; }
            set { lName = value; }


        }

        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }

    }
}
