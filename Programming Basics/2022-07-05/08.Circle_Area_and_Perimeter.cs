using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {      
             double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", Math.PI * (r * r));
            Console.WriteLine("{0:F2}", 2 * (Math.PI * r));
               
        }
    } 
}
