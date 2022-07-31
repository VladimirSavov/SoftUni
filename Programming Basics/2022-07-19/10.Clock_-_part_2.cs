using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int k = 0; k < 60; k++)
                {
                    for (int j = 0; j < 60; j++)
                    {
                        Console.WriteLine($"{i} : {k} : {j} ");
                    }
                }
            }
        }
    }
}
