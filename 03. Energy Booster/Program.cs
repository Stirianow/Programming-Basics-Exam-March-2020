using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfGell = Console.ReadLine();
            string sizeOfGell = Console.ReadLine();
            int countOfGells = int.Parse(Console.ReadLine());

            double priceOfAGell = 0;

            switch (kindOfGell)
            {
                case "Watermelon":
                    if (sizeOfGell == "small")
                    {
                        priceOfAGell = 2 * 56;
                    }
                    else if (sizeOfGell == "big")
                    {
                        priceOfAGell = 5 * 28.70;
                    }
                    break;
                case "Mango":
                    if (sizeOfGell == "small")
                    {
                        priceOfAGell = 2 * 36.66;
                    }
                    else if (sizeOfGell == "big")
                    {
                        priceOfAGell = 5 * 19.60;
                    }
                    break;
                case "Pineapple":
                    if (sizeOfGell == "small")
                    {
                        priceOfAGell = 2 * 42.10;
                    }
                    else if (sizeOfGell == "big")
                    {
                        priceOfAGell = 5 * 24.80;
                    }
                    break;
                case "Raspberry":
                    if (sizeOfGell == "small")
                    {
                        priceOfAGell = 2 * 20;
                    }
                    else if (sizeOfGell == "big")
                    {
                        priceOfAGell = 5 * 15.20;
                    }
                    break;
            }
            double totalPrice = countOfGells * priceOfAGell;

            if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice -= totalPrice * 0.15;
            }
            if (totalPrice > 1000)
            {
                totalPrice -= totalPrice / 2;
            }


            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
