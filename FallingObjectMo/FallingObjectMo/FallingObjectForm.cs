/*
 * Created by: Mohammed Alnajeh
 * Created on: 2018-09-26
 * Created for: ICS3U Programming
 * Assignment #2 - Name of Program
 * This program...
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjectMo
{
    public partial class frmFallingObject : Form
    {
        public frmFallingObject()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
            double height;

            height = double.Parse(txtSeconds.Text);

            //this is to calculate the height 
            height = 100 - (0.5 * 9.81) * Math.Pow(height, 2);

            //this is to convert the text to string
            lblAnswer.Text = Convert.ToString(height);

            //this is to show the label
            this.lblAnswer.Show();
        }

        private void frmFallingObject_Load(object sender, EventArgs e)
        {
            //this is to hide the label
            this.lblAnswer.Hide();

        }
    }
}
