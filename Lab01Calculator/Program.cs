using System;

namespace Lab01Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Please input number A + B ");
            Console.WriteLine("------------------------- ");

            Console.WriteLine("Input number A : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input number B : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Summary: " + (num1 + num2));
            Console.ReadLine();

        }
    }
}
