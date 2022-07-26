using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int validCombinations = 0;
            for (int i = 0; i <= number; i++)
            {
                for (int j = 0; j <= number; j++)
                {
                    for (int k = 0; k <= number; k++)
                    {
                        sum = i + j + k;   
                        if(sum == number)
                        {
                            validCombinations++;    
                        }
                    }
                }
            }
            Console.WriteLine(validCombinations);
        }

    }
}

