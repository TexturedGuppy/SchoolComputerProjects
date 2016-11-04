using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A5
{
    class Hangman
    {
        private static Random r = new Random();
        private static string[] words = {"default", "cameron", "ist", "programming"};
        private static string selectedWord = words[r.Next(0,words.Length)];
        private static int count = 0;


        public void turn(char letter)
        {

        }

        private bool IsDead()
        {
            if (count < 10)
            {
                count++;
                return false;
            }
            else
                return true;
        }
    }
}

