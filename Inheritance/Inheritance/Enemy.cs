﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Enemy :Character
    {
        public Enemy()
            :base("Bandit")
        {
            Console.WriteLine("Enemy Constructor");
        }    
            
        
        int expValue;
        public int ExpVal
        {
            get { return ExpVal; }
            set
            {
                expValue = value;
                if (expValue < 0)
                    expValue = 0;
            }
        }
        public override void TakeTurn()
        {
            base.TakeTurn();

            Console.WriteLine(name + " is moving");
            Console.WriteLine("In Enemy::TakeTurn");
            Console.WriteLine();

        }

    }
}
