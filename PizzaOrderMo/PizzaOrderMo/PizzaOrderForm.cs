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
            double subtotal=0, tax=0, total=0, sizeSelections, toppingSelection;

            // Declaring constants
            const double XLARGE = 2;
            const double LARGE = 1;
            const double FIRSTTOPPING = 1;
            const double SECONDTOPPING = 2;
            const double THIRDTOPPING = 3;
            const double FOURTHTOPPING = 4;
            const double LARGEPRICE = 9.99;
            const double XLARGEPRICE = 12.99;
            const double FIRSTTOPPINGPRICE = 0.75;
            const double SECONDTOPPINGPRICE = 1.35;
            const double THIRDTOPPINGPRICE = 2.15;
            const double FOURTHTOPPINGPRICE = 2.75;

            // getting the number for large or xlarge pizza from the user
            sizeSelections = (double)nudSizeNum.Value;

            //getting the number for the toppings from the user
            toppingSelection = (double)nudToppingNum.Value;


            // if the size selection is 1 which is large
            if (sizeSelections == LARGE)
            {
                //
                if (toppingSelection == FIRSTTOPPING)
                {
                    subtotal = LARGEPRICE + FIRSTTOPPINGPRICE;
                    total = subtotal * 0.13 + subtotal;
                    tax = subtotal * 0.13;
                }
                else if (toppingSelection == SECONDTOPPING)
                {
                    subtotal = LARGEPRICE + SECONDTOPPINGPRICE;
                    total = subtotal * 0.13 + subtotal;
                    tax = subtotal * 0.13;
                }
                else if (toppingSelection == THIRDTOPPING)
                {
                    subtotal = LARGEPRICE + THIRDTOPPINGPRICE;
                    total = subtotal * 0.13 + subtotal;
                    tax = subtotal * 0.13;
                }
                else if (toppingSelection == FOURTHTOPPING)
                {
                    subtotal = LARGEPRICE + FOURTHTOPPINGPRICE;
                    total = subtotal * 0.13 + subtotal;
                    total = subtotal * 0.13;
                }
            }
            // if the size selection is 2 which is Xlarge
            else if (sizeSelections == XLARGE)
            {
                if (toppingSelection == FIRSTTOPPING)
                {
                    subtotal = XLARGEPRICE + FIRSTTOPPINGPRICE;
                    total = subtotal * 0.13 + subtotal;
                    tax = subtotal * 0.13;
                }
                else if (toppingSelection == SECONDTOPPING)
                {
                    subtotal = XLARGEPRICE + SECONDTOPPINGPRICE;
                    total = subtotal * 0.13 + subtotal;
                    tax = subtotal * 0.13;
                }
                else if (toppingSelection == THIRDTOPPING)
                {
                    subtotal = XLARGEPRICE + THIRDTOPPINGPRICE;
                    total = subtotal * 0.13 + subtotal;
                    tax = subtotal * 0.13;
                }
                else if (toppingSelection == FOURTHTOPPING)
                {
                    subtotal = XLARGEPRICE + FOURTHTOPPINGPRICE;
                    total = subtotal * 0.13 + subtotal;
                    tax = subtotal * 0.13;
                }

            }

            //calculating the subtotal, total and tax
            subtotal = sizeSelections + toppingSelection;
                total = subtotal * 0.13 + subtotal;
                tax = subtotal * 0.13;

                //this code is to make the answer have the dollor sign
                lblSubtotalAnswer.Text = string.Format("${0:0.00}", subtotal);
                lblHSTAnswer.Text = string.Format("${0:0.00}", tax);
                lblTotalAnswer.Text = string.Format("${0:0.00}", total);

                //this code is to show the hidden labels
                lblSubtotal.Show();
                lblTotal.Show();
                lblHST.Show();
                lblHSTAnswer.Show();
                lblSubtotalAnswer.Show();
                lblTotalAnswer.Show();

            }

        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
           //this code is to hide the labels 
            lblSubtotal.Hide();
            lblTotal.Hide();
            lblHST.Hide();
            lblHSTAnswer.Hide();
            lblSubtotalAnswer.Hide();
            lblTotalAnswer.Hide();
        }
    

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {

        }
    }