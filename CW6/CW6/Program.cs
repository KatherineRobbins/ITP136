using static System.Console;
namespace CW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            
            welcomeMessage();

            for(int k = 0; k < 3; k++)
            {

                a = askNumber();
                b = askNumber();

                addNumber(a, b);
               

            }

            

            WriteLine("End");


            ReadKey();

           
        }
        //methods : cant use name as name of method cant create a method w/in a method 

        static void welcomeMessage()
        {
            WriteLine("Welcome to my calculator");

            ReadKey();
        }

        static int askNumber()
        {
            int x;
            WriteLine("please enter a number");
            x = Convert.ToInt32(Console.ReadLine());

            return x;

        }

        static void addNumber(int num1, int num2)
        {
            int total =  num1 + num2;
            WriteLine("Your total is {0}", total);
        }

        static int addNumber2(int num1, int num2)
        {
            int total = num1 + num2;
            

            return total;
        }


    }
}