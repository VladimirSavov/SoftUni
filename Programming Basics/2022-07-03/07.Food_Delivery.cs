using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            //    Брой пилешки менюта – цяло число в интервала[0 … 99]
            //•	Брой менюта с риба – цяло число в интервала[0 … 99]
            //•	Брой вегетариански менюта – цяло число в интервала[0 … 99]
            int chikenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());
            double totalPriceWithoutdessert = (chikenMenus * 10.35) + (fishMenus * 12.4) + (vegetarianMenus * 8.15);
            double dessert = totalPriceWithoutdessert * 0.2;

            Console.WriteLine(totalPriceWithoutdessert + dessert + 2.5);


        }
    } 
}
