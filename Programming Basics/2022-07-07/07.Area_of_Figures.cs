using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            string fig = Console.ReadLine();
            if(fig == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", side * side);
            }
            else if(fig == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", (side1 * side2));
            }
            else if(fig == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F3}", Math.PI * (radius * radius));
            }
            else if(fig == "triangle")
            {
                double side3 = double.Parse(Console.ReadLine());
                double side4 = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", (side3 * side4) / 2);
            }
        }
    }
}
