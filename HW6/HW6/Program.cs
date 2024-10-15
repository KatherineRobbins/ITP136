using static System.Console;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            int secretNumber = 4;
            
            
            welcomeMessage();

            for (int k = 0; k < 1; k++)
            {
                
                a = askLength();
                b = askWidth();
                c = localTaxRate();
               

               
                findArea(a, b);
                taxRate(c);
                magicNumber(secretNumber);
                

            }


            WriteLine("This is the end my friend");

            ReadKey();
        }

        static void welcomeMessage()
        {
            WriteLine("Welcome!");

            ReadKey();
        }

        static void magicNumber(int m)
        {
            int mNumber = m * 2;
            WriteLine("The magic number is : " + mNumber);
            

            
        }

        static int localTaxRate()
        {

            int x;
            WriteLine("Please enter the local tax rate");
            x = Convert.ToInt32(Console.ReadLine());

            return x;



        }



        static int askLength()
        {

            int x;
            WriteLine("Please enter the length");
            x = Convert.ToInt32(Console.ReadLine());

            return x;



        }

        static int askWidth()
        {
            int x;
            WriteLine("Please enter the width");
            x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        static void findArea(int num1, int num2)
        {
            int total = num1 * num2;

               WriteLine("The area is : " + total);

        }

        static void taxRate(int t)
        {
            int taxRate = t;

            WriteLine("Your local tax rate is : " + taxRate);
            
        }
    }
}