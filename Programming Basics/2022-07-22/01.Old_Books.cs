using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfBook = Console.ReadLine();
            int checkedBooks = 0;
            string book = Console.ReadLine();

            while(book != "No More Books")
            {
                if(book == nameOfBook)
                {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    break;
                }
                checkedBooks++;
                book = Console.ReadLine();
            }
            if (book == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
            

        }
          
    }
}
