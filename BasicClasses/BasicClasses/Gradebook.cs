using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    class Gradebook
    {
        public string CourseName { get; set; }
        //private string courseName;
        //private int numStudents;
        //public int NumStudents { get; set; } //Auto-implements get and set properties
        public int numStudents;
        private int numAs, numBs, numCs, numDs, numFs;

        public int NumStudents //C# property statement
        {
            get
            {
                return numStudents;
            }
            set
            {
                if (value > 0)
                    numStudents = value;
            }
        }
        public Gradebook(string cName)//Overloaded Constructor
        {
            Init();

            // numAs = numBs = numCs = numDs = numFs = 0; //Moved to Init Constructor
            CourseName = cName;
           // NumStudents = -1;//Setting the instance variable (Bad, would circumvent all validation code, gets around the if statement) //Moved to init constructor
        }
        public Gradebook()
        {
            Init();
            //numAs = numBs = numCs = numDs = numFs = 0; //Moved to Init Constructor
            CourseName = "Unnamed Course";
            //NumStudents = 1;//Setting the property
        }

        public void Init()
        {
           numAs = numBs = numCs = numDs = numFs = 0; //Sets all the values to 0 at the same time
           NumStudents = -1;//Setting the instance variable (Bad, would circumvent all validation code, gets around the if statement)

        }

        private void IncrementLetterGrades(int grade)
        {
            //Short-circuiting: if we know grade > 90, we don't need to see if grade =-2
            if (grade > 90 || grade == -2)
                Console.WriteLine("A or audit");
            switch(grade / 10)
            {
                case 10:
                   // numAs++; //Dont need these two pieces of code since 9 and 10 are same
                   // break;
                case 9:
                    numAs++;
                    break;
                case 8:
                    numBs++;
                    break;
                case 7:
                    numCs++;
                    break;
                case 6:
                    numDs++;
                    break;
                default:
                    numFs++;
                    break;
                    
            }
        }

        public void DetermineClassAverage()
        {
            Console.WriteLine("Enter a grade or -1 to quit");
            int total = 0;
            int count = 0;
            //priming the while loop
            int value = Convert.ToInt32(Console.ReadLine());
            //Sentinel Controlled While loop (When don't know what ending value will be)
            while (value!=-1) //-1 is our sentinel value
            {
                if (value > 100)
                {
                    Console.WriteLine("Extra Credit isn't allowed!! :(");
                    break; //Breaks out of the loop and doesn't continue the loop
                }

                if (value == -2)
                {
                    continue;//Skips rest of the loop but still loops
                }

                IncrementLetterGrades(value);

                total += value; //compound assignment operator
                count++; //postfix increment operator
                //++count; //prefix increment operator
                value = Convert.ToInt32(Console.ReadLine());
            }

            //Counter Controlled loop
            //NumStudents = count;
            //for(int i = 0; i < NumStudents; i++)
            //{

            //}

            Console.WriteLine("Total of student grades: {0}", total);
            Console.WriteLine("Average grade: " + (total / count).ToString());
            Console.WriteLine("A's: " + numAs);
            Console.WriteLine("B's: " + numBs);
            Console.WriteLine("C's: " + numCs);
            Console.WriteLine("D's: " + numDs);
            Console.WriteLine("F's: " + numFs);



        }


        //public string CourseName //C# Property
        //{
        //    get
        //    {
        ////public string GetCourseName(); equivalent to this function
        //        return courseName;
        //    }
        //    set
        //    {
        //        courseName = value;
        //    }
        //}
    }
}
