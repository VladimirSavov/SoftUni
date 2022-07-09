using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            
            double volume = (lenght * height * width);

            Console.WriteLine((volume * 0.001) * (1 - (percent * 0.01)));

        }
    } 
}
