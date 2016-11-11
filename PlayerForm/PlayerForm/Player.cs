using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerForm
{
    struct Player
    {
        public enum FileParams
        {
            name, level, score
        }
        public string name;
        public int level;
        public int score;

        public override string ToString()
        {
            return name + " " + level.ToString() + " " + score.ToString();
        }
    }
}
