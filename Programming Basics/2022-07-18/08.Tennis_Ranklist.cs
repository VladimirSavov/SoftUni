using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Брой турнири, в които е участвал – цяло число в интервала[1…20] 
            //•	Начален брой точки в ранглистата - цяло число в интервала[1...4000]
            //За всеки турнир се прочита отделен ред:
            //•	Достигнат етап от турнира – текст – "W", "F" или "SF"

          int numberOfTournaments = int.Parse(Console.ReadLine());
          int startingPoints = int.Parse(Console.ReadLine());

            double totalPoints = 0.0;
           string stageOfTheTournament = string.Empty;
            double percentTournamentsWon = 0;
            for (int i = 1; i <= numberOfTournaments; i++)
            {
                stageOfTheTournament = Console.ReadLine();

                if(stageOfTheTournament == "W")
                {
                    totalPoints = totalPoints + 2000;
                    percentTournamentsWon += 1;
                }
                else if(stageOfTheTournament == "F")
                {
                    totalPoints = totalPoints + 1200;
                }
                else if (stageOfTheTournament == "SF")
                {
                    totalPoints = totalPoints + 720;
                }
            }
            double finalPoints = totalPoints + startingPoints;
            double averagePoints = totalPoints / numberOfTournaments;
            percentTournamentsWon = percentTournamentsWon  / numberOfTournaments * 100;

            //  Отпечатват се три реда в следния формат:

            //•	"Final points: {брой точки след изиграните турнири}"
            Console.WriteLine($"Final points: {finalPoints}");
            //•	"Average points: {средно колко точки печели за турнир}"
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            //•	"{процент спечелени турнири}%"
            Console.WriteLine($"{percentTournamentsWon:F2}%");
        }
    }
}

