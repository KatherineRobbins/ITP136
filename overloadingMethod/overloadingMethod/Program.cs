using static System.Console;

namespace overloadingMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = overloadingMethod(2, 3);

            double b = overloadingMethod(4.5, 5.5);

            int c = overloadingMethod(20);

            int d = overloadingMethod(1, 2, 3);

            welcomeMessage();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }

        static void welcomeMessage()
        {
            WriteLine("Here is an example of Method Overloading");

            ReadKey();
        }

        static int overloadingMethod(int x, int y)

        {

            return x * y;

        }

        static double overloadingMethod(double x, double y)

        {

            return x * y;

        }

        static int overloadingMethod(int x)
        {
            return x;
        }

        static int overloadingMethod( int x, int y, int z)
        {
            return x + y + z;
        }
        /*this is an example of what overloading is not
        static int overloadingMethod(int b, int c, int d)
        {
            return b + c + d;
        }*/
    }
}