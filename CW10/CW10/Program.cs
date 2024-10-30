using static System.Console;

namespace CW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            //intro to objects
            // create objects from classes


            employee emp1 = new employee();
            employee emp2 = new employee();


            emp1.EmployeeId = 1234;
            emp1.LastName = "Robbins";
            emp1.FirstName = "Katherine";

            emp2.EmployeeId = 5678;
            emp2.LastName = "Kearney";
            emp2.FirstName = "Sarah";

            WriteLine("{0,10}{1,15}{2,15}", "Employee Id", "Last Name", "First Name");
            WriteLine("{0,10}{1,15}{2,15}", emp1.EmployeeId, emp1.LastName, emp1.FirstName);
            WriteLine("{0,10}{1,15}{2,15}", emp2.EmployeeId, emp2.LastName, emp2.FirstName);

            emp1.LastName = "Smith";

            WriteLine("{0,10}{1,15}{2,15}", emp1.EmployeeId, emp1.LastName, emp1.FirstName);


            WriteLine("Enter Employee Id");
            emp2.EmployeeId = Convert.ToInt32(ReadLine());

            WriteLine("Enter Employee Last Name");
            emp2.LastName = ReadLine();

            WriteLine("Enter Employee First Name");
            emp2.FirstName = ReadLine();

            WriteLine("{0,10}{1,15}{2,15}", emp2.EmployeeId, emp2.LastName, emp2.FirstName);

            ReadKey();


        }
    }
}