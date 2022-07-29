using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));

                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();
            }

            for (int j = n - 1; j >= 1; j--)
            {
                Console.Write(new string(' ', n - j));

                for (int k = 0; k < j; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
