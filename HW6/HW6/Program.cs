using static System.Console;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            welcomeMessage();
        }

        static void welcomeMessage()
        {
            WriteLine("Welcome to my week 6 assignment where we work on methods!");

            ReadKey();
        }

        static int magicNumber()
        {
            int m;
            WriteLine("Please enter your magic number!");
            m = Convert.ToInt32(Console.ReadLine());

            return m;
        }
    }
}