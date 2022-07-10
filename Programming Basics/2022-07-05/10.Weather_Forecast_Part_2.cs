using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {      
             double degrees = double.Parse(Console.ReadLine());
            if(degrees >= 26) {
                Console.WriteLine("Hot");
            } else if (degrees >= 20.1){
                Console.WriteLine("Warm");
            } else if (degrees >= 15)
            {
                Console.WriteLine("Mild");
            } else if (degrees >= 12)
            {
                Console.WriteLine("Cool");
            } else if (degrees >= 5)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
            
            
                
            
        }
    } 
}
