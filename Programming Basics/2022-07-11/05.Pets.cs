using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – брой дни – цяло число в интервал[1…5000]
            //•	Втори ред – оставена храна в килограми – цяло число в интервал[0…100000]
            //•	Трети ред – храна на ден за кучето в килограми – реално число в интервал[0.00…100.00]
            //•	Четвърти ред – храна на ден за котката в килограми– реално число в интервал[0.00…100.00]
            //•	Пети ред – храна на ден за костенурката в грамове – реално число в интервал[0.00…10000.00]
            int numberDays = int.Parse(Console.ReadLine());
            int foodInKilograms = int.Parse(Console.ReadLine());
            double foodForDog = double.Parse(Console.ReadLine());
            double foodForCat = double.Parse(Console.ReadLine());
            double foodForTurtle = double.Parse(Console.ReadLine());

            double allFoodConsumation = numberDays * (foodForDog + foodForCat + (foodForTurtle * 0.001));

            if(foodInKilograms >= allFoodConsumation)
            {
                Console.WriteLine($"{Math.Floor(foodInKilograms - allFoodConsumation)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(allFoodConsumation - foodInKilograms)} more kilos of food are needed.");
            }

        }
    }
}
