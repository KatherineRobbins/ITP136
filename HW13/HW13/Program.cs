using static System.Console;

namespace HW13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to where you can add students and teachers");

            List<Student> studentList = new List<Student>();
            List<Teacher> teacherList = new List<Teacher>();

            

            WriteLine("How many Students would you like to enter?");
            int studentInput = Convert.ToInt32(Console.ReadLine());

            for ( int x = 0; x < studentInput; x++ )
            {
                WriteLine("Enter Student ID:");
                int stuNum = Convert.ToInt32(Console.ReadLine());

                WriteLine("Enter Student Full Name:");
                string stuName = ReadLine();

                WriteLine("Enter Student Address:");
                string stuAddress = ReadLine();

                WriteLine("Enter Student Major:");
                string stuMajor = ReadLine();

                WriteLine("Enter Student Advisor:");
                string stuAdvisor = ReadLine();

                studentList.Add(new Student(stuNum, stuName, stuAddress, stuMajor, stuAdvisor));
            }


            WriteLine("How many Teachers would you like to enter?");
            int teacherInput = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < teacherInput; x++)
            {
                WriteLine("Enter Teacher ID:");
                int tchNum = Convert.ToInt32(Console.ReadLine());

                WriteLine("Enter Teacher Full Name:");
                string tchName = ReadLine();

                WriteLine("Enter Teacher Address:");
                string tchAddress = ReadLine();

                WriteLine("Enter Teacher Salary:");
                int tchSalary = Convert.ToInt32(Console.ReadLine());

                WriteLine("Enter Teacher Years of Service:");
                int tchYears = Convert.ToInt32(Console.ReadLine());

                teacherList.Add(new Teacher(tchNum, tchName, tchAddress, tchSalary, tchYears));
            }

            WriteLine("************************");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Students:");
            WriteLine("{0,-10}{1,-20}{2,-20}{3,-15}{4,-15}", "ID", "Full Name", "Address", "Major", "Advisor");
            
            foreach (Student st in studentList)
            {
                WriteLine("{0,-10}{1,-20}{2,-20}{3,-15}{4,-15}", st.IdNum , st.FullName , st.Address , st.Major , st.Advisor);
            }

            ResetColor();
            WriteLine("************************");
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Teachers:");
            WriteLine("{0,-10}{1,-20}{2,-20}{3,-15}{4,-15}", "ID", "Full Name", "Address", "Salary", "Years of Service");
           
            foreach (Teacher tc in teacherList)
            {
                WriteLine("{0,-10}{1,-20}{2,-20}{3,-15}{4,-15}", tc.IdNum ,tc.FullName , tc.Address, tc.Salary.ToString("C") , tc.YearsService);
            }

            ResetColor();
            ReadKey();


        }
    }
}