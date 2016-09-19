using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Character
    {
        public Character(string n)
        {
            stamina = 10;
            strength = 10;
            level = 1;
            name = n;
            Console.WriteLine("Character Constructor");
        }
       
        //protected kind of like public, but only children can use them
       protected string name;
       private int health;
       protected int strength;
       protected int stamina;
       protected int mana;
       protected int level;
        
        public int Health
        {
            get { return health; }
            set
            {
                health = value;
                if (health < 0)
                    health = 0;
            }
        }
        //Without set can only access it not change it
        public string Name
        {
            get { return name; }
        }
    }
}
