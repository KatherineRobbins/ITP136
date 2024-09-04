namespace CloneCW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //this is a single line comment

            /*multi line comment
             * etc 
             * etc
             */

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Your name is " + userName);
        }
    }
}