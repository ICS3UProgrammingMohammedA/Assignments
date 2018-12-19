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

namespace AbetterGame21Mo
{
    public partial class realGame : Form
    {
        //create an empty list of card images
        List<Image> listCardImages = new List<Image>();
        List<int> listCardValues = new List<int>();
        int hitcounter;
        Random cardIndexGen;
        int cards = 0;
        

        //sound player
        private SoundPlayer bgsoundPlayer = new SoundPlayer();

        public realGame()
        {
            InitializeComponent();
            bgsoundPlayer = new SoundPlayer("Lounge　(short jazz).wav");
            bgsoundPlayer.Play();
            cardIndexGen = new Random();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            using (var realGame = new frmABetterGame21())
            {
                Visible = false;
                realGame.ShowDialog();
                Close();
            }
        }

        private int DealCards(int total)
        {
            //declare local variables
            int card;
            int cardValue = 0;

            card = cardIndexGen.Next(0, listCardImages.Count());

            picPlayerCard1.Image = listCardImages[card];
            total += listCardValues[card];

            listCardImages.RemoveAt(card);
            listCardValues.RemoveAt(card);

            return total;
        }

        public void realGame_Load(object sender, EventArgs e)
        {
            

            //add card image to the list
            listCardImages.Add(Properties.Resources.AC);
            listCardImages.Add(Properties.Resources.AD);
            listCardImages.Add(Properties.Resources.AH);
            listCardImages.Add(Properties.Resources.AS);

            listCardImages.Add(Properties.Resources._2C);
            listCardImages.Add(Properties.Resources._2D);
            listCardImages.Add(Properties.Resources._2H);
            listCardImages.Add(Properties.Resources._2S);

            listCardImages.Add(Properties.Resources._3C);
            listCardImages.Add(Properties.Resources._3D);
            listCardImages.Add(Properties.Resources._3H);
            listCardImages.Add(Properties.Resources._3S);

            listCardImages.Add(Properties.Resources._4C);
            listCardImages.Add(Properties.Resources._4D);
            listCardImages.Add(Properties.Resources._4H);
            listCardImages.Add(Properties.Resources._4S);

            listCardImages.Add(Properties.Resources._5C);
            listCardImages.Add(Properties.Resources._5D);
            listCardImages.Add(Properties.Resources._5H);
            listCardImages.Add(Properties.Resources._5S);

            listCardImages.Add(Properties.Resources._6C);
            listCardImages.Add(Properties.Resources._6D);
            listCardImages.Add(Properties.Resources._6H);
            listCardImages.Add(Properties.Resources._6S);

            listCardImages.Add(Properties.Resources._7C);
            listCardImages.Add(Properties.Resources._7D);
            listCardImages.Add(Properties.Resources._7H);
            listCardImages.Add(Properties.Resources._7S);

            listCardImages.Add(Properties.Resources._8C);
            listCardImages.Add(Properties.Resources._8D);
            listCardImages.Add(Properties.Resources._8H);
            listCardImages.Add(Properties.Resources._8S);

            listCardImages.Add(Properties.Resources._9C);
            listCardImages.Add(Properties.Resources._9D);
            listCardImages.Add(Properties.Resources._9H);
            listCardImages.Add(Properties.Resources._9S);

            listCardImages.Add(Properties.Resources._10C); 
            listCardImages.Add(Properties.Resources._10D);
            listCardImages.Add(Properties.Resources._10H);
            listCardImages.Add(Properties.Resources._10S);

            listCardImages.Add(Properties.Resources.JC);
            listCardImages.Add(Properties.Resources.JD);
            listCardImages.Add(Properties.Resources.JH);
            listCardImages.Add(Properties.Resources.JS);

            listCardImages.Add(Properties.Resources.KC);
            listCardImages.Add(Properties.Resources.KD);
            listCardImages.Add(Properties.Resources.KH);
            listCardImages.Add(Properties.Resources.KS);

            listCardImages.Add(Properties.Resources.QC);
            listCardImages.Add(Properties.Resources.QD);
            listCardImages.Add(Properties.Resources.QH);
            listCardImages.Add(Properties.Resources.QS);

            //list of card values
            listCardValues.Add(1);
            listCardValues.Add(1);
            listCardValues.Add(1); 
            listCardValues.Add(1);

            listCardValues.Add(2);
            listCardValues.Add(2);
            listCardValues.Add(2);
            listCardValues.Add(2);

            listCardValues.Add(3);
            listCardValues.Add(3);
            listCardValues.Add(3);
            listCardValues.Add(3);

            listCardValues.Add(4);
            listCardValues.Add(4);
            listCardValues.Add(4);
            listCardValues.Add(4);

            listCardValues.Add(5);
            listCardValues.Add(5);
            listCardValues.Add(5);
            listCardValues.Add(5);

            listCardValues.Add(6);
            listCardValues.Add(6);
            listCardValues.Add(6);
            listCardValues.Add(6);

            listCardValues.Add(7);
            listCardValues.Add(7);
            listCardValues.Add(7);
            listCardValues.Add(7);

            listCardValues.Add(8);
            listCardValues.Add(8);
            listCardValues.Add(8);
            listCardValues.Add(8);

            listCardValues.Add(9);
            listCardValues.Add(9);
            listCardValues.Add(9);
            listCardValues.Add(9);

            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);

            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);

            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);

            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            DealCard(ref this.picPlayerCard3);
            DealCard(ref this.picDealerCard2);
            hitcounter++;
            btnHit.Enabled = false;
        }

        private int DealCard(ref PictureBox aPictureBox)
        {
            //declare local variables
            int cardindex;
            int cardValue;

            //this is the length of the list
            cardindex = cardIndexGen.Next(0, listCardImages.Count());

            //this displays the cards and there values
            cardValue = listCardValues[cardindex];
            
            // this removes the card from the deck
            listCardImages.RemoveAt(cardindex);
            listCardValues.RemoveAt(cardindex);

            return cardValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            {
                DealCard(ref this.picDealerCard1);
                DealCard(ref this.picPlayerCard1);
                DealCard(ref this.picPlayerCard2);
                btnStart.Hide();
            }
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            //lblTotalPlayer = DealCard();
        }
    }
}
