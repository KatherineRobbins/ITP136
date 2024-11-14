using System.Buffers;
using static System.Console;

namespace CW12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRAYS OF OBJECTS

            employee emp1 = new employee(1234, 45000.52, "Ross", "Bill", "Teacher");

            WriteLine(emp1.EmployeeNumber + " " + emp1.Salary + " " + emp1.LastName + " " + emp1.FirstName + " " + emp1.Position);

            int numEmp;

            WriteLine("How many employees do you want to enter?");
            numEmp = Convert.ToInt32(Console.ReadLine());

            employee[] empArray = new employee[numEmp];

            for(int x = 0; x < empArray.Length; x++)
            {
                populateemployee(ref empArray[x]);
            }

            static void populateemployee(ref employee e)
            {
                WriteLine("Enter employee number");
                int empNum = Convert.ToInt32(Console.ReadLine());

                WriteLine("Enter employee salary");
                double a = Convert.ToDouble(Console.ReadLine());

                WriteLine("Enter employee last name");
                string lastname = ReadLine();

                WriteLine("Enter first name");
                string firstname = ReadLine();

                WriteLine("Enter position");
                string posit = ReadLine();

                e = new employee(empNum, a, lastname, firstname, posit);
            }


            for (int y = 0; y < empArray.Length; y++)
            {
                WriteLine(empArray[y].EmployeeNumber + " " + empArray[y].Salary + " " + empArray[y].LastName + " " + empArray[y].FirstName + " " + empArray[y].Position);
            }

            WriteLine("Enter the number below that you would like to modify");

            for(int z = 0; z < empArray.Length; z++)
            {
                WriteLine(z + 1 + " " + empArray[z].EmployeeNumber + " " + empArray[z].LastName + " " + empArray[z].FirstName);
            }

            int selectEmployee = Convert.ToInt32(ReadLine());

            modifyEmployee(ref empArray[selectEmployee - 1]);

            static void modifyEmployee(ref employee e)
            {
                WriteLine("What would you like to modify? \n 1.Employee Number \n 2.Salary \n 3.Last Name \n 4.First Name \n 5.Position");

                int userinput = Convert.ToInt32(ReadLine());

                if(userinput == 1)
                {
                    WriteLine("What is the new employee number");
                    int newNum = Convert.ToInt32(ReadLine());
                    e.EmployeeNumber = newNum;
                }
                else if(userinput == 2)
                {
                    WriteLine("What is the new salary?");
                    double newSalary = Convert.ToDouble(ReadLine());
                    e.Salary = newSalary;

                }

                else if (userinput == 3)
                {
                    WriteLine("What is the new last name?");
                    string newLname = ReadLine();
                    e.LastName = newLname;

                }

                else if (userinput == 4)
                {
                    WriteLine("What is the new first name?");
                    string newFname = ReadLine();
                    e.FirstName = newFname;

                }

                else if (userinput == 5)
                {
                    WriteLine("What is the new position?");
                    string newPos = ReadLine();
                    e.Position = newPos;


                }

                else
                {
                    WriteLine("you entered an invalid value");
                }

               
            }

            for (int y = 0; y < empArray.Length; y++)
            {
                WriteLine(empArray[y].EmployeeNumber + " " + empArray[y].Salary + " " + empArray[y].LastName + " " + empArray[y].FirstName + " " + empArray[y].Position);
            }

        }
    }
}