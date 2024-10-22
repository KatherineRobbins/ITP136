using static System.Console;

namespace MIdTerm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Hello, welcome to Reynolds Airline!");

            WriteLine("What is your first name?");
            string fname = Console.ReadLine();

           WriteLine("What is your last name?");
            string lname = Console.ReadLine();

           WriteLine("What is your address?");
            string address = Console.ReadLine();

           WriteLine("What is the date of travel, please enter in format month month day day year year 010124");
            int travelDate = Convert.ToInt32(Console.ReadLine());


            int bag = askBag();


            int seat = askSeat();

            

            double total = (seat + bag);
            
            double tax = total * 0.05;

            double subTotal = total + tax;

            //Receipt

            

            WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLine(" Reynolds Airlines  ");
            Console.ForegroundColor= ConsoleColor.Green;
            WriteLine("Passenger Name:" + " " + fname + " " + lname);
            WriteLine("Passenger Address: " + address);
            Console.ResetColor();
            WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("Date of Travel:" + " " + travelDate);
            Console.ResetColor();
            WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("Bag Total: " + bag);
            WriteLine("Seat Total: " + seat);
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Total: " + total.ToString("C"));
            Console.ResetColor();
            WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Tax: " + tax.ToString("C"));
            Console.ResetColor();
            WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Subtotal: " + subTotal.ToString("C"));
            Console.ResetColor();
            WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("Thank you for booking with Reynolds Airlines!");
            Console.ResetColor();


        }

        static int askBag()
        {
            int bagOption;

            int bagCount;

            int bagTotal = 0;

            WriteLine("Please enter 1 if you do not have any bags to check or enter 2 if you do have bags to check");
            bagOption = Convert.ToInt32(Console.ReadLine());


            switch (bagOption)
            {
                case 1:
                    WriteLine("Thank you we will not check any bags for your travel");
                    bagTotal = 0;
                    break;

                case 2:
                    WriteLine("How many bags will you be checking for your travel?");
                    bagCount = Convert.ToInt32(Console.ReadLine());

                    bagTotal = bagCount * 25;

                    break;

                default:
                    WriteLine("Invalid option please enter 1 or 2");
                    break;

            }

            return bagTotal;
        }


        static int askSeat()
        {

            int seatOption;
            int seatCount;
            int seatTotal = 0;

            WriteLine("Please enter 1 if you would like to pay for your seat/seats or 2 if you don't");
            seatOption = Convert.ToInt32(Console.ReadLine());

            switch (seatOption)
            {
                case 1:
                    WriteLine("How many seats do you need?");
                    seatCount = Convert.ToInt32(Console.ReadLine());

                    seatTotal = seatCount * 30;
                    break;

                case 2:
                    WriteLine("You have chosen not to pay for your seat.");
                    seatTotal = 0;
                    break;
            }

            return seatTotal;

        }

        


    }
}
