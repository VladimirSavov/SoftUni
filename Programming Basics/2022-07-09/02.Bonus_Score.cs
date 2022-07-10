using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            int Num = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (Num <= 100)
            {
                bonus = 5;
            }
            else if (Num > 1000)
            {
                bonus = Num * 0.1;
            }
            else
            {
                bonus = Num * 0.2;
            }
            if (Num % 2 == 0)
            {
                bonus = bonus + 1;
            }
            if (Num % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(Num + bonus);
        }
    }
}
