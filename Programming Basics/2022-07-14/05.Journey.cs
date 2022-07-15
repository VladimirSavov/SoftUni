using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double percentOfBudget = 0.0;
            string kindOfVacation = "";
            if (season == "summer" && budget <= 100)
            {
                destination = "Bulgaria";
                percentOfBudget = 0.3;
                kindOfVacation = "Camp";
            }
            else if (season == "winter" && budget <= 100)
            {
                destination = "Bulgaria";
                percentOfBudget = 0.7;
                kindOfVacation = "Hotel";
            }
            else if (season == "summer" && budget <= 1000)
            {
                destination = "Balkans";
                percentOfBudget = 0.4;
                kindOfVacation = "Camp";
            }
            else if (season == "winter" && budget <= 1000)
            {
                destination = "Balkans";
                percentOfBudget = 0.8;
                kindOfVacation = "Hotel";
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                percentOfBudget = 0.9;
                kindOfVacation = "Hotel";
            }
            double priceForDestination = budget * percentOfBudget;

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{kindOfVacation} - {priceForDestination:F2}");
        }
    }
}

