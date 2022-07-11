using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            bool isBiggerNum = Num1 > Num2;
            if (isBiggerNum)
            {
                Console.WriteLine(Num1);
            }
            else
            {
                Console.WriteLine(Num2);
            }
        }
    }
}
