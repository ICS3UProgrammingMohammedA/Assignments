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
        // random number genertaed
        Random randomNumber;

        //sound player
        private SoundPlayer bgsoundPlayer = new SoundPlayer();

        public realGame()
        {
            InitializeComponent();
            bgsoundPlayer = new SoundPlayer("Lounge　(short jazz).wav");
            bgsoundPlayer.Play();
            randomNumber = new Random();
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
    }
}
