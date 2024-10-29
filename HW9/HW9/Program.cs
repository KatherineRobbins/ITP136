using System;
using System.Linq;
using static System.Console;


namespace HW9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] carMake = new string[5];
            string[] carModel = new string[5];
            double[] carCost = new double[5];

            for (int i = 0; i < carMake.Length; i++)
            {
                WriteLine("Car Make:");
                carMake[i] = Console.ReadLine();

                WriteLine("Car Model:");
                carModel[i] = Console.ReadLine();

                WriteLine("Car Price:");
                carCost[i] = Convert.ToDouble(Console.ReadLine());


            }

            double m = carCost.Max();

            int c = Array.IndexOf(carCost, m);

            WriteLine("The most expensive car is: " + carMake[c] +" " + carModel[c] + " " +  carCost[c].ToString("C"));
        }
    }
}