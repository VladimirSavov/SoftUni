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
                    Console.WriteLine($"{i} : {k}");
                }
            }
        }
    }
}
