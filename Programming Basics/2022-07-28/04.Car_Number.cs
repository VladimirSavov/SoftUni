using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int i = startNum; i <= endNum; i++)
            {
                for (int k = startNum; k <= endNum; k++)
                {
                    for (int l = startNum; l <= endNum; l++)
                    {
                        for (int j = startNum; j <= endNum; j++)
                        {
                            if (i % 2 == 0 && j % 2 != 0)
                            {
                                if (i > j)
                                {
                                    if ((k + l) % 2 == 0)
                                    {
                                        Console.Write($"{i}{k}{l}{j} ");
                                    }
                                }
                            }
                            else if (j % 2 == 0 && i % 2 != 0)
                            {
                                if (i > j)
                                {
                                    if ((k + l) % 2 == 0)
                                    {
                                        Console.Write($"{i}{k}{l}{j} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
