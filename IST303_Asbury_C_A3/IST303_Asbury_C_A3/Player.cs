using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace IST303_Asbury_C_A3
{
    class Player
    {
        //Private member variables
        private string name;
        private int wins; 
        private int losses;

        //Static random to give reliable results
        static Random rand = new Random();

        //Enum to track moves of player
        enum Actions
        {
            eRock,
            ePaper,
            eScissors
        };

        //Enum to track wins, loses, and draws
        //James recommended to me to use two sets of enums
        enum Results
        {
            eWin,
            eLose,
            eDraw
        };

        
        //Player Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        
        }

        public int Wins
        {
            get
            {
                return wins;
            }
            set
            {
                wins = value;
            }
        }
        public int Losses
        {
            get
            {
                return losses;
            }
            set
            {
                losses = value;
            }
        }

        //Player Constructor, sets wins and losses to 0 and sets the player's name.
        public Player(string name)
        {
            this.name = name;
            Wins = 0;
            Losses = 0;
        }

        
        /// <summary>
        /// Two players play against eachother
        /// Checks to see if they are the same person
        /// Checks for draws, wins, and losses
        /// </summary>
        /// <param name="opponent"></param>
        public void Play(Player opponent)
        {
            Console.WriteLine("{0} is playing against {1}!", name, opponent.Name);
            //Sentinel Value for while loop, becomes false once players actually "play" against eachother
            bool bDraw = true;
            while (bDraw)
            {
                Actions player1 = (Actions)rand.Next(0 , 3);
                Actions player2 = (Actions)rand.Next(0 , 3);

                if (name == opponent.Name)
                {
                    Console.WriteLine("Can't play yourself.");
                    
                }
                Console.WriteLine("Rock, Paper, Scissors...Shoot!");

                if (player1 != player2)
                {

                    //Rock
                    if (player1 == Actions.eRock)
                    {
                        if (player2 == Actions.ePaper)
                        {
                            Console.WriteLine("{0} wins!",opponent.Name);
                            losses++;
                            opponent.Wins++;
                        }
                        if (player2 == Actions.eScissors)
                        {
                            Console.WriteLine("{0} wins!", name);
                            wins++;
                            opponent.Losses++;
                        }

                    }
                    //Paper
                    if (player1 == Actions.ePaper)
                    {
                        if (player2 == Actions.eRock)
                        {
                            Console.WriteLine("{0} wins!", name);
                            wins++;
                            opponent.Losses++;
                        }
                        if (player2 == Actions.eScissors)
                        {

                            Console.WriteLine("{0} wins!",opponent.Name);
                            losses++;
                            opponent.Wins++;
                        }
                    }
                    //Scissors
                    if (player1 == Actions.eScissors)
                    {
                        if (player2 == Actions.ePaper)
                        {
                            Console.WriteLine("{0} wins!", name);
                            wins++;
                            opponent.Losses++;
                        }
                        if (player2 == Actions.eRock)
                        {
                            Console.WriteLine("{0} wins!",opponent.Name);
                            losses++;
                            opponent.Wins++;
                        }
                    }

                    bDraw = false;
                }

                if(player1 == player2)
                {
                    Console.WriteLine("Draw...Play Again!");
                    Thread.Sleep(1000);

                }

            }
            //Sleep forces program to wait specified number of milleseconds
            Thread.Sleep(1000); 
        } 
        //End Play()
                

            
    }
}
