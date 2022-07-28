using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char passLetter = char.Parse(Console.ReadLine());
            int counter = 0;
            for (char i = startLetter; i <= endLetter; i++)
            {
                if(i == passLetter)
                {
                    continue;
                }
                for (char k = startLetter; k <= endLetter; k++)
                {
                    if(k == passLetter)
                    {
                        continue;
                    }
                    for (char l = startLetter; l <= endLetter; l++)
                    {
                        if(l == passLetter)
                        {
                            continue;
                        }
                        counter++;
                        Console.Write($"{i}{k}{l} ");
                    }
                }
            }
            Console.WriteLine(counter);
        }

    }
}
