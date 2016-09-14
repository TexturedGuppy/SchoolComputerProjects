using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradebook cppGB = new Gradebook();
            Gradebook csharpGB = new Gradebook("Programming Practice");

            Console.WriteLine(csharpGB.CourseName);
            csharpGB.CourseName = "C# .Net Programming";
            Console.WriteLine(csharpGB.CourseName);
            Console.WriteLine(cppGB.CourseName);

            Console.WriteLine(cppGB.NumStudents);
            Console.WriteLine(cppGB.NumStudents);

            cppGB.NumStudents = 15;
            Console.WriteLine(cppGB.NumStudents);


            //Console.WriteLine(cppGB.CourseName);
            //csharpGB.CourseName = "C# .Net Programming";
            //Console.WriteLine(cppGB.CourseName);

            int num = 5;
            Console.WriteLine(num); //prints 5
            Console.WriteLine(num++); //prints 5 but increments to 6 just doesn't write 6 because it was a postfix operator
            Console.WriteLine(++num); //increments again but we see 7 because it was a prefix operator added then printed.

            cppGB.DetermineClassAverage();


        }
    }
}
