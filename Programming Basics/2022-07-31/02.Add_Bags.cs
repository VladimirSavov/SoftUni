using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Цената на багаж над 20кг - реално число в диапазона[10.0…80.0]
            //2.Килограми на багажа – реално число в диапазона[1.0…32.0]
            //3.Дни до пътуването – цяло число в диапазона[1…60]
            //4.Брой багажи – цяло число в диапазона[1…10]
            double priceForBaggage = double.Parse(Console.ReadLine());
            double kilogramsOfBaggage = double.Parse(Console.ReadLine());
            int remainingDays = int.Parse(Console.ReadLine());
            int numberOfBaggages = int.Parse(Console.ReadLine());
            double finalPriceForBaggage = 0;
            if (kilogramsOfBaggage < 10)
            {
                finalPriceForBaggage = priceForBaggage * 0.2;
            }
            else if (kilogramsOfBaggage >= 10 && kilogramsOfBaggage <= 20)
            {
                finalPriceForBaggage = priceForBaggage * 0.5;
            }
            else if (kilogramsOfBaggage > 20)
            {
                finalPriceForBaggage = priceForBaggage;
            }
            if(remainingDays > 30)
            {
                finalPriceForBaggage = finalPriceForBaggage + (finalPriceForBaggage * 0.1);
            }
            else if (remainingDays >= 7 && remainingDays <= 30)
            {
                finalPriceForBaggage = finalPriceForBaggage + (finalPriceForBaggage * 0.15);
            }
            else if (remainingDays < 7)
            {
                finalPriceForBaggage = finalPriceForBaggage + (finalPriceForBaggage * 0.4);
            }
            double priceForAllBaggages = numberOfBaggages * finalPriceForBaggage;

            Console.WriteLine($"The total price of bags is: {priceForAllBaggages:F2} lv. ");
        }
    }
}
