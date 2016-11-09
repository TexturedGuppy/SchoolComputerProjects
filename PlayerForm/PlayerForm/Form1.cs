using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PlayerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLevel.Text == "" || txtScore.Text == "")
                return;
            Player p;
            p.name = txtName.Text;
            p.level = Convert.ToInt32(txtLevel.Text);
            p.score = Convert.ToInt32(txtScore.Text);

            lstPlayers.Items.Add(p);



            txtName.Clear();
            txtLevel.Clear();
            txtScore.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream file = new FileStream("leaderboard.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);

            string line = reader.ReadLine();
            lstPlayers.Items.Add(line);
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                //convert line to player
                lstPlayers.Items.Add(line);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            FileStream file = new FileStream("leaderboard.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file);
            int counter = 0;
            foreach(Player p in lstPlayers.Items)
            {
                counter++;
                writer.WriteLine(p);
                progressBar1.Value = (int)(100 * ((float)counter /lstPlayers.Items.Count));
                //Thread.Sleep(1000);
            }


            writer.Flush();
            writer.Close();
            file.Close();
            MessageBox.Show("Form Closing.");
        }
    }
}
