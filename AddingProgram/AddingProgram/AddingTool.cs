
using System;

namespace AddingProgram
{

    //C++ class
    //class player
    //{

    //}; C# classes do not end with semicolons!!!
    class AddingTool
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 303");

            int num1, num2;
            //bool boolean;
            //float flt;
            //double dbl;
            //decimal dcm;

            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());

            //if (Int32.TryParse(Console.ReadLine(), out num1))
            //    Console.WriteLine("number1 is {0}", num1);
            //else
            //    Console.WriteLine("Invalid Input");

            //if (Int32.TryParse(Console.ReadLine(), out num2))
            //    Console.WriteLine("number2 is {0}", num2);
            //else
            //    Console.WriteLine("Invalid Input");

            while (!Int32.TryParse(Console.ReadLine(), out num1))
                Console.WriteLine("Invalid Input - try again");

            while (!Int32.TryParse(Console.ReadLine(), out num2))
                Console.WriteLine("Invalid Input - try again");


            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1+num2);

            //Two ways to case to another data type
            double num3 = Convert.ToDouble(num1);//Like c++ static_cast
            num3 = (double)num2;

            Player player1 = new Player();
            Console.WriteLine(player1.health);

        }
    }
}
