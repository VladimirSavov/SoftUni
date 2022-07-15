using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Бюджет на групата – цяло число в интервала[1…8000]
            //•	Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
            //•	Брой рибари – цяло число в интервала[4…18]
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen = int.Parse(Console.ReadLine());

            double discount = 0.0;
            int rentalPrice = 0;
            if(season == "Spring")
            {
                rentalPrice = 3000;
                if(numberOfFishermen <= 6)
                {
                    discount = rentalPrice - (rentalPrice * 0.1);
                }
                else if(numberOfFishermen <= 11)
                {
                    discount = rentalPrice - (rentalPrice * 0.15);
                }
                else
                {
                    discount = rentalPrice - (rentalPrice * 0.25);
                }
            }
            else if (season == "Summer")
            {
                rentalPrice = 4200;
                if (numberOfFishermen <= 6)
                {
                    discount = rentalPrice - (rentalPrice * 0.1);
                }
                else if (numberOfFishermen <= 11)
                {
                    discount = rentalPrice - (rentalPrice * 0.15);
                }
                else
                {
                    discount = rentalPrice - (rentalPrice * 0.25);
                }
            }
            else if (season == "Autumn")
            {
                rentalPrice = 4200;
                if (numberOfFishermen <= 6)
                {
                    discount = rentalPrice - (rentalPrice * 0.1);
                }
                else if (numberOfFishermen <= 11)
                {
                    discount = rentalPrice - (rentalPrice * 0.15);
                }
                else
                {
                    discount = rentalPrice - (rentalPrice * 0.25);
                }
            }
            else if (season == "Winter")
            {
                rentalPrice = 2600;
                if (numberOfFishermen <= 6)
                {
                    discount = rentalPrice - (rentalPrice * 0.1);
                }
                else if (numberOfFishermen <= 11)
                {
                    discount = rentalPrice - (rentalPrice * 0.15);
                }
                else
                {
                    discount = rentalPrice - (rentalPrice * 0.25);
                }
            }
            if(numberOfFishermen % 2 == 0 && (season == "Summer" || season == "Spring" || season == "Winter"))
            {
                discount = discount - (discount * 0.05);
            }
            if(budget >= discount)
            {
                double remainingMoney = budget - discount;
                Console.WriteLine($"Yes! You have {remainingMoney:F2} leva left.");
            }
            else
            {
                double needenMoney = discount - budget;
                Console.WriteLine($"Not enough money! You need {needenMoney:F2} leva.");
            }

        }
    }
}

