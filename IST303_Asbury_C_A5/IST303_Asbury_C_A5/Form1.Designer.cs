namespace IST303_Asbury_C_A5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHangman = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnQuitTitle = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.picHangman = new System.Windows.Forms.PictureBox();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHangman
            // 
            this.lblHangman.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHangman.AutoSize = true;
            this.lblHangman.Font = new System.Drawing.Font("Jokerman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangman.Location = new System.Drawing.Point(272, 24);
            this.lblHangman.Name = "lblHangman";
            this.lblHangman.Size = new System.Drawing.Size(200, 58);
            this.lblHangman.TabIndex = 0;
            this.lblHangman.Text = "Hangman";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(282, 396);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(178, 50);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(29, 598);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.btnQuitTitle);
            this.pnlTitle.Controls.Add(this.lblHangman);
            this.pnlTitle.Controls.Add(this.btnPlay);
            this.pnlTitle.Location = new System.Drawing.Point(126, 12);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(734, 612);
            this.pnlTitle.TabIndex = 3;
            // 
            // btnQuitTitle
            // 
            this.btnQuitTitle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitTitle.Location = new System.Drawing.Point(282, 479);
            this.btnQuitTitle.Name = "btnQuitTitle";
            this.btnQuitTitle.Size = new System.Drawing.Size(178, 50);
            this.btnQuitTitle.TabIndex = 2;
            this.btnQuitTitle.Text = "Quit!";
            this.btnQuitTitle.UseVisualStyleBackColor = true;
            this.btnQuitTitle.Click += new System.EventHandler(this.btnQuitTitle_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(149, 506);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(28, 28);
            this.btnA.TabIndex = 4;
            this.btnA.TabStop = false;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.picHangman);
            this.pnlGame.Controls.Add(this.lblWinLose);
            this.pnlGame.Controls.Add(this.btnQuit);
            this.pnlGame.Controls.Add(this.btnReplay);
            this.pnlGame.Controls.Add(this.lblWord);
            this.pnlGame.Controls.Add(this.button25);
            this.pnlGame.Controls.Add(this.button24);
            this.pnlGame.Controls.Add(this.button23);
            this.pnlGame.Controls.Add(this.button22);
            this.pnlGame.Controls.Add(this.button21);
            this.pnlGame.Controls.Add(this.button20);
            this.pnlGame.Controls.Add(this.button19);
            this.pnlGame.Controls.Add(this.button18);
            this.pnlGame.Controls.Add(this.button17);
            this.pnlGame.Controls.Add(this.button16);
            this.pnlGame.Controls.Add(this.button15);
            this.pnlGame.Controls.Add(this.button14);
            this.pnlGame.Controls.Add(this.button13);
            this.pnlGame.Controls.Add(this.button12);
            this.pnlGame.Controls.Add(this.button11);
            this.pnlGame.Controls.Add(this.button10);
            this.pnlGame.Controls.Add(this.button9);
            this.pnlGame.Controls.Add(this.button8);
            this.pnlGame.Controls.Add(this.button7);
            this.pnlGame.Controls.Add(this.button6);
            this.pnlGame.Controls.Add(this.button5);
            this.pnlGame.Controls.Add(this.button4);
            this.pnlGame.Controls.Add(this.button3);
            this.pnlGame.Controls.Add(this.button2);
            this.pnlGame.Controls.Add(this.button1);
            this.pnlGame.Controls.Add(this.btnA);
            this.pnlGame.Location = new System.Drawing.Point(110, -2);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(750, 626);
            this.pnlGame.TabIndex = 5;
            // 
            // picHangman
            // 
            this.picHangman.Image = ((System.Drawing.Image)(resources.GetObject("picHangman.Image")));
            this.picHangman.Location = new System.Drawing.Point(285, 49);
            this.picHangman.Name = "picHangman";
            this.picHangman.Size = new System.Drawing.Size(174, 205);
            this.picHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHangman.TabIndex = 33;
            this.picHangman.TabStop = false;
            // 
            // lblWinLose
            // 
            this.lblWinLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWinLose.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLose.ForeColor = System.Drawing.Color.Red;
            this.lblWinLose.Location = new System.Drawing.Point(3, 325);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(744, 114);
            this.lblWinLose.TabIndex = 32;
            this.lblWinLose.Text = "WinOrLose";
            this.lblWinLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReplay
            // 
            this.btnReplay.Location = new System.Drawing.Point(29, 569);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(75, 23);
            this.btnReplay.TabIndex = 31;
            this.btnReplay.Text = "Restart";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // lblWord
            // 
            this.lblWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWord.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(3, 439);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(744, 47);
            this.lblWord.TabIndex = 30;
            this.lblWord.Text = "HiddenWord";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(557, 535);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(28, 28);
            this.button25.TabIndex = 29;
            this.button25.TabStop = false;
            this.button25.Text = "Z";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(523, 535);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(28, 28);
            this.button24.TabIndex = 28;
            this.button24.TabStop = false;
            this.button24.Text = "Y";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(183, 506);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(28, 28);
            this.button23.TabIndex = 27;
            this.button23.TabStop = false;
            this.button23.Text = "B";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(217, 506);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(28, 28);
            this.button22.TabIndex = 26;
            this.button22.TabStop = false;
            this.button22.Text = "C";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(251, 506);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(28, 28);
            this.button21.TabIndex = 25;
            this.button21.TabStop = false;
            this.button21.Text = "D";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(285, 506);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(28, 28);
            this.button20.TabIndex = 24;
            this.button20.TabStop = false;
            this.button20.Text = "E";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(319, 506);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(28, 28);
            this.button19.TabIndex = 23;
            this.button19.TabStop = false;
            this.button19.Text = "F";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(353, 506);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(28, 28);
            this.button18.TabIndex = 22;
            this.button18.TabStop = false;
            this.button18.Text = "G";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(387, 506);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(28, 28);
            this.button17.TabIndex = 21;
            this.button17.TabStop = false;
            this.button17.Text = "H";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(421, 506);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(28, 28);
            this.button16.TabIndex = 20;
            this.button16.TabStop = false;
            this.button16.Text = "I";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(455, 506);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(28, 28);
            this.button15.TabIndex = 19;
            this.button15.TabStop = false;
            this.button15.Text = "J";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(489, 506);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(28, 28);
            this.button14.TabIndex = 18;
            this.button14.TabStop = false;
            this.button14.Text = "K";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(523, 506);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(28, 28);
            this.button13.TabIndex = 17;
            this.button13.TabStop = false;
            this.button13.Text = "L";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(557, 506);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(28, 28);
            this.button12.TabIndex = 16;
            this.button12.TabStop = false;
            this.button12.Text = "M";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(149, 535);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(28, 28);
            this.button11.TabIndex = 15;
            this.button11.TabStop = false;
            this.button11.Text = "N";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(183, 535);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(28, 28);
            this.button10.TabIndex = 14;
            this.button10.TabStop = false;
            this.button10.Text = "O";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(217, 535);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(28, 28);
            this.button9.TabIndex = 13;
            this.button9.TabStop = false;
            this.button9.Text = "P";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(251, 535);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 28);
            this.button8.TabIndex = 12;
            this.button8.TabStop = false;
            this.button8.Text = "Q";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(285, 535);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 28);
            this.button7.TabIndex = 11;
            this.button7.TabStop = false;
            this.button7.Text = "R";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(319, 535);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 28);
            this.button6.TabIndex = 10;
            this.button6.TabStop = false;
            this.button6.Text = "S";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(353, 535);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 28);
            this.button5.TabIndex = 9;
            this.button5.TabStop = false;
            this.button5.Text = "T";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(387, 535);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 28);
            this.button4.TabIndex = 8;
            this.button4.TabStop = false;
            this.button4.Text = "U";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(421, 535);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 28);
            this.button3.TabIndex = 7;
            this.button3.TabStop = false;
            this.button3.Text = "V";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 6;
            this.button2.TabStop = false;
            this.button2.Text = "W";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAlphabetClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuitTitle;
            this.ClientSize = new System.Drawing.Size(974, 636);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHangman;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnQuitTitle;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.PictureBox picHangman;
    }
}

