using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double p1v = h * p1;
            double p2v = h * p2;
            double totalP = p1v + p2v;
            double percentagefill = (totalP / (v / 100));
            double p1vPercentage = p1v / (totalP / 100);
            double p2vPercentage = p2v / (totalP / 100);
            if(percentagefill <= 100)
            {
                Console.WriteLine($"The pool is {percentagefill}% full." +
                    $" Pipe 1: {p1vPercentage:f2}%. Pipe 2: {p2vPercentage:f2}%.");
            }
            else
            {
                    Console.WriteLine($"For {h} hours " +
                    $"the pool overflows with {totalP - v} liters.");
            }
        }
    }
}
