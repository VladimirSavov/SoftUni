using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            int Num = int.Parse(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
