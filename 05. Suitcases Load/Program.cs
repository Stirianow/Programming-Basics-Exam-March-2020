using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkCapacity = double.Parse(Console.ReadLine());
            string suitcaseVolume = Console.ReadLine();
            int counter = 0;
            bool isFull = false;
            while (suitcaseVolume != "End")
            {
                double currentSuitcaseVolume = double.Parse(suitcaseVolume);
                counter++;
                if (counter % 3 == 0)
                {
                    currentSuitcaseVolume += currentSuitcaseVolume * 0.1;
                }
                trunkCapacity -= currentSuitcaseVolume;
                if (trunkCapacity <= 0)
                {
                    isFull = true;
                    counter--;
                    break;
                }
                suitcaseVolume = Console.ReadLine();
            }
            if (isFull)
            {
                Console.WriteLine("No more space!");
            }
            else
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
