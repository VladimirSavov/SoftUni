using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            double depositSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double finalSum = depositSum + months * ((depositSum * percent / 100) / 12);

            Console.WriteLine(finalSum);
        }
    } 
}
