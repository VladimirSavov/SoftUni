using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfTheWeek = (Console.ReadLine());

            switch (dayOfTheWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine(12);
                    break;
                case "Wednesday":
                case "Thurstday":
                    Console.WriteLine(14);
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine(16);
                    break;
            }

        }
    }
}

