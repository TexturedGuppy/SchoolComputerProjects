﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermReview
{
    //structs are value types
    //structs can't use inheritance
    //value types are the actual value, not a pointer
    struct Weapon
    {
       public int damage;
       public int range;
    }

    class Character
    {
        public Weapon weapon;
        public string name;

        public void Attack(NinjaTurtle ninja)
        {

        }
    }
    class BadGuy
    {
        public Weapon weapon;
        public int points;
        public string name;
        static Random rand = new Random();

        public BadGuy()
        {
            points = rand.Next(1, 100);
        }
        public void Attack(NinjaTurtle ninja)
        {

        }
    }
    //Classes allow us to define our own data type
    //classes are reference type
    //reference types are equivalent to smart pointers in c++
    class NinjaTurtle
    {
        //Constructor - called when we use new to make an object
        //Dont forget to make public because if you don't you could no longer create new objects of this class type in main.
        public NinjaTurtle()
        {
            Console.WriteLine("In the ninjaturtle constructor");

            name = "Unnamed";
            weapon.damage = 10;
            weapon.range = 5;
        }
        public NinjaTurtle(string _name)
        {
            Console.WriteLine("In the ninjaturtle constructor");
            name = _name;
            weapon.damage = 10;
            weapon.range = 5;
        }
        //(instance or member) variables, attributes, fields
        private string name;

        //Data Composition - NinjaTurtles Have a Weapon or "Has A"
        private Weapon weapon;

        //Property
        public string Name
        {
            get
            {
                return name;
            }
            //can use private set, so member functions can set values but Main cannot
           set
            {
                //logic to control how name gets changed
                name = value;
            }
        }
        //Equivalent to get block in property
        public string getName()
        {
            return name;
        }
        //Equivalent to set block in property
        public void setName(string Name)
        {
            Name = name;
        }

        //(member) functions, methods, operations
        //public, private, protected are access specifiers
        public void Attack(NinjaTurtle other)
        {

        }
    }
}
