using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            string nameOfTheArchitect = Console.ReadLine();
            int numOfProjects = int.Parse(Console.ReadLine());
            int individualProjectTime = 3;
            int timeForAllProjects = numOfProjects * individualProjectTime;
            Console.WriteLine($"The {nameOfTheArchitect} will need {timeForAllProjects} hours to complete {numOfProjects} project/s.");
        }
    } 
}
