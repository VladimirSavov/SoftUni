using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            //Ред 1.Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            //Ред 2.Брой на статистите – цяло число в интервала[1 … 500]
            //Ред 3.Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]
            double budget = double.Parse(Console.ReadLine());
            int countStatics = int.Parse(Console.ReadLine());
            double clothingPice = double.Parse(Console.ReadLine());
            double decor = budget * 0.1;
            if (countStatics > 150) 
            {
                clothingPice = clothingPice - (clothingPice * 0.1);
            }
            double totalPrice = (countStatics * clothingPice) + decor;
            if (totalPrice > budget)
            {
                double missingMoney = totalPrice - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {missingMoney:F2} leva more.");
            }
            if(totalPrice <= budget)
            {
                double remainingMoney = budget - totalPrice;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {remainingMoney:F2} leva left.");
            }
        }
    }
}
