using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int numberOfGroups = int.Parse(Console.ReadLine());
          int numberOfPeoples = 0;

            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;
            double SumPeople = 0.0;
            for (int i = 1; i <= numberOfGroups; i++)
            {
                numberOfPeoples = int.Parse(Console.ReadLine());
                SumPeople += numberOfPeoples; 
                if(numberOfPeoples <= 5)
                {
                    p1 += numberOfPeoples;
                }
                else if(numberOfPeoples <= 12)
                {
                    p2 += numberOfPeoples;
                }
                else if (numberOfPeoples <= 25)
                {
                    p3 += numberOfPeoples;
                }
                else if (numberOfPeoples <= 40)
                {
                    p4 += numberOfPeoples;
                }
                else if (numberOfPeoples >= 41)
                {
                    p5 += numberOfPeoples;
                }

            }
            p1 = p1 / SumPeople * 100;
            p2 = p2 / SumPeople * 100;
            p3 = p3 / SumPeople * 100;
            p4 = p4 / SumPeople * 100;
            p5 = p5 / SumPeople * 100;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}

