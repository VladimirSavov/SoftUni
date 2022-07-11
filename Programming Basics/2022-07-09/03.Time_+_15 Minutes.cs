using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            if (minutes >= 60)
            {
                minutes -= 60;
                hours += 1;
            }
            if (hours >= 24)
            {
                hours = 0;
            }
            if(minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            if(minutes >= 10)
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
             
        }
    }
}
