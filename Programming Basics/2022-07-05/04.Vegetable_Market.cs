using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            double pricePerKilogramOfVegetables = double.Parse(Console.ReadLine());
            double pricePerKilogramOfFruits = double.Parse(Console.ReadLine());
            int totalKilogramOfVegetables = int.Parse(Console.ReadLine());
            int totalKilogramOfFruits = int.Parse(Console.ReadLine());

            double priceOfEverything = (pricePerKilogramOfVegetables * totalKilogramOfVegetables) + (pricePerKilogramOfFruits * totalKilogramOfFruits);
          
            Console.WriteLine("{0:F2}", priceOfEverything / 1.94);
        }
    } 
}
