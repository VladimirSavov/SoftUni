using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i < 998; i++)
            {
                if(i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

