﻿using static System.Console;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            welcomeMessage();

            for (int k = 0; k < 1; k++)
            {

                a = askLength();
                b = askWidth();

                findArea(a, b);
                findTaxRate(a, b);


            }


            WriteLine("This is the end my friend");

            ReadKey();
        }

        static void welcomeMessage()
        {
            WriteLine("Welcome here you will find the area and then your tax rate!");

            ReadKey();
        }

        static int magicNumber()
        {
            int m;
            WriteLine("Please enter your magic number!");
            m = Convert.ToInt32(Console.ReadLine());

            return m;
        }


        static int askLength()
        {

            int x;
            WriteLine("Please enter the length");
            x = Convert.ToInt32(Console.ReadLine());

            return x;



        }

        static int askWidth()
        {
            int x;
            WriteLine("Please enter the width");
            x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        static void findArea(int num1, int num2)
        {
            int total = num1 * num2;

               WriteLine("The area is : " + total);

        }

        static void findTaxRate(int num1, int num2)
        {
            int taxRate = 2;
            int total= (num1 * num2) * taxRate;

            WriteLine("Your local tax rate is : " + total.ToString("C"));
            
        }
    }
}