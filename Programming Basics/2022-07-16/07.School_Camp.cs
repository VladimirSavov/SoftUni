using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Сезонът – текст - “Winter”, “Spring” или “Summer”;
            //2.Видът на групата – текст - “boys”, “girls” или “mixed”;
            //3.Брой на учениците – цяло число в интервала[1 … 10000];
            //4.Брой на нощувките – цяло число в интервала[1 … 100].
            string season = Console.ReadLine();
            string typeGroup = Console.ReadLine();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int NumberOfNights = int.Parse(Console.ReadLine());

            double priceForNight = 0.0;
            string sport = "";
            if(season == "Winter")
            {
                if(typeGroup == "boys")
                {
                    sport = "Judo";
                    priceForNight = 9.6;
                }
                else if (typeGroup == "girls")
                {
                    sport = "Gymnastics";
                    priceForNight = 9.6;
                }
                else
                {
                    sport = "Ski";
                    priceForNight = 10;
                }
            }
            else if(season == "Spring")
            {
                if (typeGroup == "boys")
                { 
                    sport = "Tennis";
                    priceForNight = 7.2;
                }
                else if (typeGroup == "girls")
                {
                    sport = "Athletics";
                    priceForNight = 7.2;
                }
                else
                {
                    sport = "Cycling";
                    priceForNight = 9.5;
                }
            }
            else
            {
                if (typeGroup == "boys")
                {
                    sport = "Football";
                    priceForNight = 15;
                }
                else if (typeGroup == "girls")
                {
                    sport = "Volleyball";
                    priceForNight = 15;
                }
                else
                {
                    sport = "Swimming";
                    priceForNight = 20;
                }
            }
            double priceWtihoutDiscount = NumberOfNights * priceForNight * numberOfStudents;
            if (numberOfStudents >= 50)
            {
                priceWtihoutDiscount = priceWtihoutDiscount * 0.5;
            }
            else if(numberOfStudents >= 20 && numberOfStudents < 50)
            {
                priceWtihoutDiscount = priceWtihoutDiscount * 0.85;
            }
            else if(numberOfStudents >= 10 && numberOfStudents < 20)
            {
                priceWtihoutDiscount = priceWtihoutDiscount * 0.95;
            }
            Console.WriteLine($"{sport} {priceWtihoutDiscount:F2} lv.");
        }
    }
}

