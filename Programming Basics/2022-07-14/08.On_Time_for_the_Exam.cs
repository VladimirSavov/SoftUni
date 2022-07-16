using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първият ред съдържа час на изпита – цяло число от 0 до 23.
            //•	Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            //•	Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            //•	Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());

            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            examMin = examMin + examHour * 60;
            arrivalMin = arrivalMin + arrivalHour * 60;

            int difference = examMin - arrivalMin;

            if(difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");
                if(difference != 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else if(difference > 30)
            {
                Console.WriteLine("Early");
                if(difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    int diffHours = difference / 60;
                    int diffMin = difference % 60;
                    Console.WriteLine($"{diffHours}:{diffMin:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");
                difference = Math.Abs(difference);

                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    int diffHours = difference / 60;
                    int diffMin = difference % 60;
                    Console.WriteLine($"{diffHours}:{diffMin:d2} hours after the start");
                }
            }
        }
    }
}

