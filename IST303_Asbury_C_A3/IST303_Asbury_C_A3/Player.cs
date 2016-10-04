using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A3
{
    class Player
    {
        private string sName;
        private int iWins; 
        private int iLosses;
        static Random rand = new Random();

        //Enum to track moves of player
        enum Actions
        {
            eRock,
            ePaper,
            eScissors
        };

        //Enum to track wins, loses, and draws
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
                return sName;
            }
            set
            {
                sName = value;
            }
        
        }

        public int Wins
        {
            get
            {
                return iWins;
            }
            set
            {
                iWins = value;
            }
        }
        public int Losses
        {
            get
            {
                return iLosses;
            }
            set
            {
                iLosses = value;
            }
        }

        //Player Constructor, sets wins and losses to 0 and sets the player's name.
        public Player(string name)
        {
            sName = name;
            Wins = 0;
            Losses = 0;
        }

        public void Players(params string[] playerNames)
        {
            List<string> playerList = new List<string>();
            foreach (string name in playerNames)
            {
                playerList.Add(name);
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }

        public void Play(Player opponent)
        {
            Actions player1 = (Actions)rand.Next(0,3);
            Actions player2 = (Actions)rand.Next(0, 3);

        }
    }
}
