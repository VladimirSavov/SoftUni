using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            double numInCm = double.Parse(Console.ReadLine());
            double numInDc = 2.54;
             double sum = numInCm * numInDc;
            Console.WriteLine(sum);
        }
    } 
}
