using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            bool isBiggerGrade = grade >= 5.5;
            if (isBiggerGrade)
            {
                Console.WriteLine("Excellent");
            }
            
        }
    }
}
