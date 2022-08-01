using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumberOfWindows = int.Parse(Console.ReadLine());
            string TypeOfWindow = Console.ReadLine();
            string ShipmentMethod = Console.ReadLine();
            double price = 0.0;
            double priceWithDiscount = 0.0;
            if(NumberOfWindows < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            if(TypeOfWindow == "90X130")
            {
                price = 110 * NumberOfWindows;
                if(NumberOfWindows > 30 && NumberOfWindows <= 60)
                {
                    priceWithDiscount = price - (price * 0.05);
                }
                else if (NumberOfWindows > 60)
                {
                    priceWithDiscount = price - (price * 0.08);
                }
            }
            else if(TypeOfWindow == "100X150")
            {
                price = 140 * NumberOfWindows;
                if (NumberOfWindows > 40 && NumberOfWindows <= 80)
                {
                    priceWithDiscount = price - (price * 0.06);
                }
                else if (NumberOfWindows > 80)
                {
                    priceWithDiscount = price - (price * 0.1);
                }
            }
            else if (TypeOfWindow == "130X180")
            {
                price = 190 * NumberOfWindows;
                if (NumberOfWindows > 20 && NumberOfWindows <= 50)
                {
                    priceWithDiscount = price - (price * 0.07);
                }
                else if (NumberOfWindows > 50)
                {
                    priceWithDiscount = price - (price * 0.12);
                }
            }
            else if (TypeOfWindow == "200X300")
            {
                price = 250 * NumberOfWindows;
                if (NumberOfWindows > 25 && NumberOfWindows <= 50)
                {
                    priceWithDiscount = price - (price * 0.09);
                }
                else if (NumberOfWindows > 50)
                {
                    priceWithDiscount = price - (price * 0.14);
                }
            }
            if(ShipmentMethod == "With delivery")
            {
                priceWithDiscount += 60;
            }
            if(NumberOfWindows > 99)
            {
                priceWithDiscount = priceWithDiscount - (priceWithDiscount * 0.04);
            }
            Console.WriteLine($"{priceWithDiscount:F2} BGN");
        }
    }
}
