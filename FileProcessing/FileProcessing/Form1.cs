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
    }
}
