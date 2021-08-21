using System;

namespace _01._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int pakcsOfPens = int.Parse(Console.ReadLine());
            int pakcsOfMarkers = int.Parse(Console.ReadLine());
            double litresOfCleaner = double.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double sumForPens = pakcsOfPens * 5.80;
            double sumForMarkers = pakcsOfMarkers * 7.20;
            double sumForCleaner = litresOfCleaner * 1.20;

            double totalSum = sumForPens + sumForMarkers + sumForCleaner;

            double total = totalSum -= (totalSum * percentDiscount / 100);

            Console.WriteLine($"{total:f3}");
        }
    }
}
