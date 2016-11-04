using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FileProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Open Button Functionality
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            fileDialog.ShowDialog();
            FileStream f = (FileStream)fileDialog.OpenFile();
            foreach(string s in File.ReadLines(fileDialog.FileName))
            {
                richTextBox1.AppendText(s + "\n");
            }
           //FileStream f = (FileStream)fileDialog.OpenFile();

        }

        //Save Button Functionality
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileDialog.FileName, richTextBox1.Text);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDoStuff_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //Strings are immutable - they can't be changed.
            //everytime you assign a new value to a string, it has to make a new one
            //strings are just arrays of characters, like a list they have to make new ones to grow.
            string hangmanAnswer = "Chicken";
            hangmanAnswer = "   Fish   ";
            hangmanAnswer.Trim();
            string str2 = hangmanAnswer + hangmanAnswer;
            richTextBox1.Text = str2[3].ToString();
            richTextBox1.Text = char.ToUpper(str2.ElementAt(3)).ToString();
            richTextBox1.Text = str2.ToUpper();

            int index = textBox1.Text.IndexOf('.');
            string extension = textBox1.Text.Substring(index + 1);
            richTextBox1.Text = extension;
            //now find the directory portion of C:\stuff.txt
            index = textBox1.Text.IndexOf(':');
            string directory = textBox1.Text.Substring(0, index + 1);
            richTextBox1.AppendText("\n" + directory);
            richTextBox1.AppendText("\n" + 
                textBox1.Text.Substring(index + 1, 
                textBox1.Text.IndexOf('.') - index - 1));

            StringBuilder sb = new StringBuilder(20);
            //sb += " Mundell"; //A string in quotes is called a string literal.
            sb.Append("Mundell");
            richTextBox1.Text = sb.ToString();
            sw.Stop();
            richTextBox1.Text = sw.ElapsedTicks.ToString();
            //richTextBox1.Text = sw.ElapsedMilliseconds.ToString();



        }
    }
}
