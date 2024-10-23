using System;
using System.Linq;
using static System.Console;
namespace CW9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Stephens", "Jordan", "Gretzky" };

            
            //3 means 3  not 0123
            double[] quiz = new double[3];

            double[] test = new double[3];

            double[] assignment = new double[3];

            for(int x =0; x< names.Length; x++)
            {
                WriteLine("Please enter the quiz average for {0}", names[x]);
                quiz[x] = Convert.ToDouble(ReadLine());

                WriteLine("Please enter the test average for {0}", names[x]);
                test[x] = Convert.ToDouble(ReadLine());

                WriteLine("Please enter the assignment average for {0}", names[x]);
                assignment[x] = Convert.ToDouble(ReadLine());
            }

            WriteLine("{0,15}{1,15}{2,15}{3,15}", "Name", "Quiz", "Test", "Assignment");

            for (int y = 0; y < names.Length; y++)
            {

                WriteLine("{0,15}{1,15}{2,15}{3,15}", names[y], quiz[y], test[y], assignment[y]);
            }

            //foreach loop
            
            
            int i = 0;

            foreach (var name in names)
            {
                

                double avg;

                avg = (quiz[i] + test[i] + assignment[i]) / 3;

                WriteLine("{0,15}{1,15}", name, avg.ToString("F2"));

                i++;
            }

            //linq built in method

            double m = quiz.Max();

            int p = Array.IndexOf(quiz, m);

            WriteLine("The highest quiz grade belongs to:" + names[p]);


            //sort puts in abc order do it before you do anything to avoid data issues, it will move the names but won't sort the index along with it

            WriteLine(names[0] + " " + names[1] + " " + names[2]);
            
            Array.Sort(names);

            WriteLine(names[0] + " " + names[1] + " " + names[2]);


        }
    }
}