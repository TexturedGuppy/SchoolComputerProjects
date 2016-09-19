using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character("Joe");
            Player p = new Player("Cameron");
            Enemy e = new Enemy();

            //p.Name = "Joe"; //no set in property so error
            Console.WriteLine(p.Name);

            p.attack(e);

            //c.Health = 100;
            //p.Health = 90;
            //e.Health = 70;
        }
    }
}
