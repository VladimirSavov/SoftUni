using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int paymentType = 0;
            int count = 0;
            int totalWithCC = 0;
            int totalWithCS = 0;
            int totalWithCard = 0;
            int totalWithCash = 0;
            double totalSum = 0;
            while (input != "End")
            {
                count++;
                paymentType = int.Parse(input);

                if(count % 2 == 0)
                {
                    if(paymentType < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        totalWithCard++;
                        totalWithCC += paymentType;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    if (paymentType > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        totalWithCash++;
                        totalWithCS += paymentType;
                        Console.WriteLine("Product sold!");
                    }
                }
                totalSum = totalWithCS + totalWithCC;
                if(totalSum >= sum)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            double averageCC = (double)totalWithCC / totalWithCard;
            double averageCS = (double)totalWithCS / totalWithCash;
            if(totalSum >= sum)
            {
                Console.WriteLine($"Average CS: {averageCS:F2}");
                Console.WriteLine($"Average CC: {averageCC:F2}");
            }
            else
            {
                Console.WriteLine($"Failed to collect required money for charity.");
            }
        }

    }
}

