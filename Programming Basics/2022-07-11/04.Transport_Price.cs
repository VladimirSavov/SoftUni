using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (n < 20 && time == "day")
            {
                double price = 0.70 + n * 0.79;
                Console.WriteLine("{0:F2}", price);
            }
            else if (n < 20 && time == "night")
            {
                double price = 0.70 + n * 0.90;
                Console.WriteLine("{0:F2}", price);
            }
            else if (n <= 100)
            {
                double price = n * 0.09;
                Console.WriteLine("{0:F2}", price);
            }
            else if (n >= 100)
            {
                double price = n * 0.06;
                Console.WriteLine("{0:F2}", price);
            }
        }
    }
}
