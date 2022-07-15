using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            
            if(operation == "+" || operation == "-" || operation == "*")
            {
                int result;
                string evenOrOdd = "even";
                if(operation == "+")
                {
                    result = number1 + number2;
                }
                else if(operation == "-")
                {
                    result = number1 - number2;
                }
                else
                {
                    result = number1 * number2;
                }
                if(result % 2 != 0)
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{number1} {operation} {number2} = {result} - {evenOrOdd}");
            }
            else if(operation == "/" || operation == "%")
            {
                double result;
                if(number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    if (operation == "/")
                    {
                        result = (double)number1 / number2;
                        Console.WriteLine($"{number1} / {number2} = {result:f2}");
                    }
                    else if (operation == "%")
                    {
                        result = number1 % number2;
                        Console.WriteLine($"{number1} % {number2} = {result}");
                    }
                }
                

            }
        }
    }
}

