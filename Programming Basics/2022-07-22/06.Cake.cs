using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeHeight = int.Parse(Console.ReadLine());
            int cakeWeight = int.Parse(Console.ReadLine());
            int totalPieces = cakeHeight * cakeWeight;
            string taken = Console.ReadLine();
            while(totalPieces > 0)
            {
                if(taken != "STOP")
                {
                    totalPieces -= int.Parse(taken);
                }
                else
                {
                    break;
                }
                taken = Console.ReadLine();
            }
            if(totalPieces > 0)
            {
                Console.WriteLine($"{totalPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
            }
        }

    }
}

