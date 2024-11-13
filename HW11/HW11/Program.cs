using System.Linq.Expressions;
using static System.Console;
namespace HW11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2;
            decimal total = 0;

            decimal calculateOption;


            WriteLine("Enter first number:");
            num1 = Convert.ToDecimal(Console.ReadLine());

            WriteLine("Enter second number:");
            num2 = Convert.ToDecimal(Console.ReadLine());


            WriteLine("Calculation option: 1-Add 2-Multiply 3-Subtract 4-Divide");
            calculateOption = Convert.ToDecimal(Console.ReadLine());


            try
            {
                switch (calculateOption)
                {
                    case 1:
                        total = num1 + num2;
                        WriteLine("Total: " + total);
                        break;
                    case 2:
                        total = num1 * num2;
                        WriteLine("Total: " + total);
                        break;
                    case 3:
                        total = num1 - num2;
                        WriteLine("Total: " + total);
                        break;
                    case 4:
                        total = num1 / num2;
                        WriteLine("Total: " + total);
                        break;

                }
            }

            catch(DivideByZeroException e)
            {
                WriteLine("error: " + e);
            }
           
        }

            
     }
    
}