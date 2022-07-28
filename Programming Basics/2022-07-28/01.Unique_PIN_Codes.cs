using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num1; i++)
            {
                if (i % 2 == 0)
                {
                    for (int k = 1; k <= num2; k++)
                    {
                        if (num2 % k != 0 || num2 == k)
                        {
                            count++;
                            if (count <= 2)
                            {
                                for (int l = 1; l <= num3; l++)
                                {
                                    if (l % 2 == 0)
                                    {
                                        count = 0;
                                        Console.WriteLine($"{i} {k} {l}");
                                    }
                                }
                            }
                        }
                        
                    }
                }
            }
        }

    }
}
