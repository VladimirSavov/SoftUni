using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = int.Parse(Console.ReadLine());
            double availableMoney = int.Parse(Console.ReadLine());
            string saveOrSpend = "";
            double sum = 0.0;
            int daysCount = 0;
            int spendCount = 0;

            while(neededMoney > availableMoney)
            {
                saveOrSpend = Console.ReadLine();
                sum = double.Parse(Console.ReadLine());
                daysCount++;

                if(saveOrSpend == "save")
                {
                    availableMoney += sum;
                    spendCount = 0;
                }
                else
                {
                    spendCount++;
                    if(spendCount == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(daysCount);
                        break;
                    }
                    availableMoney -= sum;
                    if(availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
            }
            if(availableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
            
        }
          
    }
}

