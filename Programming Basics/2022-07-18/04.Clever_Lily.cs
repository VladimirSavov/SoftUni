using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMashine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double money = 0.0;

            for (int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    money += i * 5 - 1;
                }
                else
                {
                    money += toyPrice;
                }
            }
            if(money >= washingMashine)
            {
                Console.WriteLine($"Yes! {money - washingMashine:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMashine - money:F2}");
            }
        }
    }
}

