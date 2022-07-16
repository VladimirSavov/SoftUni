using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double priceForCar = 0.0;  
            string typeCar = "";
            string typeClass = "";

            if(budget <= 100)
            {
                typeClass = "Economy class";
                if(season == "Summer")
                {
                    typeCar = "Cabrio";
                    priceForCar = budget * 0.35;
                }
                else
                {
                    typeCar = "Jeep";
                    priceForCar = budget * 0.65;
                }
            }
            else if(budget > 100 && budget <= 500)
            {
                typeClass = "Compact class";
                if (season == "Summer")
                {
                    typeCar = "Cabrio";
                    priceForCar = budget * 0.45;
                }
                else
                {
                    typeCar = "Jeep";
                    priceForCar = budget * 0.80;
                }
            }
            else
            {
                typeClass = "Luxury class";
                typeCar = "Jeep";
                priceForCar = budget * 0.90;

            }
            Console.WriteLine($"{typeClass}");
            Console.WriteLine($"{typeCar} - {priceForCar:F2}");
        }
    }
}

