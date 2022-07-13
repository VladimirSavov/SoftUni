using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Типа на горивото – текст с възможности: "Gas", "Gasoline" или "Diesel"
            //•	Количество гориво – реално число в интервала[1.00 … 50.00]
            //•	Притежание на клубна карта – текст с възможности: "Yes" или "No"
            string typeOfFuel = Console.ReadLine();
            double amountOfFuel = double.Parse(Console.ReadLine());
            string clubCart = Console.ReadLine();

            if (typeOfFuel == "Gasoline")
            {
                if (clubCart == "Yes")
                {
                    double finalPrice = (amountOfFuel * 2.22) - (amountOfFuel * 0.18);

                    if (amountOfFuel >= 20 && amountOfFuel <= 25)
                    {
                        double finalPriceWithDiscount = finalPrice - (finalPrice * 0.08);
                        Console.WriteLine($"{finalPriceWithDiscount:F2} lv.");
                    }
                    else if (amountOfFuel >= 25)
                    {
                        double finalPriceWithDiscount = finalPrice - (finalPrice * 0.1);
                        Console.WriteLine($"{finalPriceWithDiscount:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                }
                if(clubCart == "No")
                {
                    double finalPrice = amountOfFuel * 2.22;

                    if (amountOfFuel >= 20 && amountOfFuel <= 25)
                    {
                        double finalPriceWithDiscount = finalPrice - (finalPrice * 0.08);
                        Console.WriteLine($"{finalPriceWithDiscount:F2} lv.");
                    }
                    else if (amountOfFuel >= 25)
                    {
                        double finalPriceWithDiscount = finalPrice - (finalPrice * 0.1);
                        Console.WriteLine($"{finalPriceWithDiscount:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                }

            }
            else if (typeOfFuel == "Gas")
            {
                if (clubCart == "Yes")
                {
                    double finalPrice = (amountOfFuel * 0.93) - (amountOfFuel * 0.08);

                    if (amountOfFuel >= 20 && amountOfFuel <= 25)
                    {
                        double finalPriceWithDiscount = finalPrice - (finalPrice * 0.08);
                        Console.WriteLine($"{finalPriceWithDiscount:F2} lv.");
                    }
                    if (amountOfFuel >= 25)
                    {
                        double finalPriceWithDiscount = finalPrice - (finalPrice * 0.1);
                        Console.WriteLine($"{finalPriceWithDiscount:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                }
                if (clubCart == "No")
                {
                    double finalPrice = amountOfFuel * 0.93;

                    if (amountOfFuel >= 20 && amountOfFuel <= 25)
                    {
                        double finalPriceWithDiscount = finalPrice - (finalPrice * 0.08);
                        Console.WriteLine($"{finalPriceWithDiscount:F2} lv.");
                    }
                    else if (amountOfFuel >= 25)
                    {
                        double finalPriceWithDiscount = finalPrice - (finalPrice * 0.1);
                        Console.WriteLine($"{finalPriceWithDiscount:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                }
            }
            else if (typeOfFuel == "Diesel")
            {
                if (clubCart == "Yes")
                {
                    double finalPrice = (amountOfFuel * 2.33) - (amountOfFuel * 0.12);

                    if (amountOfFuel >= 20 && amountOfFuel <= 25)
                    {
                        double finalPriceWithDiscount = finalPrice - (finalPrice * 0.08);
                        Console.WriteLine($"{finalPriceWithDiscount:F2} lv.");
                    }
                    else if (amountOfFuel >= 25)
                    {
                        double finalPriceWithDiscount = finalPrice - (finalPrice * 0.1);
                        Console.WriteLine($"{finalPriceWithDiscount:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                }
                if (clubCart == "No")
                {
                    double finalPrice = amountOfFuel * 2.33;

                    if (amountOfFuel >= 20 && amountOfFuel <= 25)
                    {
                        double finalPriceWithDiscount = finalPrice - (finalPrice * 0.08);
                        Console.WriteLine($"{finalPriceWithDiscount:F2} lv.");
                    }
                    else if (amountOfFuel >= 25)
                    {
                        double finalPriceWithDiscount = finalPrice - (finalPrice * 0.1);
                        Console.WriteLine($"{finalPriceWithDiscount:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                }
            }
        }
    }
}
