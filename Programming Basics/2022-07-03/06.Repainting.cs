using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
        //1.Необходимо количество найлон(в кв.м.) -цяло число в интервала[1... 100]
        //2.Необходимо количество боя(в литри) -цяло число в интервала[1…100]
        //3.Количество разредител(в литри) - цяло число в интервала[1…30]
        //4.Часовете, за които майсторите ще свършат работата -цяло число в интервала[1…9]

            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sumNylon = (nylon + 2) * 1.5;
            double sumPaint = (paint + (paint * 0.1)) * 14.5;
            double sumDiluent = diluent * 5;
            double totalSumtOfMaterials = sumNylon + sumPaint + sumDiluent + 0.4;
            double sumForMaster = (totalSumtOfMaterials * 0.3) * hours;

            Console.WriteLine(totalSumtOfMaterials + sumForMaster);

        }
    } 
}
