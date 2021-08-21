using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfGroups = int.Parse(Console.ReadLine());
            int musalaClimbers = 0;
            int monblanClimbers = 0;
            int kimandjaroClimbers = 0;
            int k2Climbers = 0;
            int everestClimbers = 0;
            int totalKlimbers = 0;
            for (int i = 1; i <= countOfGroups; i++)
            {
                int countOfKlimbersInGroup = int.Parse(Console.ReadLine());
                if (countOfKlimbersInGroup <= 5)
                {
                    musalaClimbers += countOfKlimbersInGroup;
                }
                else if (countOfKlimbersInGroup > 5 && countOfKlimbersInGroup <= 12)
                {
                    monblanClimbers += countOfKlimbersInGroup;
                }
                else if (countOfKlimbersInGroup > 12 && countOfKlimbersInGroup <= 25)
                {
                    kimandjaroClimbers += countOfKlimbersInGroup;
                }
                else if (countOfKlimbersInGroup > 25 && countOfKlimbersInGroup <= 40)
                {
                    k2Climbers += countOfKlimbersInGroup;
                }
                else if (countOfKlimbersInGroup > 40)
                {
                    everestClimbers += countOfKlimbersInGroup;
                }
                totalKlimbers += countOfKlimbersInGroup;
            }
            double percentageMusala = (double)musalaClimbers / totalKlimbers;
            double percentageMontblan = (double)monblanClimbers / totalKlimbers;
            double percentageKilimandjaro = (double)kimandjaroClimbers / totalKlimbers;
            double percentageK2 = (double)k2Climbers / totalKlimbers;
            double percentageEverest = (double)everestClimbers / totalKlimbers;

            Console.WriteLine($"{percentageMusala * 100:f2}%");
            Console.WriteLine($"{percentageMontblan * 100:f2}%");
            Console.WriteLine($"{percentageKilimandjaro * 100:f2}%");
            Console.WriteLine($"{percentageK2 * 100:f2}%");
            Console.WriteLine($"{percentageEverest * 100:f2}%");
        }
    }
}
