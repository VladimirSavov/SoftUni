using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първият ред – броят младши велосипедисти.Цяло число в интервала[1…100]
            //•	Вторият ред – броят старши велосипедисти.Цяло число в интервала[1… 100]
            //•	Третият ред – вид трасе – "trail", "cross-country", "downhill" или "road"
            int numberJuniors = int.Parse(Console.ReadLine());
            int numberSeniors = int.Parse(Console.ReadLine());
            string typeTrack = Console.ReadLine();

            int totalPeople = numberJuniors + numberSeniors;

            if (typeTrack == "trail")
            {
                double priceForJuniors = 0.0;
                double priceForSeniors = 0.0;
                priceForJuniors = numberJuniors * 5.5;
                priceForSeniors = numberSeniors * 7;

                double totalPrice = priceForJuniors + priceForSeniors;
                double PriceWithExpenses = totalPrice - (totalPrice * 0.05);
                Console.WriteLine($"{PriceWithExpenses:f2}");
            }
            else if(typeTrack == "cross-country")
            {
                if(totalPeople >= 50)
                {
                    double priceForJuniors = 0.0;
                    double priceForSeniors = 0.0;
                    priceForJuniors = numberJuniors * 8;
                    priceForSeniors = numberSeniors * 9.50;
                    double totalPrice = priceForJuniors + priceForSeniors;
                    double priceWithDiscount = totalPrice - (totalPrice * 0.25);
                    double PriceWithExpenses = priceWithDiscount - (priceWithDiscount * 0.05);
                    Console.WriteLine($"{PriceWithExpenses:f2}");


                }
                else
                {
                    double priceForJuniors = 0.0;
                    double priceForSeniors = 0.0;
                    priceForJuniors = numberJuniors * 8;
                    priceForSeniors = numberSeniors * 9.50;
                    double totalPrice = priceForJuniors + priceForSeniors;
                    double PriceWithExpenses = totalPrice - (totalPrice * 0.05);
                    Console.WriteLine($"{PriceWithExpenses:f2}");
                }
            }
            else if(typeTrack == "downhill")
            {
                double priceForJuniors = 0.0;
                double priceForSeniors = 0.0;
                priceForJuniors = numberJuniors * 12.25;
                priceForSeniors = numberSeniors * 13.75;
                double totalPrice = priceForJuniors + priceForSeniors;
                double PriceWithExpenses = totalPrice - (totalPrice * 0.05);
                Console.WriteLine($"{PriceWithExpenses:f2}");
            }
            else
            {
                double priceForJuniors = 0.0;
                double priceForSeniors = 0.0;
                priceForJuniors = numberJuniors * 20;
                priceForSeniors = numberSeniors * 21.50;
                double totalPrice = priceForJuniors + priceForSeniors;
                double PriceWithExpenses = totalPrice - (totalPrice * 0.05);
                Console.WriteLine($"{PriceWithExpenses:f2}");
            }
        }
    }
}

