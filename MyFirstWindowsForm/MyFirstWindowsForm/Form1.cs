using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1, val2;
            if (int.TryParse(textBox1.Text, out val1) && int.TryParse(textBox2.Text,out val2))
            {

            int result = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            lblResult.Text = result.ToString();
            Console.WriteLine(result);
            }
            else
            {
                lblResult.Text = "You're doing the wrong things!";
                lblResult.ForeColor = Color.Red;
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
