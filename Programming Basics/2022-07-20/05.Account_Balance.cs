using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            while (input != "NoMoreMoney")
            {
                double number = double.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += number;
                Console.WriteLine($"Increase: {number:F2}");
               
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:F2}");
        }
          
    }
}

