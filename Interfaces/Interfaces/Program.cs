using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        interface IDamageable //public by default
        {
            void TakeDamage(float dmg);
        }
        class GameObject
        {

        }

        class SpaceShip : GameObject, IDamageable
        {
            public void TakeDamage(float dmg)
            {
                Console.WriteLine("SpaceShip took " + dmg + " damage.");
            }
        }

        class PlayerSpaceShip : SpaceShip
        {

        }

        class EnemySpaceShip : SpaceShip
        {

        }

        class Asteroid : GameObject, IDamageable
        {
            public void TakeDamage(float dmg)
            {
                Console.WriteLine("Asteroid took " + dmg + " damage.");

            }
        }

       class Snowball
        {
           public Snowball()
            {
                Size = 1;
            }
            public int Size { get; set; }

            //Operator Overloading
            public static Snowball operator+(Snowball lhs, Snowball rhs)
            {
                Snowball temp = new Snowball();

                //Logic for adding two of our objects together
                temp.Size = lhs.Size + rhs.Size;
                return temp;
            }

            public static bool operator >(Snowball lhs, Snowball rhs)
            {
                return lhs.Size > rhs.Size;
            }
            public static bool operator <(Snowball lhs, Snowball rhs)
            {
                return lhs.Size < rhs.Size;
            }

            public static implicit operator Snowball(int rhs)
            {
                Snowball temp = new Snowball();
                temp.Size = rhs;
                return temp;
            }

            //Overloading type-casting operators
            //Explicit means
            //public static explicit operator Snowball(int rhs)
            //{
            //    Snowball temp = new Snowball();
            //    temp.Size = rhs;
            //    return temp;
            //}
        }

        static void Main(string[] args)
        {
            List<GameObject> list = new List<GameObject>();
            list.Add(new PlayerSpaceShip());
            list.Add(new EnemySpaceShip());
            list.Add(new EnemySpaceShip());
            list.Add(new GameObject());
            list.Add(new Asteroid());
            list.Add(new Asteroid());
            list.Add(new Asteroid());
            list.Add(new Asteroid());

            //Anything that implements IEnumerable can be used in a foreach loop
            foreach(GameObject go in list)
            {
                if (go is IDamageable)
                {
                    ((IDamageable)go).TakeDamage(5);
                }
            }

            Snowball snowball1 = new Snowball();
            Snowball snowball2 = new Snowball();
            //Snowball combinedSnowball = new Snowball();
            Snowball combinedSnowball = snowball1 + snowball2;
            Console.WriteLine(combinedSnowball.Size);

            if (combinedSnowball > snowball1)
                Console.WriteLine("Greater");

            //implicit conversion
            Snowball snowball3 = 7;

            //explicit conversion
            Snowball snowball4 = (Snowball)7;
        }
    }
}
