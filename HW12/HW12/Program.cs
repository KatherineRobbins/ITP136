using System.ComponentModel.Design;
using static System.Console;

namespace HW12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numParts;

            WriteLine("How many parts do you want to enter?");
            numParts = Convert.ToInt32(Console.ReadLine());

            Parts[] partsArray = new Parts[numParts];

            for (int i = 0; i < partsArray.Length; i++)
            {
                populateParts(ref partsArray[i]);
            }

            static void populateParts(ref Parts e)
            {
                WriteLine("Enter part number");
                int PartNum = Convert.ToInt32(Console.ReadLine());

                WriteLine("Enter part name");
                string PartName = ReadLine();

                WriteLine("enter part description");
                string PartDescription = ReadLine();

                WriteLine("enter part cost");
                double PartCost = Convert.ToDouble(Console.ReadLine());

                e = new Parts (PartNum, PartName, PartDescription, PartCost);
            }

           

           
            WriteLine("List of Parts:");

            for (int z = 0; z < partsArray.Length; z++)
            {
                WriteLine(z + 1 + " " + partsArray[z].PartName);
            }
            WriteLine("Enter the number below you would like to view");

            int selectPart = Convert.ToInt32(Console.ReadLine());

            if (selectPart >0 && selectPart <=partsArray.Length)
            {
                viewPart(ref partsArray[selectPart - 1]);
            }

            else
            {
                WriteLine("invalid number");
            }

            static void viewPart(ref Parts e)
            {
                WriteLine("Part Number: " + e.PartNumber + "\nPart Name:  " + e.PartName + "\nPart Description:  " + e.PartDescription + "\nPart Cost:  " + e.PartCost);

            }

            

        }
    }
}