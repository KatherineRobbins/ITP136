using static System.Console;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            welcomeMessage();

            magicNumber();

            findArea();

            localTaxRate();


            WriteLine("This is the end my friend");

            ReadKey();
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


        static int findArea()
        {

            int l, w;
            int area = l * w;
            WriteLine("Please enter the width of the area");
            l = Convert.ToInt32(Console.ReadLine());
            WriteLine("Please enter the lenght of the area");
            w = Convert.ToInt32(Console.ReadLine());

            WriteLine("The area is: " +  area);



        }

        static int localTaxRate()
        {

        }

    }
}