using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double hCm = (h - 1) / 0.7; 
            double wCm = w / 1.2;
            double hhCm = Math.Round(hCm, 0);
            double wwCm = Math.Round(wCm, 0);
            
            Console.WriteLine(wwCm * hhCm - 3);

        }
    } 
}
