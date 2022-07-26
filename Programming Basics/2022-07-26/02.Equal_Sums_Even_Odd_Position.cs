using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int num = start; num <= end; num++)
            {
                int currNum = num;
                int evenNum = 0;
                int oddNum = 0;
                int count = 0;
                while (currNum != 0)
                {
                    int digit = currNum % 10;
                    if(count % 2 == 0)
                    {
                        evenNum += digit;
                    }
                    else
                    {
                        oddNum += digit;
                    }
                    currNum /= 10;  
                    count++;
                }
                if(evenNum == oddNum)
                {
                    Console.Write($"{num} ");
                }
            }
            
        }

    }
}

