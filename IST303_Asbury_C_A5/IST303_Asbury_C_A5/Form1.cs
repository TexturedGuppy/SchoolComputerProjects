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
        Hangman h = new Hangman();
        List<Button> usedButtons = new List<Button>(); //stores all the used buttons, only storing the used buttons reduces the amount of cycles needed to run through them.

        public Form1()
        {
            InitializeComponent();
            pnlGame.Visible = false; //Start game without second panel showing.
        }

        /// <summary>
        /// Just exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Starts playing the game
        /// Once started the games title panel is disabled and the game panel is enabled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlTitle.Visible = false;
            pnlGame.Visible = true;
            btnQuit.Visible = true;
            Form1.ActiveForm.CancelButton = btnQuit; //Reassigns the standard quit button to the new quit button in the game panel.
            lblWord.Text = h.GetWordText(); //Sets our word we're trying to guess.
            lblWinLose.Text = "";

        }

        /// <summary>
        /// Just exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitTitle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
        /// <summary>
        /// Function Handles what happens when the player clicks one of the alphabet buttons
        /// Runs turns and checks to see if it's time for a player to win or lose on each turn.
        /// Function also displays the hangman visually
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlphabetClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            char temp = Convert.ToChar(button.Text);
            usedButtons.Add(button);
            if (!h.IsDead() && !h.isWin())//Disables player's ability to continue to click buttons after they have won or lost
            {
                h.turn(temp);
                button.Enabled = false;

            }
            if (h.isWin())//Win Checking
            {
                lblWinLose.Text = h.Win();
            }
            if (h.IsDead())//Loss Checking
            {
                lblWinLose.Text = h.Lose();
            }

            switch (h.Count) //Switch to handle which stage of the hangman is shown
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

        /// <summary>
        /// Replay button that quickly resets everything in the game panel allowing for a quick version of replaying the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplay_Click(object sender, EventArgs e)
        {
            h = new Hangman();
            foreach (Button b in usedButtons)//loops through usedbutton list and re-enables the buttons
            {
                b.Enabled = true;
            }
            lblWord.Text = h.GetWordText();
            lblWinLose.Text = "";

        }
    }
}



