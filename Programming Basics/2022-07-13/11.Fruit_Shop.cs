using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thurstday" || dayOfWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine("{0:f2}", amount * 2.5);
                        break;
                    case "apple":
                        Console.WriteLine("{0:f2}", amount * 1.2);
                        break;
                    case "orange":
                        Console.WriteLine("{0:f2}", amount * 0.85);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:f2}", amount * 1.45);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:f2}", amount * 2.7);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:f2}", amount * 5.5);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:f2}", amount * 3.85);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine("{0:f2}", amount * 2.7);
                        break;
                    case "apple":
                        Console.WriteLine("{0:f2}", amount * 1.25);
                        break;
                    case "orange":
                        Console.WriteLine("{0:f2}", amount * 0.90);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:f2}", amount * 1.60);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:f2}", amount * 3);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:f2}", amount * 5.6);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:f2}", amount * 4.2);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

