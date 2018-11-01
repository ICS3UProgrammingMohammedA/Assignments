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
            double subtotal, tax, total, sizeSelections, toppingSelection;


            const double XLARGE = 2;
            const double LARGE = 1;
            const double LARGEPRICE = 9.99;
            const double XLARGEPRICE = 12.99;
            const double FIRSTTOPPING = 0.75;
            const double SECONDTOPPING = 1.35;
            const double THIRDTOPPING = 2.15;
            const double FOURTHTOPPING = 2.75;




            sizeSelections = (double)nudSizeNum.Value;
            toppingSelection = (double)nudToppingNum.Value;


            subtotal = sizeSelections + toppingSelection;
            total = subtotal * 0.13 + subtotal;
            tax = subtotal * 0.13;

            lblSubtotalAnswer.Text = string.Format("${0:0.00}", subtotal);
            lblHSTAnswer.Text = string.Format("${0:0.00}", tax);
            lblTotalAnswer.Text = string.Format("${0:0.00}", total);


            if (sizeSelections == LARGE)
            {
                if (toppingSelection == FIRSTTOPPING)
                {
                    subtotal = LARGEPRICE + FIRSTTOPPING;
                    total = subtotal * 0.13 + subtotal;
                    tax = subtotal * 0.13;
                }
                else if (toppingSelection == SECONDTOPPING)
                {
                    subtotal = LARGEPRICE + SECONDTOPPING;
                    total = subtotal * 0.13 + subtotal;
                    tax = subtotal * 0.13;
                }
                else if (toppingSelection == THIRDTOPPING)
                {
                    subtotal = LARGEPRICE + THIRDTOPPING;
                    total = subtotal * 0.13 + subtotal;
                    tax = subtotal * 0.13;
                }
                else if (toppingSelection == FOURTHTOPPING)
                {
                    subtotal = LARGEPRICE + FOURTHTOPPING;
                    total = subtotal * 0.13 + subtotal;
                    total = subtotal * 0.13;
                }
                if (sizeSelections == XLARGE)
                {
                    if (toppingSelection == FIRSTTOPPING)
                    {
                        subtotal = XLARGEPRICE + FIRSTTOPPING;
                        total = subtotal * 0.13 + subtotal;
                    tax = subtotal * 0.13;
                    }
                    
                    }
                    else if (toppingSelection == SECONDTOPPING)
                    {
                        subtotal = XLARGEPRICE + SECONDTOPPING;
                        total = subtotal * 0.13 + subtotal;
                        tax = subtotal * 0.13;
                    }
                    else if (toppingSelection == THIRDTOPPING)
                    {
                        subtotal = XLARGEPRICE + THIRDTOPPING;
                        total = subtotal * 0.13 + subtotal;
                        tax = subtotal * 0.13;
                    }
                    else if (toppingSelection == FOURTHTOPPING)
                    {
                    subtotal = XLARGEPRICE + FOURTHTOPPING;
                    total = subtotal * 0.13 + subtotal;
                    tax = subtotal * 0.13;
                    }
                




                

            }

        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
            lblSubtotal.Show();
            lblTotal.Show();
            lblHST.Show();
            lblHSTAnswer.Show();
            lblSubtotalAnswer.Show();
            lblTotalAnswer.Show();
        }
    }

}