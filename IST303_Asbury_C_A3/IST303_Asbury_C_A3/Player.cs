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


    }
}
