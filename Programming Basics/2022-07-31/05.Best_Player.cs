using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfPlayer = Console.ReadLine();
            int numberOfGoalsScored = 0;
            int goals = int.MinValue;
            string nameOfBestPlayer = "";

            while(nameOfPlayer != "END")
            {
                numberOfGoalsScored = int.Parse(Console.ReadLine());
                if (numberOfGoalsScored > goals)
                {
                    goals = numberOfGoalsScored;
                    nameOfBestPlayer = nameOfPlayer;
                }
                if(goals >= 10)
                {
                    break;
                }
                nameOfPlayer = Console.ReadLine();
            }
            Console.WriteLine($"{nameOfBestPlayer} is the best player!");
            if(goals >= 3)
            {
                Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goals} goals.");
            }
        }
    }
}
