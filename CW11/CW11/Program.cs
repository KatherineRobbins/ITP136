using static System.Console;
namespace CW11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //index out of range
            //cant add an element to something that doesn't exist

            //create an array that's a string with 3 elements 

            string[] numberArray = { "Trump", "Vance", "Kennedy" };

            try
            {
                WriteLine("Enter the element you want to see");
                int elementNumber = Convert.ToInt32(ReadLine());

                WriteLine(numberArray[elementNumber]);
            }
            catch(IndexOutOfRangeException x)
            {
                WriteLine("Must enter a number between 0-2");
            }


           




            //EXCEPTION HANDLING is...
            //catching exception (errors) in the code, making sure you program can alert without breaking and stopping the program


            //1st way to do this is to ....
            // divide by zero error 

            int num1, num2;

            double total;

            WriteLine("Please enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            WriteLine("Please enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            //add try catch 

            try
            {
                total = num1 / num2;
                WriteLine("Your total is " + total);
            }

            catch(DivideByZeroException e)
            {
                WriteLine("Can't divide by zero");
                
                //WriteLine("Exception Caught: " + e);
            }


            


            

           

            ReadKey();


        }
    }
}