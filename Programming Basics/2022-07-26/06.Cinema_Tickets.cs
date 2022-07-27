using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfMovie = Console.ReadLine();
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            while (nameOfMovie != "Finish")
            {
                int student = 0;
                int standard = 0;
                int kid = 0;
                int freeSpots = int.Parse(Console.ReadLine());
                for (int i = 1; i <= freeSpots; i++)
                {
                    string typeTicket = Console.ReadLine();
                    if(typeTicket == "End")
                    {
                        break;
                    }
                    switch (typeTicket)
                    {
                        case "student":
                            student++;
                            break;
                        case "standard":
                            standard++;
                            break;
                        case "kid":
                            kid++;
                            break;
                    }

                }
                studentTickets += student;
                standardTickets += standard;
                kidTickets += kid;
                double percentageFull = (student + standard + kid) / (double)freeSpots * 100;
                Console.WriteLine($"{nameOfMovie} - {percentageFull:F2}% full.");
                nameOfMovie = Console.ReadLine();
            }
            int totalTickets = studentTickets + standardTickets + kidTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            double studentsPercentage = studentTickets / (double)totalTickets * 100;
            double standardPercentage = standardTickets / (double)totalTickets * 100;
            double kidPercentage = kidTickets / (double)totalTickets * 100;
            Console.WriteLine($"{studentsPercentage:F2}% student tickets.");
            Console.WriteLine($"{standardPercentage:F2}% standard tickets.");
            Console.WriteLine($"{kidPercentage:F2}% kids tickets.");
        }

    }
}

