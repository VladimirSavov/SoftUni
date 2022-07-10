using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double trapezium = (b1 + b2) * h / 2;
            Console.WriteLine("{0:f2}",trapezium);  

        }
    } 
}
