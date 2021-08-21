using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());
            int totalFoodInGrams = totalFood * 1000;
            int totalFoodEaten = 0;
            string dailyFoodEaten = Console.ReadLine();
            while (dailyFoodEaten != "Adopted")
            {
                int dailyFood = int.Parse(dailyFoodEaten);
                totalFoodEaten += dailyFood;
                dailyFoodEaten = Console.ReadLine();
            }
            int foodLeft_Missed = Math.Abs(totalFoodInGrams - totalFoodEaten);

            if (totalFoodInGrams < totalFoodEaten)
            {
                Console.WriteLine($"Food is not enough. You need {foodLeft_Missed} grams more.");
            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodLeft_Missed} grams.");
            }
        }
    }
}
