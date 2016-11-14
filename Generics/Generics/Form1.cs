using System;
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
        }
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
