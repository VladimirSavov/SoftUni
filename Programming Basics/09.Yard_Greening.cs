using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            double size = double.Parse(Console.ReadLine());
            double prizeWithoutDiscount = size * 7.61;
            double discount = prizeWithoutDiscount * 0.18;


            Console.WriteLine($"The final price is: {prizeWithoutDiscount - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");

        }
    } 
}
