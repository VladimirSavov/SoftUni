using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Име на авиокомпанията -текст
            //2.Брой билети за   възрастни – цяло число в диапазона[1…400]
            //3.Брой детски билети – цяло число в диапазона[25…120]
            //4.Нетна цена на билет за възрастен – реално число в диапазона[100.0…1600.0]
            //5.Цената на такса обслужване - реално число в диапазона[10.0…50.0]
            string name = Console.ReadLine();
            int numberOfAdultTickets = int.Parse(Console.ReadLine());
            int numberOfKidTickets = int.Parse(Console.ReadLine());
            double priceForAdultTicket = double.Parse(Console.ReadLine());
            double priceForFee = double.Parse(Console.ReadLine());

            double priceForKidTicket = priceForAdultTicket - (priceForAdultTicket * 0.7);
            double priceForAdultTicketWithFee = priceForAdultTicket + priceForFee;
            double priceForKidTicketWithFee = priceForKidTicket + priceForFee;

            double priceForAllTickets = (numberOfAdultTickets * priceForAdultTicketWithFee) + (numberOfKidTickets * priceForKidTicketWithFee);
            double revenue = priceForAllTickets * 0.2;

            Console.WriteLine($"The profit of your agency from {name} tickets is {revenue:F2} lv.");


        }
    }
}
