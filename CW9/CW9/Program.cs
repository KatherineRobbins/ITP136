using static System.Console;
namespace CW9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string arrays - same value arrays, all elements in array start at zero stephens is 0 jordan 1 etc...

            string[] names = {"Stephens", "Jordan", "Gretzky", "Ronaldo" };

            WriteLine(names[1]);

            //use a for loop

            for (int x = 0; x < names.Length; x++)
            {
                WriteLine(names[x]);
            }

            //integer array

            int[] nums = { 1, 5, 8, 9 };

            double[] price = { 12.25, 13.13, 15.15, 42.67 };

            //use a for loop

            for (int x = 0; x < nums.Length; x++) 
            {
                WriteLine(nums[x]);
            }

            for (int x = 0; x < price.Length; x++)
            {
                WriteLine(price[x]);
            }

            //show how parallel arrays can work for you

            for (int x = 0; x < price.Length; x++)
            {
                WriteLine("{0,10}{1,10}", names[x], price[x]);
            }

            ReadKey();
        }
    }
}