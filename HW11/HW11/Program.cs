using static System.Console;
namespace HW11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            double total = 0;

            int calculateOption;


            WriteLine("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            WriteLine("Enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());


            WriteLine("Calculation option: 1-Add 2-Multiply 3-Subtract 4-Divide");
            calculateOption = Convert.ToInt32(Console.ReadLine());

            switch(calculateOption)
            {
                case 1:
                    total = num1 + num2;
                        break;
                case 2:
                    total = num1 * num2;
                    break;
                case 3:
                    total = num1 - num2;
                    break;
                case 4:
                    total = num1 / num2;
                    break;

            }

            return total;
        }
    }
}