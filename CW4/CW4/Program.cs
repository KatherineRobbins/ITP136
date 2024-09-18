using static System.Console;

namespace CW4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // if else statements w/ nested
            int first = 5;
            int second = 3;

            if (first == second)
            {
                WriteLine("The numbers are equal");

            }
            else
            {
                WriteLine("The numbers are NOT equal");
                if(first > second) 
                {
                    WriteLine("First is greater than second");  
                }
                else
                {
                    WriteLine("Second is greater than first");
                }

            }

            //sequence if else statements

            char ch = 'x';

            if (ch == 'a' || ch == 'A')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'e' || ch == 'E')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'i' || ch == 'I')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'o' || ch == 'O')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'u' || ch == 'U')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'y' || ch == 'Y')
            {
                WriteLine("Sometimes a Vowel");
            }
            else
            {
                WriteLine("Consonant");
            }


            //switch statements

            int option, a, b, total;
            
            WriteLine("Enter your first number");
            a = Convert.ToInt32(ReadLine());

            WriteLine("Enter your second number");
            b = Convert.ToInt32(ReadLine());

            WriteLine("1 - Add, 2 - Subtract, 3 -  Multiply, 4 - Divide");
            option = Convert.ToInt32(ReadLine());

            switch(option) 
            {
                case 1: 
                    total = a + b;
                    WriteLine("The numbers added are {0}", total);
                    break;

                case 2:
                    total = a - b;
                    WriteLine("The numbers subtracted are {0}", total);
                    break;

                case 3: total = a * b;
                    WriteLine("The numbers multiplied are {0}", total);
                    break;
                
                case 4: total = a / b;
                    WriteLine("The numbers divided are {0}", total);
                    break;
                default:
                    WriteLine("You entered an invalid option");
                    break;

            }


        }
    }
}