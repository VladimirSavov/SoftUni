using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayOfTheWeek = (Console.ReadLine());

            if (hour >= 10 && hour <= 18)
            {
                switch (dayOfTheWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thurstday":
                    case "Friday":
                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                    case "Sunday":
                        Console.WriteLine("closed");
                        break;
                }
}
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}

