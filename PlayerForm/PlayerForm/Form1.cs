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

            //string line = reader.ReadLine();
            //lstPlayers.Items.Add(line);
            do
            {
                string line = reader.ReadLine();
                //convert line to player
                string[] data = line.Split(' ');

                Player p;
                p.name = data[0];
                p.name = data[(int)Player.FileParams.name];
                if (!int.TryParse(data[(int)Player.FileParams.level], out p.level))
                {
                    MessageBox.Show("Someone messed with this file!");
                }
                if (!int.TryParse(data[(int)Player.FileParams.score], out p.score))
                {
                    MessageBox.Show("Someone messed with this file!");
                }
                //p.level = Convert.ToInt32(data[(int)Player.FileParams.level]);


                lstPlayers.Items.Add(p);
            }
            while (!reader.EndOfStream);

            reader.Close();
            file.Close();
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
