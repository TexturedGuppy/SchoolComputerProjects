using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate string CharacterAction(int amount);
    class Character
    {
        public CharacterAction attackDelegate;

       public Character()
        {
            attackDelegate = NormalAttack;
        }

        public string Attack()
        {
            return attackDelegate(5);
        }

        public void LevelUp()
        {
            attackDelegate += SpecialAttack;
        }

        public string NormalAttack(int damage)
        {
            return "Attacking for " + damage.ToString() + " damage";
        }

        public string SpecialAttack(int damage)
        {
            return "Using Special attack";
        }

    }
}
