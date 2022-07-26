using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int FinalNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int count = 0;
            for (int num1 = startNum; num1 <= FinalNum; num1++)
            {
                for (int num2 = startNum; num2 <= FinalNum; num2++)
                {
                    count++;
                    int sum = num1 + num2;
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{count} ({num1} + {num2} = {magicNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNum}");
        }

    }
}
