using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            int pageCount = int.Parse(Console.ReadLine());
            int pagePerOneHour = int.Parse(Console.ReadLine()); 
            int daysCount = int.Parse(Console.ReadLine());  
            int totalReadingTime = pageCount / pagePerOneHour;  
            int theRequiredHoursPerDay = totalReadingTime / daysCount;
            Console.WriteLine(theRequiredHoursPerDay);
        }
    } 
}
