using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IST303_Asbury_C_A5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnQuit.Visible = false;
            pnlGame.Visible = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlTitle.Visible = false;
            pnlGame.Visible = true;
            btnQuit.Visible = true;
            Form1.ActiveForm.CancelButton = btnQuit;
        }

        private void btnQuitTitle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
        }

        private void btnAlphabetClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.Enabled = false;
        }
    }
}
