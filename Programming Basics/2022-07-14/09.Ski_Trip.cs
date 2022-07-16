using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред -дни за престой -цяло число в интервала[0...365]
            //•	Втори ред -вид помещение - "room for one person", "apartment" или "president apartment"
            //•	Трети ред -оценка - "positive"  или "negative"
            int daysForTheStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();
            double priceWithoutDiscount = 0.0;
            double price = 0.0;
            

            if(typeOfRoom == "room for one person")
            {
                if(daysForTheStay < 10)
                {
                    priceWithoutDiscount = (daysForTheStay - 1) * 18;
                }
                else if(daysForTheStay >= 10 && daysForTheStay <= 15)
                {
                    priceWithoutDiscount = (daysForTheStay - 1) * 18;
                }
                else
                {
                    priceWithoutDiscount = (daysForTheStay - 1) * 18;
                }
            }
            else if(typeOfRoom == "apartment")
            {
                if (daysForTheStay < 10)
                {
                    price = ((daysForTheStay - 1) * 25);
                    priceWithoutDiscount = price - (price * 0.3);
                }
                else if (daysForTheStay >= 10 && daysForTheStay <= 15)
                {
                    price = ((daysForTheStay - 1) * 25);
                    priceWithoutDiscount = price - (price * 0.35);
                }
                else
                {
                    price = ((daysForTheStay - 1) * 25);
                    priceWithoutDiscount = price - (price * 0.5);
                }
            }
            else
            {
                if (daysForTheStay < 10)
                {
                    price = ((daysForTheStay - 1) * 35);
                    priceWithoutDiscount = price - (price * 0.1);
                }
                else if (daysForTheStay >= 10 && daysForTheStay <= 15)
                {
                    price = ((daysForTheStay - 1) * 35);
                    priceWithoutDiscount = price + (price * 0.15);
                }
                else
                {
                    price = ((daysForTheStay - 1) * 35);
                    priceWithoutDiscount = price - (price * 0.2);
                }
            }
            if(rating == "positive")
            {
                priceWithoutDiscount = priceWithoutDiscount + (priceWithoutDiscount * 0.25);
            }
            else
            {
                priceWithoutDiscount = priceWithoutDiscount - (priceWithoutDiscount * 0.1);
            }
            Console.WriteLine($"{priceWithoutDiscount:F2}");
        }
    }
}

