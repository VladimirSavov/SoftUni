using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            if(number % j == 0 && number % l == 0 && number % k == 0 && number % i == 0)
                            {
                                Console.Write($"{i}{k}{l}{j} ");
                            }
                        }
                    }
                }
            }
            
        }

    }
}

