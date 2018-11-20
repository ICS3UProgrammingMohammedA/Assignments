namespace _21SimplifiedMohammed
{
    partial class frm21simplified
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm21simplified));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblDealerCards = new System.Windows.Forms.Label();
            this.lblPlayerCard = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.lblPcard2 = new System.Windows.Forms.Label();
            this.lblPcard1 = new System.Windows.Forms.Label();
            this.lblPcard3 = new System.Windows.Forms.Label();
            this.lblDcard1 = new System.Windows.Forms.Label();
            this.lblDcard2 = new System.Windows.Forms.Label();
            this.lblDcard3 = new System.Windows.Forms.Label();
            this.lblPScore = new System.Windows.Forms.Label();
            this.lblDscore = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_21SimplifiedMohammed.Properties.Resources._1111;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(151, 296);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(80, 34);
            this.btnStay.TabIndex = 1;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(50, 296);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 34);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(399, 102);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(77, 34);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(685, 396);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(114, 54);
            this.btnPlayAgain.TabIndex = 4;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblDealerCards
            // 
            this.lblDealerCards.AutoSize = true;
            this.lblDealerCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCards.Location = new System.Drawing.Point(45, 106);
            this.lblDealerCards.Name = "lblDealerCards";
            this.lblDealerCards.Size = new System.Drawing.Size(127, 25);
            this.lblDealerCards.TabIndex = 5;
            this.lblDealerCards.Text = "Dealer Card";
            // 
            // lblPlayerCard
            // 
            this.lblPlayerCard.AutoSize = true;
            this.lblPlayerCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard.Location = new System.Drawing.Point(45, 64);
            this.lblPlayerCard.Name = "lblPlayerCard";
            this.lblPlayerCard.Size = new System.Drawing.Size(125, 25);
            this.lblPlayerCard.TabIndex = 6;
            this.lblPlayerCard.Text = "Player Card";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(584, 73);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(135, 25);
            this.lblPlayerScore.TabIndex = 7;
            this.lblPlayerScore.Text = "Player Score";
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerScore.Location = new System.Drawing.Point(584, 112);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(137, 25);
            this.lblDealerScore.TabIndex = 8;
            this.lblDealerScore.Text = "Dealer Score";
            // 
            // lblPcard2
            // 
            this.lblPcard2.AutoSize = true;
            this.lblPcard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcard2.Location = new System.Drawing.Point(264, 68);
            this.lblPcard2.Name = "lblPcard2";
            this.lblPcard2.Size = new System.Drawing.Size(18, 20);
            this.lblPcard2.TabIndex = 9;
            this.lblPcard2.Text = "?";
            // 
            // lblPcard1
            // 
            this.lblPcard1.AutoSize = true;
            this.lblPcard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcard1.Location = new System.Drawing.Point(210, 68);
            this.lblPcard1.Name = "lblPcard1";
            this.lblPcard1.Size = new System.Drawing.Size(18, 20);
            this.lblPcard1.TabIndex = 10;
            this.lblPcard1.Text = "?";
            // 
            // lblPcard3
            // 
            this.lblPcard3.AutoSize = true;
            this.lblPcard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcard3.Location = new System.Drawing.Point(318, 68);
            this.lblPcard3.Name = "lblPcard3";
            this.lblPcard3.Size = new System.Drawing.Size(18, 20);
            this.lblPcard3.TabIndex = 11;
            this.lblPcard3.Text = "?";
            // 
            // lblDcard1
            // 
            this.lblDcard1.AutoSize = true;
            this.lblDcard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDcard1.Location = new System.Drawing.Point(208, 106);
            this.lblDcard1.Name = "lblDcard1";
            this.lblDcard1.Size = new System.Drawing.Size(20, 24);
            this.lblDcard1.TabIndex = 12;
            this.lblDcard1.Text = "?";
            // 
            // lblDcard2
            // 
            this.lblDcard2.AutoSize = true;
            this.lblDcard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDcard2.Location = new System.Drawing.Point(262, 107);
            this.lblDcard2.Name = "lblDcard2";
            this.lblDcard2.Size = new System.Drawing.Size(20, 24);
            this.lblDcard2.TabIndex = 13;
            this.lblDcard2.Text = "?";
            // 
            // lblDcard3
            // 
            this.lblDcard3.AutoSize = true;
            this.lblDcard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDcard3.Location = new System.Drawing.Point(318, 106);
            this.lblDcard3.Name = "lblDcard3";
            this.lblDcard3.Size = new System.Drawing.Size(20, 24);
            this.lblDcard3.TabIndex = 14;
            this.lblDcard3.Text = "?";
            // 
            // lblPScore
            // 
            this.lblPScore.AutoSize = true;
            this.lblPScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPScore.Location = new System.Drawing.Point(752, 77);
            this.lblPScore.Name = "lblPScore";
            this.lblPScore.Size = new System.Drawing.Size(18, 20);
            this.lblPScore.TabIndex = 15;
            this.lblPScore.Text = "?";
            // 
            // lblDscore
            // 
            this.lblDscore.AutoSize = true;
            this.lblDscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDscore.Location = new System.Drawing.Point(752, 111);
            this.lblDscore.Name = "lblDscore";
            this.lblDscore.Size = new System.Drawing.Size(18, 20);
            this.lblDscore.TabIndex = 16;
            this.lblDscore.Text = "?";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(566, 317);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(24, 25);
            this.lblWinner.TabIndex = 17;
            this.lblWinner.Text = "?";
            // 
            // frm21simplified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 462);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblDscore);
            this.Controls.Add(this.lblPScore);
            this.Controls.Add(this.lblDcard3);
            this.Controls.Add(this.lblDcard2);
            this.Controls.Add(this.lblDcard1);
            this.Controls.Add(this.lblPcard3);
            this.Controls.Add(this.lblPcard1);
            this.Controls.Add(this.lblPcard2);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblPlayerCard);
            this.Controls.Add(this.lblDealerCards);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm21simplified";
            this.Text = "21 Simplified By Mohammed";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblDealerCards;
        private System.Windows.Forms.Label lblPlayerCard;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.Label lblPcard2;
        private System.Windows.Forms.Label lblPcard1;
        private System.Windows.Forms.Label lblPcard3;
        private System.Windows.Forms.Label lblDcard1;
        private System.Windows.Forms.Label lblDcard2;
        private System.Windows.Forms.Label lblDcard3;
        private System.Windows.Forms.Label lblPScore;
        private System.Windows.Forms.Label lblDscore;
        private System.Windows.Forms.Label lblWinner;
    }
}

