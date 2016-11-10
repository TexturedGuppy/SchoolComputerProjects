using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IST303_Asbury_C_A5
{
    class Hangman
    {
        private static Random r = new Random();
        //private string[] words = {"default", "cameron", "ist", "programming"};
        private string[] words = File.ReadAllLines("words.txt");
        private string selectedWord;
        private int count;
        private int letterCount;
        private int underScoreCount;
        StringBuilder selectedWordDisplayed; 

        public int Count
        {
            get { return count; }
        }

        public Hangman()
        {
            count = 0;
            letterCount = 0;
            underScoreCount = 0;
            selectedWord = words[r.Next(0, words.Length)].ToUpper();
            selectedWordDisplayed = new StringBuilder(selectedWord.Length);

            foreach (char c in selectedWord)
            {
                if(c == ' ')
                {
                    selectedWordDisplayed.Append(' ');

                }
                else
                {
                    selectedWordDisplayed.Append('_');


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

                


        public bool isWin()
        {
            if (letterCount >= underScoreCount)
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

        public string Win()
        {
            return "YOU WIN!";
        }
            
             
        public string Lose()
        {
            return "YOU LOSE!";
        }




        public void turn(char letter)
        {
            if (selectedWord.IndexOf(letter) == -1)
            {
                count++;

                //IsDead();
            }
            else
            {
                Compare(letter);
            }
        }

        public bool IsDead()
        {
            if (count < 6)
            {
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
                    letterCount++;
                    selectedWordDisplayed[i] = letter;

                }
                
            }

           
        }
    }
}

