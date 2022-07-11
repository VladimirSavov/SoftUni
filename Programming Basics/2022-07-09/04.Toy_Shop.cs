using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            //1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            //2.Брой пъзели - цяло число в интервала[0… 1000]
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            //6.Брой камиончета - цяло число в интервала[0 … 1000]

            double pricePerExcursion = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfTalkingDolls = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOftrucks = int.Parse(Console.ReadLine());
            double totalToys = numberOfPuzzles + numberOfTalkingDolls + numberOfTeddyBears + numberOfMinions + numberOftrucks;
            double totalPrice = (numberOfPuzzles * 2.6) + (numberOfTalkingDolls * 3) + (numberOfTeddyBears * 4.1) + (numberOfMinions * 8.2) + (numberOftrucks * 2);
            if(totalToys >= 50)
            {
                totalPrice = totalPrice - (totalPrice * 0.25);
            }
             totalPrice = totalPrice - (totalPrice * 0.1);
            if(pricePerExcursion <= totalPrice)
            {
                double result = totalPrice - pricePerExcursion;
                Console.WriteLine($"Yes! {result:F2} lv left.");
            }
            if(pricePerExcursion > totalPrice)
            {
                double result = pricePerExcursion - totalPrice;
                Console.WriteLine($"Not enough money! {result:F2} lv needed.");
            }
        }
    }
}
