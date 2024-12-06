using static System.Console;

namespace hw14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the cake bakery!");

            char moreCakes = 'y';

            int counter = 0;

            List<CakeOrder> CakeOrder = new List<CakeOrder>();
            while(moreCakes == 'y')
            {
                Console.WriteLine("Please choose your decorations and design for cake order {0}", counter + 1);

                collectOrder( ref CakeOrder);
                counter++;

                WriteLine("Would you like to continue y/n");
                moreCakes = Convert.ToChar(ReadLine());
            }

            WriteLine("{0,-15}{1, -20}{2, -20}", "Name", "Decoration", "Design");

            foreach (CakeOrder o in CakeOrder)
            {
                WriteLine("{0,-15}{1,-20}{2,-20}", o.OrderName, o.OrderDecoration, o.OrderDesign);
            }
        }

        public static void collectOrder(ref List<CakeOrder> o) 
        { 
            var listofDecorations = File.ReadLines("Decorations.csv").Select(line => new Decorations(line)).ToList();
            var listofDesigns = File.ReadLines("Design.csv").Select(line => new Design(line)).ToList();

            WriteLine("Name of cake order");
            string name = ReadLine();

            WriteLine("Which decoration would you like?");
            foreach(Decorations dec in listofDecorations)
            {
                WriteLine($"{dec.DecorationID}\t{dec.DecorationName}\t");
            }

            int a = Convert.ToInt32(ReadLine());

            string decoration = listofDecorations[a - 1].DecorationName;

            

            WriteLine("Which Design would you like?");
            foreach(Design des in listofDesigns)
            {
                WriteLine($"{des.DesignID}\t {des.DesignName}\t");
            }

            int b = Convert.ToInt32(ReadLine());
            string design = listofDesigns[b - 1].DesignName;

            o.Add(new CakeOrder(name, decoration, design));
        }
    }
}