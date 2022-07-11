using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            double speed = double.Parse(Console.ReadLine());
            //bool slow = speed <= 10;
            //bool average = speed > 10;
            //bool fast = speed > 50;
            //bool ultraFast = speed > 150;
            //bool extremelyFast = speed > 1000;

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
