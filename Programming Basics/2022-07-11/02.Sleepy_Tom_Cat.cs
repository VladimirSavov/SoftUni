using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theNumberOfDaysOff = int.Parse(Console.ReadLine());

            int workingDays = 365 - theNumberOfDaysOff;
            int timeToPlay = (workingDays * 63) + (theNumberOfDaysOff * 127);
            
            if(timeToPlay > 30000)
            {
                double difference = timeToPlay - 30000;

                double hours = Math.Floor(difference / 60);
                double minutes = difference % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                double difference = 30000 - timeToPlay;

                double hours = Math.Floor(difference / 60);
                double minute = difference % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minute} minutes less for play");
            }
        }
    }
}
