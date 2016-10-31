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
            this.lblHangman = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnQuitTitle = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
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
            this.btnQuit.Location = new System.Drawing.Point(898, 601);
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
            this.btnQuitTitle.Location = new System.Drawing.Point(282, 479);
            this.btnQuitTitle.Name = "btnQuitTitle";
            this.btnQuitTitle.Size = new System.Drawing.Size(178, 50);
            this.btnQuitTitle.TabIndex = 2;
            this.btnQuitTitle.Text = "Quit!";
            this.btnQuitTitle.UseVisualStyleBackColor = true;
            this.btnQuitTitle.Click += new System.EventHandler(this.btnQuitTitle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(985, 636);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnQuit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHangman;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnQuitTitle;
    }
}

