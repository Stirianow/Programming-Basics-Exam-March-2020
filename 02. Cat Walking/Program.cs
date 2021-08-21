using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalking = int.Parse(Console.ReadLine());
            int numberOfWalks = int.Parse(Console.ReadLine());
            int calloriesTaken = int.Parse(Console.ReadLine());

            int totalCalloriesBurned = minutesWalking * numberOfWalks * 5;

            if (totalCalloriesBurned >= calloriesTaken / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCalloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCalloriesBurned}.");
            }
        }
    }
}
