using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7methods
{

    public enum DiceNames
    {
        SnakeEyes = 7,
        Trey = 3,
        Seven = 7,
        Yo_leven = 11,
        BoxCars = 12
    }
    class Dice
    {
        static Random random = new Random();
        public int Sides { get; set; }
        public Dice(int Sides = 6)
        {
            this.Sides = Sides; //this keyword points to the calling object
        }

        public int Roll()
        {
            //Random random = new Random();
            return random.Next(1, Sides + 1);
        }
    }


    class DiceGame
    {
        public Dice dice1, dice2;
        public DiceGame() //Constructor
        {
            dice1 = new Dice();
            dice2 = new Dice();
        }

        public void Play()
        {
            Console.Write("You roll 2 dice:");
            int result = dice1.Roll() + dice2.Roll();
            Console.WriteLine(result + "!!!");

            if (result == (int)DiceNames.Seven || result == (int)DiceNames.Yo_leven)
                Console.WriteLine("You win!");
            if (result == (int)DiceNames.SnakeEyes || result == (int)DiceNames.Trey || result == (int)DiceNames.BoxCars)
                Console.WriteLine("You Lose :(");

            //switch((DiceNames)result)
            //{
            //    case DiceNames.Seven:
            //    case DiceNames.Yo_leven:
            //        Console.WriteLine("You Win");
            //        break;
            //}
        }
    }


}
