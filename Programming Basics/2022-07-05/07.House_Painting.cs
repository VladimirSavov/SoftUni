using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {      
              double x = double.Parse(Console.ReadLine());      
              double y = double.Parse(Console.ReadLine());      
              double h = double.Parse(Console.ReadLine());
           
            double xx = (2 * (x * x)) -  (1.2 * 2) ;
            double xy = (2 * (x * y)) - (2 * (1.5 * 1.5));
            double pokriv = (x * h / 2) * 2;
            double pokrivxy = (x * y) * 2;
            double green = (xx + xy) / 3.4;
            double red = (pokriv + pokrivxy) / 4.3;
            
            Console.WriteLine("litres green paint: " + "{0:F2}", green);
            Console.WriteLine("litres red paint: " + "{0:F2}", red);
        }
    } 
}
