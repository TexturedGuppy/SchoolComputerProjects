﻿using System;
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
        Hangman h = new Hangman();
        List<Button> usedButtons = new List<Button>();

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
            lblWord.Text = h.GetWordText();
            lblWinLose.Text = "";

        }

        private void btnQuitTitle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void btnAlphabetClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            char temp = Convert.ToChar(button.Text);
            usedButtons.Add(button);
            if (!h.IsDead() && !h.isWin())
            {
                h.turn(temp);
                button.Enabled = false;

            }
            if (h.isWin())
            {
                lblWinLose.Text = h.Win();
            }
            if (h.IsDead())
            {
                lblWinLose.Text = h.Lose();
            }

            //if (h.Count == 1)
            //{
            //    picHangman.Image = Image.FromFile("hangman1.png");
            //}
            switch (h.Count)
            {
                case 1:
                    picHangman.Image = Image.FromFile("hangman1.png");
                    break;
                case 2:
                    picHangman.Image = Image.FromFile("hangman2.png");
                    break;
                case 3:
                    picHangman.Image = Image.FromFile("hangman3.png");
                    break;
                case 4:
                    picHangman.Image = Image.FromFile("hangman4.png");
                    break;
                case 5:
                    picHangman.Image = Image.FromFile("hangman5.png");
                    break;
                case 6:
                    picHangman.Image = Image.FromFile("hangman6.png");
                    break;
            }

            lblWord.Text = h.GetWordText();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            h = new Hangman();
            foreach (Button b in usedButtons)
            {
                b.Enabled = true;
            }
            lblWord.Text = h.GetWordText();
            lblWinLose.Text = "";

        }
    }
}



