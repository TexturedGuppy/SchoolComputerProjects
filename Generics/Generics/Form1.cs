using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] intArray = {1,2,3,4,23,62};
            double[] doubleArray = { 1.5, 2.2, 4.9, 3.14, 62 };
            string[] stringArray = { "cat", "hat", "bat", "chat", "pat" };

            PrintArray(intArray);
            PrintArray(doubleArray);
            PrintArray(stringArray);

            List<string> list = new List<string>();
            List<int> intList = new List<int>();

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(5);
            linkedList.AddLast(32);
            richTextBox1.AppendText(linkedList.ElementAt(1).ToString());

            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("hat");
            stringStack.Push("bat");
            stringStack.Push("cat");
            richTextBox1.AppendText("\n\n");
            richTextBox1.AppendText(stringStack.Peek());//Same as Top in C++
            stringStack.Pop();
            richTextBox1.AppendText(stringStack.Peek());

            Queue<string> stringQueue = new Queue<string>();
            stringQueue.Enqueue("Player 1");
            stringQueue.Enqueue("Player 2");
            stringQueue.Enqueue("Player 3");
            richTextBox1.AppendText("\n\n");
            richTextBox1.AppendText(stringQueue.Peek());
            stringQueue.Enqueue(stringQueue.Dequeue());//Makes that player basically walk to the back of the line
            richTextBox1.AppendText(stringQueue.Peek());

            list.Add("bob");
            list.Add("hob");
            list.Add("gob");
            PrintArray(list);

            Compare(2,4);
            Compare("dog", "cat");

            Player p1 = new Player();
            Player p2 = new Player();

            SmartArray<string> ourList = new SmartArray<string>();
            ourList.Add("Matt");
            ourList.Add("James");
            ourList.Add("Cameron");
            ourList.Add("Jacob");
            ourList.Add("Ian");

            SmartArray<int> ourIntList = new SmartArray<int>();
            ourIntList.Add(5);

            Hashtable table = new Hashtable();
            table.Add(0,"Matt");
            table.Add(3.14, stringQueue);

            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            dictionary.Add("WV", .06);
            dictionary.Add("PI", 3.14);
            dictionary.Add("KY", .08);
            richTextBox1.AppendText(dictionary["PI"].ToString());

        }

        //Generic Function, where T can take any type of data
        void PrintArray<T>(IEnumerable<T> arr)
        {
            foreach(T i in arr)
            {
                richTextBox1.AppendText(i.ToString() + "\n");
            }
        }

        bool Compare<T>(T x, T y)
            where T : IComparable<T>
        {
            return x.CompareTo(y) == 0;
        }
    }

    class Player { }
}
