using static System.Console;

namespace cw13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Salary> salList = new List<Salary>();
            List<Commission> comList = new List<Commission>();

            salList.Add(new Salary(1234, "Kat Robbins", 50000));

            salList.Add(new Salary(2334, "Chris Robbins", 80000));


            comList.Add(new Commission(5050, "Bill Gates", 800000));
            comList.Add(new Commission(4545, "Elon Musk", 900000));

            foreach(Commission co in comList)
            {
                WriteLine(co.EmployeeNum + " " + co.FullName + " " + co.Sales);
            }

            foreach(Salary sal in salList)
            {
                WriteLine(sal.EmployeeNum + " " + sal.FullName + " " + sal.SalaryAmount);
            }

            WriteLine("How many salary caemployees do you to to add");
            int inputAnswer = Convert.ToInt32(Console.ReadLine());

            for(int x= 0; x<inputAnswer; x++)
            {
                WriteLine("Enter employee number");
                int empNum = Convert.ToInt32(Console.ReadLine());

                WriteLine("Enter employee full name");
                string fn = ReadLine();

                WriteLine("enter the salary");
                double sa = Convert.ToDouble(Console.ReadLine());

                salList.Add(new Salary(empNum, fn, sa));


            }

            foreach (Salary sal in salList)
            {
                WriteLine(sal.EmployeeNum + " " + sal.FullName + " " + sal.SalaryAmount);
            }


            ReadKey();
        }
    }
}