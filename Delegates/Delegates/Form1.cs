using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form1 : Form
    {
        Character c = new Character();

        public delegate void TestDelegate();
        public delegate void TestDelegate2(string str);

        TestDelegate del;
        TestDelegate2 del2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //del();
            //del2(textBox1.Text);
            HeavyProcessing(del);
        }
        public void Func1()
        {
            richTextBox1.AppendText("Running Func1...\n");
        }
        public void Func2()
        {
            richTextBox1.AppendText("Running Func2...\n");

        }
        public void Func3(string str)
        {
            richTextBox1.AppendText("Running Func3...str is: " + str + ".\n");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            del = Func1;
            del += Func2;
            del2 += Func3;




        }

        public void HeavyProcessing(TestDelegate callback)
        {
            richTextBox1.AppendText("Doing Heavy Processing...\n");
            callback();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            richTextBox2.AppendText(c.Attack() + "\n");

        }

        private void btnLevel_Click(object sender, EventArgs e)
        {
            c.LevelUp();

        }
    }
}
