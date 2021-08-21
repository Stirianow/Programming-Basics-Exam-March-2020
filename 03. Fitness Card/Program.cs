using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumAvailable = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double priceOfCard = 0;

            switch (sport)
            {
                case "Gym":
                    if (gender == "m")
                    {
                        priceOfCard = 42;
                    }
                    else if (gender == "f")
                    {
                        priceOfCard = 35;
                    }
                    break;
                case "Boxing":
                    if (gender == "m")
                    {
                        priceOfCard = 41;
                    }
                    else if (gender == "f")
                    {
                        priceOfCard = 37;
                    }
                    break;
                case "Yoga":
                    if (gender == "m")
                    {
                        priceOfCard = 45;
                    }
                    else if (gender == "f")
                    {
                        priceOfCard = 42;
                    }
                    break;
                case "Zumba":
                    if (gender == "m")
                    {
                        priceOfCard = 34;
                    }
                    else if (gender == "f")
                    {
                        priceOfCard = 31;
                    }
                    break;
                case "Dances":
                    if (gender == "m")
                    {
                        priceOfCard = 51;
                    }
                    else if (gender == "f")
                    {
                        priceOfCard = 53;
                    }
                    break;
                case "Pilates":
                    if (gender == "m")
                    {
                        priceOfCard = 39;
                    }
                    else if (gender == "f")
                    {
                        priceOfCard = 37;
                    }
                    break;

            }
            if (age <= 19)
            {
                priceOfCard -= priceOfCard * 0.20;
            }
            if (sumAvailable >= priceOfCard)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${priceOfCard - sumAvailable:f2} more.");
            }
        }
    }
}
