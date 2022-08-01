using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = int.Parse(Console.ReadLine());
            int points = 0;

            int otherColorsPicked = 0;
            int dividesFromBlackBalls = 0;
            int redBalls = 0;
            int orangeBalls = 0;
            int yellowBalls = 0;
            int whiteBalls = 0;

            for (int i = 1; i <= numberOfBalls; i++)
            {
                string color = Console.ReadLine();

                if(color == "red")
                {
                    redBalls++;
                    points += 5;
                }
                else if (color == "orange")
                {
                    orangeBalls++;
                    points += 10;
                }
                else if (color == "yellow")
                {
                    yellowBalls++; 
                    points += 15;
                }
                else if (color == "white")
                {
                    whiteBalls++;   
                    points += 20;
                }
                else if (color == "black")
                {
                    dividesFromBlackBalls++;
                    points /= 2;
                }
                else
                {
                    otherColorsPicked++;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redBalls}");
            Console.WriteLine($"Orange balls: {orangeBalls}");
            Console.WriteLine($"Yellow balls: {yellowBalls}");
            Console.WriteLine($"White balls: {whiteBalls}");
            Console.WriteLine($"Other colors picked: {otherColorsPicked}");
            Console.WriteLine($"Divides from black balls: {dividesFromBlackBalls}");
        }
    }
}
