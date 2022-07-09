using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            int penCount = int.Parse(Console.ReadLine());
            int markCount = int.Parse(Console.ReadLine()); ;
            int washCount = int.Parse(Console.ReadLine()); ;
            int percentDiscount = int.Parse(Console.ReadLine()); 
            double pricepackagePen = penCount * 5.80;
            double pricepackageMark = markCount * 7.20;
            double priceWash = washCount * 1.20;
            double percentDiscountResult = percentDiscount * 0.01 ;
            double allPackagePrice = (pricepackagePen + pricepackageMark + priceWash);
            double PriceWithDiscount = allPackagePrice - (allPackagePrice * percentDiscountResult);


             Console.WriteLine(PriceWithDiscount);
            ;

            
        }
    } 
}
