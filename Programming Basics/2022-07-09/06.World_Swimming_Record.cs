using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double theDistanceInMeters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double distanceToSwimInSecond = timeForOneMeter * theDistanceInMeters;
            double waterResistance = Math.Floor(theDistanceInMeters / 15);
                double addedTime = waterResistance * 12.5;
            double finalTimeForSwim = addedTime + distanceToSwimInSecond;
            if(finalTimeForSwim < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTimeForSwim:F2} seconds.");
            }
            if(finalTimeForSwim > worldRecord)
            {
                double needenSeconds = finalTimeForSwim - worldRecord;
                Console.WriteLine($"No, he failed! He was {needenSeconds:F2} seconds slower.");
            }
        }
    }
}
