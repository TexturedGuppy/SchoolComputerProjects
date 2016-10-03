using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAndExceptions
{
    class NegativeValueException : Exception
    {
       public NegativeValueException()
           : base ("Negatives and zeroes not allowed")
        {
        
        }

    }
    class Program
    {
        static void IterativeCountdown(int num)
        {
            for (int i = num; i >=0; i--)
            {
                Console.WriteLine(i + "...");
            }
            Console.WriteLine("Blastoff!");
        }

        /// <summary>
        /// Recursion is when a function calls itself
        /// Recursion can give us more elegent, simpler solutions SOMETIMES
        /// </summary>
        /// <param name="num"></param>
        static void RecursiveCountdown(int num)
        {
            
            if (num == 0) //Base Case - what we are looking for to make recursion stop
            {
                Console.WriteLine("Blastoff!");
            }
            else //General Case - Condition where we continue to call the function again
            {
                Console.WriteLine(num + "...");
                num--;
                RecursiveCountdown(num);
            }


        }

        static long Factorial(int num)
        {
            if (num <= 0)
            {
                throw new NegativeValueException();
            }
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }

        static void Main(string[] args)
        {
            IterativeCountdown(10);
            RecursiveCountdown(10);
            Console.WriteLine(Factorial(5));

            int num1, num2;
            num1 = 5;
            num2 = 0;
            try
            {
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(Exception exception)
            {

            }
            finally//no matter what exceptions were or weren't thrown, run this.
            {

            }

            try
            {
                Console.WriteLine(Factorial(-1));
            }
            catch(NegativeValueException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine("our program carries on");
        }
    }
}
