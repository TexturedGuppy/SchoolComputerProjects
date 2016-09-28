using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A3
{
    class Player
    {
        private string name;
        private int wins, losses;

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
        public Player(string _name)
        {
            name = _name;
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
    }
}
