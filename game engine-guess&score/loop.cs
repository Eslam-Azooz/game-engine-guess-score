using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace game_engine_guess_score
{
    public  class loop
    {
      
        public static void whileloop(int trynumber,int score)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 6);

            while (trynumber != 0)
            {
                int number;
                Console.WriteLine($"enter number between 1 and 5  ");

                number = int.Parse(Console.ReadLine());

                if (number != num)
                {
                    score -= 30;
                }
                trynumber--;
            }
            if (score >= 0)
            {
                Console.WriteLine($"you win with score {score}");
            }
            else
            {
                Console.WriteLine($"you lose with score {0}");
            }
        }

    }
}
