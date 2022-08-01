using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine()); //2345
            int end = int.Parse(Console.ReadLine()); //6789
            int fourStart = start % 10; //5
            int startNum = start / 10; //234 
            int threeStart = start % 10; //4
            startNum = startNum / 10; //23
            int twoStart = start % 10; //3 
            startNum = startNum / 10;  //2
            
            int fourEnd = end % 10;
            int endNum = end / 10;
            int threeEnd = end % 10;
            endNum = endNum / 10;
            int twoEnd = endNum % 10;
            endNum = endNum / 10;

            for (int i = startNum; i <= endNum; i++)
            {
                for (int k = twoStart; k <= twoEnd; k++)
                {

                    for (int j = threeStart; j <= threeEnd; j++)
                    {

                        for (int l = fourStart; l <= fourEnd; l++)
                        {
                            if (i % 2 != 0 && k % 2 != 0 && j % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{k}{j}{l} ");
                            }


                        }

                    }

                }
                
               
            }
        }
        
    }
}

