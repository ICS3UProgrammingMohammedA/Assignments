using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderMo
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double  subtotal, tax, total, sizeselections, topping;

            const double LARGE = 9.99;
            const double XLARGE = 12.99;
            const double FIRSTTOPPING = 0.75;
            const double SECONDTOPPING = 1.35;
            const double THIRDTOPPING = 2.15;
            const double FOURTHTOPPING = 2.75;
            


           sizeselections= (double)nudSizeNum.Value;


            topping= (double)nudToppingNum.Value;

            subtotal = sizeselections + topping;
           total = subtotal * 0.13 + subtotal;
            tax = subtotal * 0.13;

            lblSubtotalAnswer.Text = string.Format("${0:0.00}", subtotal);
            lblHSTAnswer.Text = string.Format("${0:0.00}", tax);
            lblTotalAnswer.Text = string.Format("${0:0.00}", total);




            lblSubtotal.Show();
            lblTotal.Show();
            lblHST.Show();
            lblHSTAnswer.Show();
            lblSubtotalAnswer.Show();
            lblTotalAnswer.Show();

        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
            lblSubtotal.Hide();
            lblTotal.Hide();
            lblHST.Hide();
            lblHSTAnswer.Hide();
            lblSubtotalAnswer.Hide();
            lblTotalAnswer.Hide();
        }
    }
}
