using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7methods
{
    class Player
    {
        public int level = 0;
        public int strength = 0;
        public int intelligence = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            Player p1 = new Player();
            SetPlayerStats(p1, 5, 18, 18);

            Player p2 = new Player();
            SetPlayerStats(p2);

            //Find strongest of 2 players
            Console.WriteLine(Max(p1.level, p2.level));

            Player p3 = new Player();
            //SetPlayerStats(p3, , 18, 18); //Doesn't work, cant skip arguments
            SetPlayerStats(p3, str: 18, intel: 18); //This works, Called named parameters (Allows skipping or reordering parameters how you want.

            //Find strongest of 3 players
            Console.WriteLine(Max(p1.level, p2.level, p3.level));

            Console.WriteLine(Max(1, 4, 5, 6, 7, 5, 4, 3, 4, 5, 6, 7)); //Doesn't matter how many arguments now, because of the new params version of Max
            
            //Player players[32]; //C++ way

            //C# way
            Player[] players = new Player[32];

            for (int i = 0; i < 32; i++)
            {
                players[i] = new Player();
                Console.WriteLine(players[i].level);
            }

            int[] intArray = { 1, 2, 3 };

            
            Console.WriteLine(intArray[2]);

            //in C# loop, hits each element once, p will point to it
            foreach (Player p in players)
            {
                SetPlayerStats(p);
            }

            //    Player p1 = new Player();
            //    Player p2 = new Player();
            //    Console.WriteLine(p1.level);//0
            //    levelUp(p1.level);
            //    Console.WriteLine(p1.level);//0
            //    Console.WriteLine();


            //    Console.WriteLine(p1.level);//0
            //    levelUp(p1);
            //    Console.WriteLine(p1.level);//1
            //    Console.WriteLine();

            //    Console.WriteLine(p1.level);
            //    levelUp(ref p1.level); //ref forces it to be a reference
            //    Console.WriteLine(p1.level);
            //    Console.WriteLine();

            //    Player p2;
            //    Console.WriteLine(p2.level);
            //    levelUp(out p2);

            Dice dice1 = new Dice();
            Dice dice2 = new Dice(20);
            for (int i = 0; i < 100; i++)
            {
               // Console.WriteLine(dice1.Roll());


            }

            DiceGame craps = new DiceGame();

            craps.Play();

        }

        static int Max(params Player[] players)
        {
            int largest = int.MinValue;
            foreach (Player p in players)
            {
                if (p.level > largest)
                    largest = p.level;
            }
            return largest;
        }


        //Params keyword converts any values you put into the function into an array.
        static int Max(params int[] values)
        {
            int largest = int.MinValue;
            foreach(int v in values)
            {
                if (v > largest)
                    largest = v;
            }
            return largest;
        }

        //static int Max(int num1, int num2)
        //{
        //    //if (num1 > num2)
        //    //    return num1;
        //    //return num2;

        //    return num1 > num2 ? num1 : num2;
        //}

        static void levelUp(int level)//int level is a copy (passed by value)
        {
            level++;
        }

        static void levelUp(Player p)//Player p is a reference automatically
        {
            p.level++;
        }
        static void levelUp(ref int level)//ref forces it to be a reference
        {
            level++;
        }
        static void levelUp(out Player p)
        {
            //out keyword means it will not be null after this function
            p = new Player();
            p.level++;
        }
        static void SetPlayerStats(Player p, int lvl = 1, int str = 10, int intel = 10)
        {
          
            p.level = lvl;
            p.strength = str;
            p.intelligence = intel;
        }
    }
}
