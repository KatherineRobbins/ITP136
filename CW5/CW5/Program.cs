using static System.Console;

namespace CW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while loop

            int a, b;

            //a = 0;
            //b = 5;

            // while(a < b)
            // {
            //   WriteLine(a);

            //   a++;
            // }

            //for loop


            //variables
            int total;

            WriteLine("Welcome to my calculator");


            for(int k = 0; k < 3; k++)
            {
                WriteLine("Enter your first number");
                a = Convert.ToInt32(Console.ReadLine());

                WriteLine("Enter your second number");
                b =  Convert.ToInt32(Console.ReadLine());

                total = a + b;
                WriteLine("Your total is: " + total);
            }
            WriteLine("Thank you for using my calculator");
            ReadLine();
        }
    }
}