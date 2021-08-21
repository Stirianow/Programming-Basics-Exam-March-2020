using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            double foodEatenByDog = 0;
            double foodEatenByCat = 0;
            double totalBiscuits = 0;
            for (int i = 1; i <= days; i++)
            {
                double dailyDogFood = double.Parse(Console.ReadLine());
                foodEatenByDog += dailyDogFood;
                double dailyCatFood = double.Parse(Console.ReadLine());
                foodEatenByCat += dailyCatFood;
                double dailyFood = dailyCatFood + dailyDogFood;
                if (i % 3 == 0)
                {
                    double biscuits = dailyFood * 0.1;
                    double prize = Math.Round(biscuits, 0);
                    totalBiscuits += prize;
                }
            }
            double percentageFoodEaten = (foodEatenByCat + foodEatenByDog) / totalFood * 100;
            double percentageFoodEatenByDog = foodEatenByDog / (foodEatenByCat + foodEatenByDog) * 100;
            double percentageFoodEatenByCat = foodEatenByCat / (foodEatenByCat + foodEatenByDog) * 100;

            Console.WriteLine($"Total eaten biscuits: {totalBiscuits}gr.");
            Console.WriteLine($"{percentageFoodEaten:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentageFoodEatenByDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentageFoodEatenByCat:f2}% eaten from the cat.");
        }
    }
}
