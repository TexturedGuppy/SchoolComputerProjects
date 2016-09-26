using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character("Joe");
            Player p = new Player("Cameron");
            Enemy e = new Enemy();

            p.TakeTurn();
            //Downcasting - treat a child class like a base class
            Character characterReference = (Character)p;
            characterReference.TakeTurn();

            //GameObject go = c;
            //go.TakeTurn();

            //p.Name = "Joe"; //no set in property so error
            Console.WriteLine(p.Name);

            //p.attack(e);
            Console.WriteLine();

            c.TakeTurn();
            p.TakeTurn();
            e.TakeTurn();
            Console.WriteLine();

            Character currentCharacter = p;
            currentCharacter.TakeTurn();
            currentCharacter = e;
            currentCharacter.TakeTurn();
            Console.WriteLine();

            List<Character> characters = new List<Character>();
            characters.Add(p);
            characters.Add(c);
            for(int i = 0; i < 10; i++)
            {
                characters.Add(new Enemy());
            }
            foreach(Character character in characters)
            {
                //is keyword compares the types of objects (as opposed to their values)
                if (character is Player)
                {
                    //Character cReference = (Character)c;
                    Console.WriteLine(character.GetType());
                }

                //character.TakeTurn();
            }
            //c.Health = 100;
            //p.Health = 90;
            //e.Health = 70;
        }
    }
}
