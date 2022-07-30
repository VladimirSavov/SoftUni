using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int roof = 0;


            if (n % 2 == 0)
            {
                roof = 2;
            }
            else
            {
                roof = 1;
            }
            Console.Write(new string('-', (n - roof) / 2));
            Console.Write(new string('*', roof));
            Console.Write(new string('-', (n - roof) / 2));
            Console.WriteLine();

            if (roof == 1)
            {
                for (int i = 1; i <= n / 2; i++)
                {
                    if (i < n / 2)
                    {
                        Console.Write(new string('-', (n - roof) / 2 - i));
                    }
                    Console.Write(new string('*', roof + i * 2));
                    if (i < n / 2)
                    {
                        Console.Write(new string('-', (n - roof) / 2 - i));
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= n / 2 - 1; i++)
                {
                    if (i < n / 2)
                    {
                        Console.Write(new string('-', (n - roof) / 2 - i));
                    }
                    Console.Write(new string('*', roof + i * 2));
                    if (i < n / 2)
                    {
                        Console.Write(new string('-', (n - roof) / 2 - i));
                    }
                    Console.WriteLine();
                }
            }

            for (int j = 0; j < n / 2; j++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
