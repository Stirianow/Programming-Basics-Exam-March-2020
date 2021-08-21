using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForAMeter = double.Parse(Console.ReadLine());
            double checkpoints = Math.Floor(distance / 50);

            double extraSeconds = checkpoints * 30;
            double timeNeeded = (distance * timeForAMeter) + extraSeconds;

            if (timeNeeded < record)
            {
                Console.WriteLine($"Yes! The new record is {timeNeeded:f2} seconds."); 
            }
            else
            {
                Console.WriteLine($"No! He was {timeNeeded - record:f2} seconds slower.");
            }
        }
    }
}
