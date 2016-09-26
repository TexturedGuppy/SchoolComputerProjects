using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //abstract - cannot  create instances of GameObject, can only inherit from GameObject
    abstract class GameObject
    {
        public virtual void TakeTurn()
        {
            Console.WriteLine("In Game Object::TakeTurn");
        }
    }
    class Character:GameObject
    {
        public Character(string n)
        {
            stamina = 10;
            strength = 10;
            level = 1;
            name = n;
            Console.WriteLine("Character Constructor");
            id = nextID++;
        }

        static int nextID = 1;
        public int id;

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

        public override void TakeTurn()
        {
            Console.WriteLine("Character with id " + id + " moving");
            //Console.WriteLine(name + " is moving");
            Console.WriteLine("In Character::TakeTurn");
        }

        public override string ToString()
        {
            return name + " " + base.ToString();
        }

    }
}
