using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_engine_guess_score
{
  public  class replay
    {
        public static round r = new round();
        public static void replay1(ref int roundnumber)
        {
            Console.WriteLine($"do you want to play again? (y/n) ");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'y')
            {
                roundnumber++;
                r.roundstart();
            }
            else
            {
                Console.WriteLine($"thank you for playing!");

            }



        }
    }
}
