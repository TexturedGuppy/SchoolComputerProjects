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
        private static string selectedWord = words[r.Next(0,words.Length)].ToUpper();
        private static int count = 0;
        StringBuilder selectedWordDisplayed = new StringBuilder(selectedWord.Length);
     
        public Hangman()
        {
            for(int i = 0; i<selectedWord.Length; i++)
            {
                selectedWordDisplayed.Append('_');
            }
           //Form1.lblWord.Text = selectedWordDisplayed;
        }

        public string GetWordText()
        {
            return selectedWordDisplayed.ToString();
        }

        public void turn(char letter)
        {
            if (selectedWord.IndexOf(letter) == -1)
            {
                IsDead();
            }
            else
            {
                Compare(letter);
            }
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

        private void Compare(char letter)
        {
            
            foreach (char c in selectedWord)
            {
                if (c == letter)
                {

                }
            }
        }
    }
}

