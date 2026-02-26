using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace game_engine_guess_score
{
    internal class round
    {
     
        public int trynumber { get; set; }
        public int score = 90;
        public static int roundnumber = 1;
    

        public void roundstart()
        {
            Console.WriteLine($"Round {roundnumber} start!");
            
            Console.WriteLine($"enter number of try  ");
            trynumber= int .Parse(Console.ReadLine());


            whileloop();
        }

        public void whileloop()
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

        public void replay()
        {
            Console.WriteLine($"do you want to play again? (y/n) ");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'y')
            {
                roundnumber++;
                roundstart();
            }
            else
            {
                Console.WriteLine($"thank you for playing!");
                return;
            }



        }










    }
}
