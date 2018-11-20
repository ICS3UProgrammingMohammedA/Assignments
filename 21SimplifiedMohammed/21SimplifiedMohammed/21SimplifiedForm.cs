using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _21SimplifiedMohammed
{
    
    public partial class frm21simplified : Form
    {
        // random number genertaed
        Random randomNumber;
        //declaring global constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 10;
        //sound player
        private SoundPlayer bgsoundPlayer = new SoundPlayer();

        //declaring global variables
        int Pcard1 = 0;
        int Pcard2 = 0;
        int Dcard1 = 0;
        int Dcard2 = 0;
        int Pscore = 0;
        int Dscore = 0;
        int Pcard3 = 0;
        int Dcard3 = 0;

        public frm21simplified()
        {
            InitializeComponent();
            bgsoundPlayer = new SoundPlayer("Lounge　(short jazz).wav");
            bgsoundPlayer.Play();
            randomNumber = new Random();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            using (var frm21Simplified = new frm21simplified())
            {
                Visible = false;
                frm21Simplified.ShowDialog();
                Close();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            Pcard1 = randomNumber.Next(MIN_VALUE, MAX_VALUE + 1);
            lblPcard1.Text = Convert.ToString(Pcard1);

            Pcard2 = randomNumber.Next(MIN_VALUE, MAX_VALUE + 1);
            lblPcard2.Text = Convert.ToString(Pcard2);

            Pscore = Pcard1 + Pcard2;
            lblPScore.Text = Convert.ToString(Pscore);

            Dcard1 = randomNumber.Next(MIN_VALUE, MAX_VALUE + 1);
            lblDcard1.Text = Convert.ToString(Dcard1);

            Dcard2 = randomNumber.Next(MIN_VALUE, MAX_VALUE + 1);
            lblDcard2.Text = Convert.ToString(Dcard2);

            Dscore = Dcard1 + Dcard2;
            lblDscore.Text = Convert.ToString(Dscore);
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
          

            Pcard3 = randomNumber.Next(MIN_VALUE, MAX_VALUE + 1);
            lblPcard3.Text = Convert.ToString(Pcard3);

            Pscore = Pcard1 + Pcard2 + Pcard3;
            lblPScore.Text = Convert.ToString(Pscore);

            Dcard3 = randomNumber.Next(MIN_VALUE, MAX_VALUE + 1);
            lblDcard3.Text = Convert.ToString(Dcard3);

            Dscore = Dcard1 + Dcard2 + Dcard3;
            lblDscore.Text = Convert.ToString(Dscore);

            btnHit.Enabled = false;
            btnStart.Enabled = false;
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnHit.Enabled = false;

            //comparing the player score with the dealer score
            if (Pscore == Dscore)
                lblWinner.Text = " Dealer wins";
            else if (Pscore > Dscore)
                lblWinner.Text = " Player wins";
            else if (Pscore < Dscore)
                lblWinner.Text = "Dealer Wins";
            else if (Pscore == 21)
                lblWinner.Text = "Player wins";
            else if (Pscore > 21)
                lblWinner.Text = " Bust";
            else if (Dscore > 21)
                lblWinner.Text = " bust";
        }
    }
}
