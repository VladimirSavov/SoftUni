using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine()); 
            int fourStart = start % 10;
            int startNum = start / 10; 
            int threeStart = startNum % 10; 
            startNum = startNum / 10; 
            int twoStart = startNum % 10;
            startNum = startNum / 10; 
            
            int fourEnd = end % 10;
            int endNum = end / 10;
            int threeEnd = endNum % 10;
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
