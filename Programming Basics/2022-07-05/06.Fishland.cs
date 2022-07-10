using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {      
                //•	Паламуд – 60 % по - скъп от скумрията
                //•	Сафрид – 80 % по - скъп от цацата
                //•	Миди – 7.50 лв.за килограм

            //  Първи ред – цена на скумрията на килограм.Реално число в интервала[0.00…40.00]
            //•	Втори ред – цена на цацата на килограм.Реално число в интервала[0.00…30.00]
            //•	Трети ред – килограма паламуд. Реално число в интервала[0.00…50.00]
            //•	Четвърти ред – килограма сафрид. Реално число в интервала[0.00… 70.00]
            //•	Пети ред – килограма миди. Цяло число в интервала[0... 100]
            double mackerelPricePerKilo = double.Parse(Console.ReadLine());
            double sprinklelPricePerKilo = double.Parse(Console.ReadLine());
            double kiloBonito = double.Parse(Console.ReadLine());
            double kiloSafrid = double.Parse(Console.ReadLine());
            int kiloMussels = int.Parse(Console.ReadLine());

            double bonitoPricePerKilo = mackerelPricePerKilo + mackerelPricePerKilo * 0.6;
            double safridPricePerKilo = bonitoPricePerKilo * kiloBonito;
            double priceSafrid = sprinklelPricePerKilo + sprinklelPricePerKilo * 0.8;
            double safriddPricePerKilo = priceSafrid * kiloSafrid;
            double musselPricePerKilo = kiloMussels * 7.5;
            double totalPrice = safridPricePerKilo + musselPricePerKilo + safriddPricePerKilo;
            Console.WriteLine("{0:F2}", totalPrice);


            
        }
    } 
}
