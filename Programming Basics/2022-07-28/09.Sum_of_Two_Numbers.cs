using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            for (int i = num1; i <= num2; i++)
            {
                for (int k = num1; k <= num2; k++)
                {
                    sum = i + k;
                    counter++;
                    if(sum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {k} = {magicNum})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}
