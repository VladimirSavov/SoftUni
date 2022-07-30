using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMoves = int.Parse(Console.ReadLine());
            double input = 0;

            double finalResult = 0;
            double from0To9 = 0;
            double from10To19 = 0;
            double from20To29 = 0;
            double from30To39 = 0;
            double from40To50 = 0;
            double invalidNumbers = 0;
            for (int i = 1; i <= numberOfMoves; i++)
            {
                input = int.Parse(Console.ReadLine());
                if(input >= 0 && input <= 9)
                {
                    from0To9++;
                    finalResult += input * 0.2;
                }
                else if (input >= 10 && input <= 19)
                {
                    from10To19++;
                    finalResult += input * 0.3;
                }
                else if (input >= 20 && input <= 29)
                {
                    from20To29++;
                    finalResult += input * 0.4;
                }
                else if (input >= 30 && input <= 39)
                {
                    from30To39++;
                    finalResult += 50;
                }
                else if (input >= 40 && input <= 50)
                {
                    from40To50++;
                    finalResult += 100;
                }
                else if(input >= 50 || input < 0)
                {
                    invalidNumbers++;
                    finalResult /= 2;
                }
            };
            double A1 = from0To9 / numberOfMoves * 100;
            double A2 = from10To19 / numberOfMoves * 100;
            double A3 = from20To29 / numberOfMoves * 100;
            double A4 = from30To39 / numberOfMoves * 100;
            double A5 = from40To50 / numberOfMoves * 100;
            double A6 = invalidNumbers / numberOfMoves * 100;


            Console.WriteLine($"{finalResult:F2}");
            Console.WriteLine($"From 0 to 9: {A1:F2}%");
            Console.WriteLine($"From 10 to 19: {A2:F2}%");
            Console.WriteLine($"From 20 to 29: {A3:F2}%");
            Console.WriteLine($"From 30 to 39: {A4:F2}%");
            Console.WriteLine($"From 40 to 50: {A5:F2}%");
            Console.WriteLine($"Invalid numbers: {A6:F2}%");
        }
    }
}
