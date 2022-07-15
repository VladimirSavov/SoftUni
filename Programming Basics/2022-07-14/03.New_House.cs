using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //•	Брой цветя -цяло число в интервала[10…1000]
            //•	Бюджет - цяло число в интервала[50…2500]
            string kindOfFlowers = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalSum = 0.0;

            if(kindOfFlowers == "Roses")
            {
                totalSum = countFlowers * 5;
                if(countFlowers > 80)
                {
                    totalSum = totalSum - (totalSum * 0.1);
                }
            }
            else if (kindOfFlowers == "Dahlias")
            {
                totalSum = countFlowers * 3.8;
                if (countFlowers > 90)
                {
                    totalSum = totalSum - (totalSum * 0.15);
                }
            }
            else if (kindOfFlowers == "Tulips")
            {
                totalSum = countFlowers * 2.8;
                if (countFlowers > 80)
                {
                    totalSum = totalSum - (totalSum * 0.15);
                }
            }
            else if (kindOfFlowers == "Narcissus")
            {
                totalSum = countFlowers * 3;
                if (countFlowers < 120)
                {
                    totalSum = totalSum + (totalSum * 0.15);
                }
            }
            else if (kindOfFlowers == "Gladiolus")
            {
                totalSum = countFlowers * 2.5;
                if (countFlowers < 80)
                {
                    totalSum = totalSum + (totalSum * 0.2);
                }
            }
            if (budget >= totalSum)
            {
                double remainingSum = budget - totalSum;
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {kindOfFlowers} and {remainingSum:F2} leva left.");
            }
            else
            {
                double needenSum = totalSum - budget;
                Console.WriteLine($"Not enough money, you need {needenSum:F2} leva more.");
            }
        }
    }
}

