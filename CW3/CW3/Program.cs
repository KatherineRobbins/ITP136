namespace CW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;

            double num2 = 25.25;

            string name1 = "Reynolds";

            bool bool1 = true;

            int num10; 

            int num11, num12, num13;

            const string  conString= "Don't Change";

            double a, b, c;
            double total;

            string inputString;

            Console.WriteLine("Enter your name");

            inputString = Console.ReadLine();

            Console.WriteLine("Enter your First Number");
            inputString = Console.ReadLine();
            a =  Convert.ToDouble(inputString);

            Console.WriteLine("Enter your second number");
            inputString = Console.ReadLine();
            b = Convert.ToDouble(inputString);

            Console.WriteLine("Enter your third number");
            c = Convert.ToDouble(Console.ReadLine());

            total = (a + b + c) / 3;

            Console.WriteLine();
            Console.WriteLine("The average is: {0,10}{1,10}", total.ToString("C"), "!");

            Console.ReadKey();


        }
    }
}