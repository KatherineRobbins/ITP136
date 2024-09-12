namespace hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name:");
            string repairEmployee = Console.ReadLine();
            Console.WriteLine("Howdy," + repairEmployee + "!" + " " + "Don't forget to upsell your customers!");

            double a, b, c;
            double total;
            double tax;
            double grand;

            double taxRate = 0.06;


            Console.WriteLine("Please Input the OIL CHANGE charge:");
            a = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please Input the TIRES charge:");
            b = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please Input the INSPECTION charge:");
            c = Convert.ToDouble(Console.ReadLine());

            total = a+b+c;

            Console.WriteLine();
            Console.WriteLine("The subtotal is: {0,10}", total.ToString("C"));

            Console.ReadKey();

            tax = total * taxRate;
            Console.WriteLine();
            Console.WriteLine("The tax amount is: {0,10}", tax.ToString("C"));

            grand = (total * taxRate) + total;
            Console.WriteLine();
            Console.WriteLine("The grand total amount is: {0,10}", grand.ToString("C"));

        }
    }
}