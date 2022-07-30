using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMonth = int.Parse(Console.ReadLine());
            double electricity = 0;
            double water = 20;
            double internet = 15;
            double other = 0;
            double electricityForAllMonth = 0;
            double waterForAllMonth = 20;
            double internetForAllMonth = 15;
            double otherForAllMonth = 0;
            for (int i = 1; i <= numberOfMonth; i++)
            {
                electricity = double.Parse(Console.ReadLine());
                electricityForAllMonth += electricity;
                waterForAllMonth = 20 * numberOfMonth;
                internetForAllMonth = 15 * numberOfMonth;
                other = (electricity + water + internet) + ((electricity + water + internet) * 0.2);
                otherForAllMonth += other;
            }
            double average = (electricityForAllMonth + waterForAllMonth + internetForAllMonth + otherForAllMonth) / numberOfMonth;
            Console.WriteLine($"Electricity: {electricityForAllMonth:F2} lv");
            Console.WriteLine($"Water: {waterForAllMonth:F2} lv");
            Console.WriteLine($"Internet: {internetForAllMonth:F2} lv");
            Console.WriteLine($"Other: {otherForAllMonth:F2} lv");
            Console.WriteLine($"Average: {average:F2} lv");
        }
    }
}
