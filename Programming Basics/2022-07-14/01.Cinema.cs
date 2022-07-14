using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int coloums = int.Parse(Console.ReadLine());

            double income = 0.0;

            if(type == "Premiere")
            {
                income = rows * coloums * 12;
                Console.WriteLine($"{income:F2} leva");
            }
            else if(type == "Normal")
            {
                income = rows * coloums * 7.5;
                Console.WriteLine($"{income:F2} leva");
            }
            else if(type == "Discount")
            {
                income = rows * coloums * 5;
                Console.WriteLine($"{income:F2} leva");
            }
        }
    }
}

