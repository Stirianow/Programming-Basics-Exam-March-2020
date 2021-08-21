using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double ioan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double leva_bitcoin = bitcoin * 1168;
            double usd_ioan = ioan * 0.15;
            double lv_usd = usd_ioan * 1.76;
            double sumInBgn = lv_usd + leva_bitcoin;
            double sumInEur = sumInBgn / 1.95;
            double final = sumInEur -= (sumInEur * commission / 100);

            Console.WriteLine($"{final:f2}");
        }
    }
}
