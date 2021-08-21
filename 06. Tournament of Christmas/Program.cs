using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTournamentDays = int.Parse(Console.ReadLine());
            double moneyRaised = 0;
            int winnigDays = 0;
            for (int i = 0; i < totalTournamentDays; i++)
            {
                string typeOfGame = Console.ReadLine();
                double dailyMoneyRaised = 0;
                int dailyWinsCounter = 0;
                int dailyLosesCounter = 0;
                while (typeOfGame != "Finish")
                {
                    string result = Console.ReadLine();
                    switch (result)
                    {
                        case "win":
                            dailyWinsCounter++;
                            dailyMoneyRaised += 20;
                            break;
                        case "lose":
                            dailyLosesCounter++;
                            break;
                    }
                    typeOfGame = Console.ReadLine();
                }
                if (dailyWinsCounter > dailyLosesCounter)
                {
                    dailyMoneyRaised += dailyMoneyRaised * 0.1;
                    winnigDays++;
                }
                moneyRaised += dailyMoneyRaised;
            }
            if (winnigDays > totalTournamentDays / 2)
            {
                moneyRaised += moneyRaised * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {moneyRaised:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {moneyRaised:f2}");
            }

        }
    }
}
