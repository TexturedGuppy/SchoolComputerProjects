﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Player:Character
    {
        //:after constructor name is the Member Initialization List used to call base class constructor if it has parameters
        public Player(string n)
            :base (n) //Member Initialization List
        {
            experience = 0;
            Health = 100;
            Console.WriteLine("Player Constructor");

        }

        int experience;
        public int Exp
        {
            get { return experience; }
            set
            {
                experience = value;
                if (experience < 0)
                {
                    experience = 0;
                }
            }
        }

        
        public void attack(Enemy e)
        {
            e.Health -= strength;
            Exp += e.ExpVal;
        }

    }
}
