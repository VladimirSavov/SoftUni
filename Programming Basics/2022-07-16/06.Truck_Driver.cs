using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – Сезон – текст "Spring", "Summer", "Autumn" или "Winter"
            //•	Втори ред –  Километри на месец – реално число в интервала[10.00...20000.00]
            string season = Console.ReadLine();
            double kmForMonth = double.Parse(Console.ReadLine());
            double priceForkm = 0.0;

            if(kmForMonth <= 5000)
            {
                if(season == "Spring" || season == "Autumn")
                {
                    priceForkm = 0.75;
                }
                else if(season == "Summer")
                {
                    priceForkm = 0.90;
                }
                else
                {
                    priceForkm = 1.05;
                }
            }
            else if(kmForMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    priceForkm = 0.95;
                }
                else if (season == "Summer")
                {
                    priceForkm = 1.10;
                }
                else
                {
                    priceForkm = 1.25;
                }
            }
            else
            {
                priceForkm = 1.45;
            }
            double price = ((kmForMonth * priceForkm) * 4) * 0.90;
            Console.WriteLine($"{price:F2}");
        }
    }
}

