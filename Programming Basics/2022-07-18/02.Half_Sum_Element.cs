using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int min = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if(num > min)
                {
                    min = num;
                }
            }
            int newSum = sum - min; 
            if (min == newSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {min}");
            }
            else if(newSum > min)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {newSum - min}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {min - newSum}");
            }
        }
    }
}

