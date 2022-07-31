using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double input = 0;
            double oddSum = 0;
            double oddMin = 100000000;
            double oddMax = -100000000;
            double evenSum = 0;
            double evenMin = 100000000;
            double evenMax = -100000000;
            for (int i = 1; i <= num; i++)
            {
                input = double.Parse(Console.ReadLine());
                if(i % 2 != 0)
                {
                    oddSum += input;
                    if(input < oddMin)
                    {
                        oddMin = input;
                    }
                    if(input > oddMax)
                    {
                        oddMax = input;
                    }
                }
                else if (i % 2 == 0)
                {
                    evenSum += input;
                    if (input < evenMin)
                    {
                        evenMin = input;
                    }
                    if (input > evenMax)
                    {
                        evenMax = input;
                    }
                }
            }
            if (oddSum != 0)
            {
                Console.WriteLine($"OddSum={oddSum:F2},");
            }
            else if(oddSum == 0)
            {
                Console.WriteLine($"OddSum=0.00,");
            }
            if (oddMin != 100000000)
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
            }
            else if (oddMin == 100000000)
            {
                Console.WriteLine($"OddMin=No,");
            }
            if (oddMax != -100000000)
            {
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            else if (oddMax == -100000000)
            {
                Console.WriteLine($"OddMax=No,");
            }
            if (evenSum != 0)
            {
                Console.WriteLine($"EvenSum={evenSum:F2},");
            }
            else if (evenSum == 0)
            {
                Console.WriteLine($"EvenSum=0.00,");
            }
            if (evenMin != 100000000)
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
            }
            else if (evenMin == 100000000)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            if (evenMax != -100000000)
            {
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
            else if (evenMax == -100000000)
            {
                Console.WriteLine($"EvenMax=No");
            }
        }
    }
}
