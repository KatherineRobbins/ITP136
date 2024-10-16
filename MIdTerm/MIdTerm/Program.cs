using static System.Console;

namespace MIdTerm
{
    internal class Program
    {
        static void Main(string[] args)
        {


            




            Console.WriteLine("Hello, welcome to Reynolds Airline!");

            Console.WriteLine("What is your first name?");
            string fname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lname = Console.ReadLine();

            Console.WriteLine("What is your address?");
            string address = Console.ReadLine();

            Console.WriteLine("What is the date of travel, please enter in format month month day day year year 010124");
            int travelDate = Convert.ToInt32(Console.ReadLine());

            int bag = askBag();
            Console.WriteLine("Your bag total is : " + bag.ToString("C"));


           
        }

        static int askBag()
        {
            int bagOption;

            int bagCount;

            int bagTotal = 0;

            WriteLine("Please enter 1 if you do not have any bags to check or enter 2 if you do have bags to check");
            bagOption = Convert.ToInt32(Console.ReadLine());


            switch(bagOption)
            {
                case 1:
                    WriteLine("Thank you we will not check any bags for your travel");
                    bagTotal = 0;
                    break;

                case 2:
                    WriteLine("How many bags will you be checking for your trave?");
                    bagCount = Convert.ToInt32(Console.ReadLine());

                    bagTotal = bagCount * 25;

                    break;

                default:
                    WriteLine("Invalid option please enter 1 or 2");
                    break;
                  
            }

            return bagTotal;
        }
    }
}