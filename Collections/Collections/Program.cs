using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    //IN C++, a struct is just like a class, except everthing is public by default
    //IN C#, a struct is private by default. It is a value type, not a reference type.
    //And you can't use inheritance with structs.
    struct Point //Just like a class, except everything is public by default
    {
      public float x;
      public float y;
    }

    class PointClass 
    {
        public float x;
        public float y;
        
        public PointClass Copy()
        {
            PointClass temp = new PointClass();
            temp.x = x;
            temp.y = y;
            return temp;
        }
    }

    class LineSegment
    {
        public LineSegment()
        {
            p1 = new Point();
            p2 = new Point();
            p1.x = 0;
            p1.y = 0;
            p2.x = 1;
            p2.y = 1;
            CalcLength();
            dirty = false;

        }
        private Point p1;
        private Point p2;
        private float length;
        private bool dirty; //changed

        public Point P1 { get; set; } //Auto Implemented Property

        public Point P2 //Normal Property
        {
            get
            {
                return p2;
            }
            set //P2 = somePoint;
            {
                dirty = true;
                p2 = value;

            }
        }

        public void CalcLength()
        {
            length = (float)Math.Sqrt(Math.Pow((p2.y - p1.y),2) + Math.Pow((p2.x - p1.x),2));
            dirty = false;
        }
        public float GetLength()
        {
            if (dirty)
                CalcLength(); //Added here it updates properly everytime it is called

            return length;
        }
    }

    class Character
    {
        static private Random rand = new Random();
        public int strength;
        public int health;

        public Character()
        {
            strength = rand.Next(1, 11);
            health = rand.Next(1, 101);
        }
        public override string ToString() //This overrides the global tostring every class automatically has
        {

            return "Character's strength: " + strength + "\nCharacter's health: " + health;
        }
    }
    class Program
    {
        static bool FindInt(int i)
        {
            return i == 7;
        }
        static void Main(string[] args)
        {
            LineSegment linesegment = new LineSegment();
            Console.WriteLine(linesegment.P1.x);
            Console.WriteLine(linesegment.P1.y);
            Console.WriteLine(linesegment.P2.x);
            Console.WriteLine(linesegment.P2.y);
            //linesegment.CalcLength(); //Placed inside of getLength to avoid this design flaw, and will still update everytime
            Console.WriteLine(linesegment.GetLength());

            //Now set a new endpoint in P2 to change the line segment
            Point newEndPoint = new Point();
            newEndPoint.x = 2;
            newEndPoint.y = 2;
            linesegment.P2 = newEndPoint;
            Console.WriteLine(linesegment.GetLength());

            newEndPoint.x = 3;
            newEndPoint.y = 3;
            linesegment.P2 = newEndPoint;
            Console.WriteLine(linesegment.GetLength());

            int[] intArray = new int[10];
            for(int i = 0; i < 10; i++)
            {
                intArray[i] = i;
            }

            List<int> intList = new List<int>();
            for(int i = 0; i < 20; i++)
            {
                intList.Add(i);
            }
            intList.Remove(0);
            for(int i = 0; i < 20; i++)
            {
                intList.Add(i);
            }

            foreach (int val in intList)
                Console.Write(val + " ");

            Console.WriteLine();
            //Struct is a value type, Class is a reference type.
            PointClass p = new PointClass();
            p.x = 5;
            p.y = 10;
            PointClass p2 = new PointClass();
            p2 = p.Copy();
            p2.x = 15;
            Console.WriteLine(p.x);
            Console.WriteLine();

            Console.WriteLine("Sunkist: $1.00");
            Console.WriteLine("Sunny D: $1.00");
            Console.WriteLine("Pepsi: $1.00");

            Console.WriteLine("{0, -10} {1}", "Sunkist", "$1.00");//Using params in their function
            Console.WriteLine("{0, -10} {1}", "Sunny D", "$1.00");//Using params in their function
            Console.WriteLine("{0, -10} {1}", "Pepsi", "$1.00");//Using params in their function

            List<int> list = new List<int>(8);
            list.Add(5);
            list.Add(17);
            list.Add(4);
            list.Add(7);
            list.Add(4);
            //list.TrimExcess();
            Console.WriteLine("list.Count is: " + list.Count);
            Console.WriteLine("List Capacity is: " + list.Capacity);
            foreach (int i in list)
                Console.WriteLine(i);
            Console.WriteLine();
            Predicate<int> searchPredicate = FindInt;
            Console.WriteLine(list.Find(searchPredicate));

            List<Character> characters = new List<Character>();
            characters.Add(new Character());
            Character player = new Character();
            characters.Add(player);
            characters[0].health = 100;
            player.health = 100;
            characters[1].health = 100; //accomplishes same thing as player.health = 100;
            foreach(Character c in characters)
            {
                Console.WriteLine(c);
            }
        }
    }
}



