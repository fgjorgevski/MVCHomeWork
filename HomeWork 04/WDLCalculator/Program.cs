using System;

namespace WDLCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int checkedWins;
            int checkedDraws;
            int checkedLosses;



            Console.Write("Please enter wins: ");
            bool winsInput = int.TryParse(Console.ReadLine(), out checkedWins);
            Console.Write("Enter draws: ");
            bool drawsInput = int.TryParse(Console.ReadLine(), out checkedDraws);
            Console.Write("Enter losses: ");
            bool lossesInput = int.TryParse(Console.ReadLine(), out checkedLosses);

            int WDLcalculatorMethod = WDLcalculator(checkedWins, checkedDraws, checkedLosses);

            if (winsInput && drawsInput && lossesInput)
            {
                string methodString = $"You have {WDLcalculatorMethod} points";
                Console.WriteLine(methodString);
            }
            else
            {
                Console.WriteLine("Please enter number of wins, draws and losses");
            }

            
        }

        static public int WDLcalculator(int wins, int draws, int losses )
        {
            return wins * 3 + draws * 1 + losses * 0;

        }
    }
}
