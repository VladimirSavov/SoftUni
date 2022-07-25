using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n < 11; n++)
            {
                for (int m = 1; m < 11; m++)
                {
                    int b = n * m;
                    Console.WriteLine($"{n} * {m} = {b}");
                }
            }
        }

    }
}

