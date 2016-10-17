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
            raphael = new NinjaTurtle();
            raphael.Name = "Raphael";

            

            NinjaTurtle[] ninjaTurtles = new NinjaTurtle[4];
            ninjaTurtles[0] = new NinjaTurtle("Michaelangelo");
            ninjaTurtles[1] = raphael;
            ninjaTurtles[2] = deCaprio;
            ninjaTurtles[3] = new NinjaTurtle("Donatello");

            try
            {
                foreach(NinjaTurtle ninja in ninjaTurtles)
                {
                    Console.WriteLine(ninja.Name);
                }
            }
            catch(NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {

            }

            List<BadGuy> baddies = new List<BadGuy>();

            for(int i = 0; i < 10; i++)
            {
                baddies.Add(new BadGuy());

            }
                Console.WriteLine(baddies.Count);
                Console.WriteLine(baddies.Capacity);
            foreach (BadGuy bg in baddies)
            {
                Console.WriteLine(bg.points);
            }

            Console.WriteLine();
            //LINQ
            //Language Integrated Query
            var query = from baddie in baddies orderby baddie.points descending select baddie;

            foreach (BadGuy bg in query)
            {
                Console.WriteLine(bg.points);
            }
        }
    }
}
