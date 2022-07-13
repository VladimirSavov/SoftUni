using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Брой магнолии – цяло число в интервала[0 … 50]
            //•	Брой зюмбюли – цяло число в интервала[0 … 50]
            //•	Брой рози – цяло число в интервала[0 … 50]
            //•	Брой кактуси – цяло число в интервала[0 … 50]
            //•	Цена на подаръка – реално число в интервала[0.00 … 500.00]
            
            int mangolds = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int kaktysi = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double totalSum = (mangolds * 3.25) + (hyacinths * 4) + (rose * 3.5) + (kaktysi * 8);
            double totalSumWithDiscount = totalSum - (totalSum * 0.05);

            if(totalSumWithDiscount >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalSumWithDiscount - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - totalSumWithDiscount)} leva.");
            }

        }
    }
}
