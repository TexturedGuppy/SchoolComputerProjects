//System comes from the .NET framework
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermReview
{
    class Program
    {
        static void Main(string[] args)//Entry Point - Where the program is actually starting
        {
            //Console comes from system
            Console.WriteLine("Hello World");
            Console.WriteLine("{0, -5}. {1}", 1, "Soda");
            Console.WriteLine("{0, -5}. {1}", 2, "Coffee");
            //string str;
            //str = Console.ReadLine();

            ////Have to convert to Int before you can read the line, because readline returns a string
            int poop;
            //poop = Convert.ToInt32(Console.ReadLine());

            //The above will crash if its not int so we can try this below
            //It will try to parse what the user enters, if it can it will print what they typed
            //If it can't it just wont try it so the program won't crash.
            //if (int.TryParse(Console.ReadLine(), out poop))
            //{
            //    Console.WriteLine(poop);
            //}

            //We have to use new with a reference type
            //to actually create an object
            NinjaTurtle deCaprio = new NinjaTurtle();
            deCaprio.Name = "Leonardo";
            Console.WriteLine(deCaprio.Name);

            NinjaTurtle raphael = deCaprio;
            Console.WriteLine(raphael.Name);
            raphael.Name = "Raphael";
            Console.WriteLine(deCaprio.Name);
            raphael = new NinjaTurtle();

        }
    }
}
