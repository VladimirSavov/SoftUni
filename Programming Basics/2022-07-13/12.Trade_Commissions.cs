using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameTown = Console.ReadLine();
            double salesNumber = double.Parse(Console.ReadLine());

            if(salesNumber >= 0 && salesNumber <= 500)
            {
                switch (nameTown)
                {
                    case "Sofia":
                        Console.WriteLine("{0:F2}", salesNumber * 0.05);
                        break;
                    case "Varna":
                        Console.WriteLine("{0:F2}", salesNumber * 0.045);
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:F2}", salesNumber * 0.055);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (salesNumber > 500 && salesNumber <= 1000)
            {
                switch (nameTown)
                {
                    case "Sofia":
                        Console.WriteLine("{0:F2}", salesNumber * 0.07);
                        break;
                    case "Varna":
                        Console.WriteLine("{0:F2}", salesNumber * 0.075);
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:F2}", salesNumber * 0.08);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (salesNumber > 1000 && salesNumber <= 10000)
            {
                switch (nameTown)
                {
                    case "Sofia":
                        Console.WriteLine("{0:F2}", salesNumber * 0.08);
                        break;
                    case "Varna":
                        Console.WriteLine("{0:F2}", salesNumber * 0.1);
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:F2}", salesNumber * 0.12);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (salesNumber > 10000)
            {
                switch (nameTown)
                {
                    case "Sofia":
                        Console.WriteLine("{0:F2}", salesNumber * 0.12);
                        break;
                    case "Varna":
                        Console.WriteLine("{0:F2}", salesNumber * 0.13);
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:F2}", salesNumber * 0.145);
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

