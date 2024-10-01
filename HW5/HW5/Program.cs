using System.Runtime.InteropServices;
using static System.Console;

namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            
            b = 10;
            

            Console.WriteLine("WHILE LOOP: Count by 1's up to 10!");
            Console.WriteLine("Enter a number between 1-10");
            a = Convert.ToInt32(Console.ReadLine());

            while ( a <= b)
            {
                
                
                WriteLine(a);
                    a++;

            }

            WriteLine("Your can now count by 1's using a WHILE LOOP");
            ReadLine();
            
            

            
        }
    }
}