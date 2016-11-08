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
        private string[] words = {"default", "cameron", "ist", "programming"};
        private string selectedWord;
        private int count;
        private int letterCount;
        private int underScoreCount;
        StringBuilder selectedWordDisplayed; 

        public Hangman()
        {
            count = 0;
            letterCount = 0;
            underScoreCount = 0;
            selectedWord = words[r.Next(0, words.Length)].ToUpper();
            selectedWordDisplayed = new StringBuilder(selectedWord.Length);

            foreach (char c in selectedWord)
            {
                if(c.ToString() == " ")
                {
                    selectedWordDisplayed.Append(' ');

                }
                else
                {
                    selectedWordDisplayed.Append('_');


                    letterCount++;
                }
            }

            foreach (char c in selectedWordDisplayed.ToString())
            {
                if(c.ToString() == "_")
                {
                    underScoreCount++;
                }

            }
        }

                


        private bool isWin()
        {
            if (letterCount == selectedWord.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if(letter == selectedWord[i])
                {
                    
                    selectedWordDisplayed[i] = letter;

                }
                
            }

            //foreach (char c in selectedWord)
            //{
            //    if (c == letter)
            //    {
            //        int i = c.Current;
            //    }
            //}
        }
    }
}

