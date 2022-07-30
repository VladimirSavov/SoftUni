using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLoads = int.Parse(Console.ReadLine());
            double withVan = 0;
            double withTruck = 0;
            double withTrain = 0;
            int totalTons = 0;
            for (int i = 1; i <= numberOfLoads; i++)
            {
                int cargoTonnage = int.Parse(Console.ReadLine());
                totalTons += cargoTonnage;
                if(cargoTonnage <= 3)
                {
                    withVan += cargoTonnage;
                }
                else if(cargoTonnage >= 4 && cargoTonnage <= 11)
                {
                    withTruck += cargoTonnage;
                }
                else
                {
                    withTrain += cargoTonnage;
                }
            }
            double averagePrice = ((withVan * 200) + (withTruck * 175) + (withTrain * 120)) / totalTons;
            double percentWithVan = withVan / totalTons * 100;
            double percentWithTruck = withTruck / totalTons * 100;
            double percentWithTrain = withTrain / totalTons * 100;

            Console.WriteLine($"{averagePrice:F2}");
            Console.WriteLine($"{percentWithVan:F2}%");
            Console.WriteLine($"{percentWithTruck:F2}%");
            Console.WriteLine($"{percentWithTrain:F2}%");
        }
    }
}
