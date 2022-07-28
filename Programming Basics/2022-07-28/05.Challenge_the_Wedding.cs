using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int males = int.Parse(Console.ReadLine());
            int females = int.Parse(Console.ReadLine());
            int maxTables = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= males; i++)
            {
                for (int l = 1; l <= females; l++)
                {
                    counter++;
                    while (counter <= maxTables)
                    {
                        Console.Write($"({i} <-> {l}) ");
                        break;
                    }
                }
            }

        }

    }
}
