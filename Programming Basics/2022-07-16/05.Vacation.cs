using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – Бюджет – реално число в интервала[10.00...10000.00]
            //•	Втори ред –  Сезон – текст "Summer" или "Winter"
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string accommodation = "";
            string location = "";
            double price = 0.0;

            if (budget <= 1000)
            {
                accommodation = "Camp";
                if(season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }

            }
            else if(budget > 1000 && budget <= 3000)
            {
                accommodation = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.80;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.60;
                }
            }
            else
            {
                accommodation = "Hotel";
                price = budget * 0.90;
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else
                {
                    location = "Morocco";
                }
            }
            Console.WriteLine($"{location} – {accommodation} – {price:F2}");
        }
    }
}

