using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Градусите - цяло число в интервала[10…42]
            //•	Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"
            int degreees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string Outfit = "";
            string Shoes = "";

            if(degreees >= 10 && degreees <= 18)
            {
                switch (timeOfDay)
                {
                    case "Morning":
                         Outfit = "Sweatshirt";
                        Shoes = "Sneakers";
                        break;
                    case "Afternoon":
                    case "Evening":
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        break;
                }
            }
            else if (degreees >= 18 && degreees <= 24)
            {
                switch (timeOfDay)
                {
                    case "Morning":
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
                        break;
                    case "Evening":
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        break;
                }
            }
            else if (degreees >= 25)
            {
                switch (timeOfDay)
                {
                    case "Morning":
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
                        break;
                    case "Afternoon":
                        Outfit = "Swim Suit";
                        Shoes = "Barefoot";
                        break;
                    case "Evening":
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        break;
                }
            }
            Console.WriteLine($"It's {degreees} degrees, get your {Outfit} and {Shoes}.");

        }
    }
}

