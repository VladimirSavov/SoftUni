using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
           int litersOfFuel = int.Parse(Console.ReadLine());

            if (typeOfFuel == "Diesel" || typeOfFuel == "Gasoline" || typeOfFuel == "Gas")
            {

                if (litersOfFuel >= 25)
                {
                    string lowercase = typeOfFuel.ToLower();
                    Console.WriteLine($"You have enough {lowercase}.");
                }
                else
                {
                    string lowercase = typeOfFuel.ToLower();
                    Console.WriteLine($"Fill your tank with {lowercase}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }

          
        }
    }
}
