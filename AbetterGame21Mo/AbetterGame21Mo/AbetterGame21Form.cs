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
    public partial class frmABetterGame21 : Form
    {
        // random number genertaed
        Random randomNumber;

        //sound player
        private SoundPlayer bgsoundPlayer = new SoundPlayer();

        public frmABetterGame21()
        {
            InitializeComponent();
            bgsoundPlayer = new SoundPlayer("Lounge　(short jazz).wav");
            bgsoundPlayer.Play();
            randomNumber = new Random();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            using (var frmABetterGame21 = new realGame())
            {
                Visible = false;
                frmABetterGame21.ShowDialog();
                Close();
            }
        }
    }
}
