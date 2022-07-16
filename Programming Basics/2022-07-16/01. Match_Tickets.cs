using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред е бюджетът – реално число в интервала[1 000.00... 1 000 000.00]
            //•	На втория ред е категорията – "VIP" или "Normal"
            //•	На третия ред е броят на хората в групата – цяло число в интервала[1... 200]
            int budget = int.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());


            double ip = 499.99;
            double normal = 249.99;
            double remainingMoney = 0.0;
            double priceForTicket = 0.0;

            if(numberOfPeople <= 4)
            {
                remainingMoney = budget - (budget * 0.75);
            }
            else if(numberOfPeople <= 9)
            {
                remainingMoney = budget - (budget * 0.60);
            }
            else if (numberOfPeople <= 24)
            {
                remainingMoney = budget - (budget * 0.50);
            }
            else if (numberOfPeople <= 49)
            {
                remainingMoney = budget - (budget * 0.40);
            }
            else if (numberOfPeople >= 50)
            {
                remainingMoney = budget - (budget * 0.25);
            }
            if (category == "VIP")
            {
                priceForTicket = ip * numberOfPeople;
            }
            if(category == "Normal")
            {
                priceForTicket = normal * numberOfPeople;
            }
            if (remainingMoney >= priceForTicket) 
            { 
                Console.WriteLine($"Yes! You have {remainingMoney - priceForTicket:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {priceForTicket - remainingMoney:F2} leva.");
            }

        }
    }
}

