using System.Xml.Schema;
using static System.Console;

namespace HW5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
           
            
            Console.WriteLine("FOR LOOP:Count by 1's up to 10!");

            WriteLine("Enter a number between 1-10");
            a = Convert.ToInt32(Console.ReadLine());

            for (int x = a; x<=10; x++)
            {

               
                WriteLine(x);
                

               
            }
            WriteLine("You can now count by 1's using a FOR LOOP");
            ReadLine();
        }
    }
}