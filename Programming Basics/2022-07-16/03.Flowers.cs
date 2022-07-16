using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред е броят на закупените хризантеми – цяло число в интервала[0... 200]
            //•	На втория ред е броят на закупените рози – цяло число в интервала[0... 200]
            //•	На третия ред е броят на закупените лалета – цяло число в интервала[0... 200]
            //•	На четвъртия ред е посочен сезона – [Spring, Summer, Аutumn, Winter]
            //•	На петия ред е посочено дали денят е празник – [Y – да / N - не]

            int boughtHrizantemi = int.Parse(Console.ReadLine());
            int boughtRoses = int.Parse(Console.ReadLine());
            int boughtTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidayOrNot = Console.ReadLine();

            if(season == "Spring" || season == "Summer")
            {
                double totalPrice = (boughtHrizantemi * 2) + (boughtRoses * 4.1) + (boughtTulips * 2.5);
                double totalFlowers = boughtHrizantemi + boughtRoses + boughtTulips;
                if(holidayOrNot == "Y")
                {
                    totalPrice = totalPrice + (totalPrice * 0.15);
                }
                if(boughtTulips > 5 && season == "Spring")
                {
                    totalPrice = totalPrice - (totalPrice * 0.05);
                }
                if(totalFlowers >= 20)
                {
                    totalPrice = totalPrice - (totalPrice * 0.2);
                }
                Console.WriteLine($"{2 + totalPrice:F2}");
            }
            else
            {
                double totalPrice = (boughtHrizantemi * 3.75) + (boughtRoses * 4.5) + (boughtTulips * 4.15);
                double totalFlowers = boughtHrizantemi + boughtRoses + boughtTulips;
                if (holidayOrNot == "Y")
                {
                    totalPrice = totalPrice + (totalPrice * 0.15);
                }
                if (boughtRoses >= 10 && season == "Winter")
                {
                    totalPrice = totalPrice - (totalPrice * 0.1);
                }
                if (totalFlowers >= 20)
                {
                    totalPrice = totalPrice - (totalPrice * 0.2);
                }
                Console.WriteLine($"{2 + totalPrice:F2}");
            }
        }
    }
}

