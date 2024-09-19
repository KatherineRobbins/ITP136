using static System.Console;
namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            int child;
            int labs;
            


            double sickChild = 50;
            double sickAdult = 75;
            double sickLabs = 25;

            double sickChildTotal = sickLabs + sickChild;
            double sickAdultTotal = sickLabs + sickAdult;

            

            double checkChild = 75;
            double checkAdult = 100;


            WriteLine("1 - Doctor Sick Appointment or 2 - Doctor Check-up");
            option = Convert.ToInt32(ReadLine());

            switch(option)
            {
                case 1:
                    WriteLine("Is this a child? 1- yes 2-no");
                    child = Convert.ToInt32(ReadLine());

                    WriteLine("Did you have labs? 1- yes or 2- no");
                    labs = Convert.ToInt32(ReadLine());


                    if (child == 1 && labs == 1)
                    {
                        WriteLine("Your total is " + sickChildTotal.ToString("C"));

                    }
                    else if (child == 1 && labs == 2)
                    {
                        WriteLine("Your total is " + sickChild.ToString("C"));
                    }
                    else if (child == 2 && labs == 1)
                    {
                        WriteLine("Your total is " + sickAdultTotal.ToString("C"));
                    }

                    else
                    {
                        WriteLine("Your total is " + sickAdult.ToString("C"));
                    }
                    break;

                case 2:
                    WriteLine("Is this a child? 1- yes 2-no");
                    child = Convert.ToInt32(ReadLine());
                   

                    if (child == 1)
                    {
                        WriteLine("Your total is " + checkChild.ToString("C"));

                    }
                    else
                    {
                        WriteLine("Your total is " + checkAdult.ToString("C"));
                    }
                    break;
            }
              
                
               


        }
    }
}