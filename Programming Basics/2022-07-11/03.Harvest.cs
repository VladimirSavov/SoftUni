using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	1ви ред: X кв.м е лозето – цяло число в интервала[10 … 5000]
            //•	2ри ред: Y грозде за един кв.м – реално число в интервала[0.00 … 10.00]
            //•	3ти ред: Z нужни литри вино – цяло число в интервала[10 … 600]
            //•	4ти ред: брой работници – цяло число в интервала[1 … 20]
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double allGrapes = x * y;
            double wine = 0.4 * allGrapes / 2.5;

            if(wine < z)
            {
                double missingWine = z - wine;

                Console.WriteLine($"It will be a tough winter! More {Math.Floor(missingWine)} liters wine needed.");
            }
            else if (wine >= z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");

                double leftWine = wine - z;
                double WineforOneWorker = leftWine / numberOfWorkers;

                Console.WriteLine($"{Math.Ceiling(leftWine)} liters left -> {Math.Ceiling(WineforOneWorker)} liters per person.");
            }
        }
    }
}
