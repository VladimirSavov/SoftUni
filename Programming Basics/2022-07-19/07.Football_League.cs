using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int allFans = int.Parse(Console.ReadLine());
            string sector = "";
            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;
            for (int i = 1; i <= allFans; i++)
            {
                sector = Console.ReadLine();
                if(sector == "A")
                {
                    sectorA++;
                }
                else if (sector == "B")
                {
                    sectorB++;
                }
                else if (sector == "V")
                {
                    sectorV++;
                }
                else if (sector == "G")
                {
                    sectorG++;
                }
            }
            double percentForA = (double)sectorA / allFans * 100;
            double percentForB = (double)sectorB / allFans * 100;
            double percentForV = (double)sectorV / allFans * 100;
            double percentForG = (double)sectorG / allFans * 100;
            double percentForTeam = (double)allFans / capacity * 100;

            Console.WriteLine($"{percentForA:F2}%");
            Console.WriteLine($"{percentForB:F2}%");
            Console.WriteLine($"{percentForV:F2}%");
            Console.WriteLine($"{percentForG:F2}%");
            Console.WriteLine($"{percentForTeam:F2}%");

        }
    }
}
