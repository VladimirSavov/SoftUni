using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                sum = sum + value;
            }
            Console.WriteLine(sum);
        }
    }
}

