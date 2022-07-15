using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред е месецът – May, June, July, August, September или October
            //•	На втория ред е броят на нощувките – цяло число в интервала[0... 200]
            string mounth = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double priceWithDiscountOfStudio = 0.0;
            double priceWithDiscountOfApartament = 0.0;

            if(mounth == "May" || mounth == "October")
            {
                double studio = 50;
                double apartament = 65;
                if(numberOfNights <= 14)
                {
                    priceWithDiscountOfStudio = studio - (studio * 0.05);
                    priceWithDiscountOfApartament = apartament;
                }
                else if(numberOfNights > 14)
                {
                    priceWithDiscountOfStudio = studio - (studio * 0.3);
                    priceWithDiscountOfApartament = apartament - (apartament * 0.1);
                }
                else
                {
                    Console.WriteLine($"Apartment: {numberOfNights * apartament:F2} lv.");
                    Console.WriteLine($"Studio: {numberOfNights * studio:F2} lv.");
                }
            }
            else if (mounth == "June" || mounth == "September")
            {
                double studio = 75.20;
                double apartament = 68.70;
                if(numberOfNights > 14)
                {
                    priceWithDiscountOfStudio = studio - (studio * 0.2);
                    priceWithDiscountOfApartament = apartament - (apartament * 0.1);
                }
                else
                {
                    Console.WriteLine($"Apartment: {numberOfNights * apartament:F2} lv.");
                    Console.WriteLine($"Studio: {numberOfNights * studio:F2} lv.");
                }
            }
            else 
            {
                double studio = 76;
                double apartament = 77;
                if (numberOfNights > 14)
                {
                    priceWithDiscountOfApartament = apartament - (apartament * 0.1);
                    priceWithDiscountOfStudio = studio;
                }
                else
                {
                    Console.WriteLine($"Apartment: {numberOfNights * apartament:F2} lv.");
                    Console.WriteLine($"Studio: {numberOfNights * studio:F2} lv.");
                }
            }
            if (priceWithDiscountOfApartament != 0)
            {
                double priceForAllPeriodA = numberOfNights * priceWithDiscountOfApartament;
                double priceForAllPeriodS = numberOfNights * priceWithDiscountOfStudio;
                Console.WriteLine($"Apartment: {priceForAllPeriodA:F2} lv.");
                Console.WriteLine($"Studio: {priceForAllPeriodS:F2} lv.");
            }

        }
    }
}

