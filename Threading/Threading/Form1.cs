using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = textBox1.Text;
            int n = Convert.ToInt32(textBox1.Text);
            label1.Text = Fib(n).ToString();
        }

        private long Fib(long n)
        {
            if (n == 0 || n == 1) //base case (so it doesn't go forever)
                return n;
            return Fib(n - 1) + Fib(n - 2);//General Case
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);

            //Task is the class C# provides to make multithreading
            //() => is a lambda expression - aka Anonymous function
            Task<long> fibTask = Task.Run(() => Fib(n));

            await fibTask;

            label1.Text = fibTask.Result.ToString();
        }
    }
}
