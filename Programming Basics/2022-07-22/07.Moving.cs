using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int totalFreeSpace = weight * lenght * height;
            string numberOfCartons = Console.ReadLine();
            while(numberOfCartons != "Done")
            {
                if (totalFreeSpace >= 0)
                {
                    totalFreeSpace -= int.Parse(numberOfCartons);
                }
                if(totalFreeSpace < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(totalFreeSpace)} Cubic meters more.");
                    break;
                }
                numberOfCartons = Console.ReadLine();
            }
            if(numberOfCartons == "Done")
            {
                Console.WriteLine($"{totalFreeSpace} Cubic meters left.");
            }
        }

    }
}

