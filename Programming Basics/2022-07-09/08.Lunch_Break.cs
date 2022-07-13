using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfSeries = Console.ReadLine();
            int durationOfAnEpisode = int.Parse(Console.ReadLine());
            int durationOfTheBreak = int.Parse(Console.ReadLine());

            double timeForLunch = durationOfTheBreak * 0.125;
            double timeForRelax = durationOfTheBreak * 0.25;
            double remainingTime = durationOfTheBreak - timeForLunch - timeForRelax;

            if(remainingTime >= durationOfAnEpisode)
            {
                double timeLeft = Math.Ceiling(remainingTime - durationOfAnEpisode);
                Console.WriteLine($"You have enough time to watch {nameOfSeries} and left with {timeLeft} minutes free time.");
            }
            else
            {
                double neccesaryTime = Math.Ceiling(durationOfAnEpisode - remainingTime); 
                Console.WriteLine($"You don't have enough time to watch {nameOfSeries}, you need {neccesaryTime} more minutes.");
            }
        }
    }
}
