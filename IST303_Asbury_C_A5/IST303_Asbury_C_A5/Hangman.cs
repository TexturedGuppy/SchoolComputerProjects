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
        //Variable Declarations
        private static Random r = new Random();
        //private string[] words = {"default", "cameron", "ist", "programming"};
        private string[] words = File.ReadAllLines("words.txt");
        private string selectedWord;
        private int count;
        private int letterCount;
        private int underScoreCount;
        StringBuilder selectedWordDisplayed; 

        //Property for count that only allows getting the value.
        public int Count
        {
            get { return count; }
        }

        //Constructor for the Hangman Class
        public Hangman()
        {
            count = 0;
            letterCount = 0;
            underScoreCount = 0;
            selectedWord = words[r.Next(0, words.Length)].ToUpper();
            selectedWordDisplayed = new StringBuilder(selectedWord.Length);//Use string builder to build our hidden word all the way from underscores to the full word when player wins.

            //foreach loop handles phrases or words for hangman. (no underscores appended to string builder when there is a space between words in a phrase.
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

            //foreach loop to count the amount of underscores which is later used to check for winning.
            foreach (char c in selectedWordDisplayed.ToString())
            {
                if(c.ToString() == "_")
                {
                    underScoreCount++;
                }

            }
        }

                

        //Checks if player has won yet
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

        //Function used to display Text in the form
        public string GetWordText()
        {
            
            return selectedWordDisplayed.ToString();
            
        }

        //just returns a "you win" string.
        public string Win()
        {
            return "YOU WIN!";
        }
            
        //Just returns a "you lost" string
        public string Lose()
        {
            return "YOU LOSE!";
        }



        //Function called when a player takes a turn, increments count each turn if the letter isn't found
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

        //Checks if count is less than 6, if less then they are still alive, if not they have been hung.
        public bool IsDead()
        {
            if (count < 6)
            {
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Actually compares all the letters in the word to the letter the player has guessed
        /// </summary>
        /// <param name="letter"></param>
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

