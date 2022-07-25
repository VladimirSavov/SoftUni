using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i += 1)
            {
                if(i % 3 == 0)
                Console.WriteLine(i);
            }
        }

    }
}

