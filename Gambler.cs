using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class Gambler
    {
        public static void gamble(int NoOfTimes, int Stake, int Goal)
        {
            int bets = 0;
            int wins = 0;
            Random r = new Random();

            for (int i = 0; i < NoOfTimes; i++)
            {
                int cash = Stake;
                int random = r.Next(0, 10);
                while (cash > 0 && cash < Goal)
                {
                    bets++;
                    if (random < 5)
                        cash++;
                    else
                        cash--;
                }
                if (cash == Goal)
                    wins++;
            }
            Console.WriteLine();
            Console.WriteLine(wins + "Wins out of :" + NoOfTimes);
            Console.WriteLine("Percentage of games won = " + 100 * wins / NoOfTimes);
            Console.WriteLine("Total no of bets : " + NoOfTimes + " Games = " + bets);
        }
    }
}
    

