namespace PizzaOrderMo
{
    partial class frmPizzaOrder
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSelectSize = new System.Windows.Forms.Label();
            this.nudSizeNum = new System.Windows.Forms.NumericUpDown();
            this.lblLarge = new System.Windows.Forms.Label();
            this.lblXLarge = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.nudToppingNum = new System.Windows.Forms.NumericUpDown();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblHST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotalAnswer = new System.Windows.Forms.Label();
            this.lblHSTAnswer = new System.Windows.Forms.Label();
            this.lblTotalAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppingNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(703, 320);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(199, 39);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaOrderMo.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelectSize
            // 
            this.lblSelectSize.AutoSize = true;
            this.lblSelectSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSize.Location = new System.Drawing.Point(426, 29);
            this.lblSelectSize.Name = "lblSelectSize";
            this.lblSelectSize.Size = new System.Drawing.Size(418, 25);
            this.lblSelectSize.TabIndex = 2;
            this.lblSelectSize.Text = "Select the size of the pizza you would like:";
            // 
            // nudSizeNum
            // 
            this.nudSizeNum.Location = new System.Drawing.Point(850, 34);
            this.nudSizeNum.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSizeNum.Name = "nudSizeNum";
            this.nudSizeNum.Size = new System.Drawing.Size(47, 20);
            this.nudSizeNum.TabIndex = 3;
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarge.Location = new System.Drawing.Point(453, 72);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(156, 25);
            this.lblLarge.TabIndex = 4;
            this.lblLarge.Text = "LargePizza = 1";
            // 
            // lblXLarge
            // 
            this.lblXLarge.AutoSize = true;
            this.lblXLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXLarge.Location = new System.Drawing.Point(455, 107);
            this.lblXLarge.Name = "lblXLarge";
            this.lblXLarge.Size = new System.Drawing.Size(174, 25);
            this.lblXLarge.TabIndex = 5;
            this.lblXLarge.Text = "XLarge pizza = 2";
            // 
            // lblTopping
            // 
            this.lblTopping.AutoSize = true;
            this.lblTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopping.Location = new System.Drawing.Point(426, 151);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(406, 25);
            this.lblTopping.TabIndex = 6;
            this.lblTopping.Text = "Select how many topping you would like: ";
            // 
            // nudToppingNum
            // 
            this.nudToppingNum.Location = new System.Drawing.Point(838, 156);
            this.nudToppingNum.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudToppingNum.Name = "nudToppingNum";
            this.nudToppingNum.Size = new System.Drawing.Size(46, 20);
            this.nudToppingNum.TabIndex = 7;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(469, 211);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(93, 24);
            this.lblSubtotal.TabIndex = 8;
            this.lblSubtotal.Text = "Subtotal =";
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHST.Location = new System.Drawing.Point(469, 251);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(64, 24);
            this.lblHST.TabIndex = 9;
            this.lblHST.Text = "HST =";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(468, 293);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 25);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total = ";
            // 
            // lblSubtotalAnswer
            // 
            this.lblSubtotalAnswer.AutoSize = true;
            this.lblSubtotalAnswer.Location = new System.Drawing.Point(578, 219);
            this.lblSubtotalAnswer.Name = "lblSubtotalAnswer";
            this.lblSubtotalAnswer.Size = new System.Drawing.Size(13, 13);
            this.lblSubtotalAnswer.TabIndex = 11;
            this.lblSubtotalAnswer.Text = "?";
            // 
            // lblHSTAnswer
            // 
            this.lblHSTAnswer.AutoSize = true;
            this.lblHSTAnswer.Location = new System.Drawing.Point(556, 259);
            this.lblHSTAnswer.Name = "lblHSTAnswer";
            this.lblHSTAnswer.Size = new System.Drawing.Size(13, 13);
            this.lblHSTAnswer.TabIndex = 12;
            this.lblHSTAnswer.Text = "?";
            // 
            // lblTotalAnswer
            // 
            this.lblTotalAnswer.AutoSize = true;
            this.lblTotalAnswer.Location = new System.Drawing.Point(558, 302);
            this.lblTotalAnswer.Name = "lblTotalAnswer";
            this.lblTotalAnswer.Size = new System.Drawing.Size(13, 13);
            this.lblTotalAnswer.TabIndex = 13;
            this.lblTotalAnswer.Text = "?";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 371);
            this.Controls.Add(this.lblTotalAnswer);
            this.Controls.Add(this.lblHSTAnswer);
            this.Controls.Add(this.lblSubtotalAnswer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHST);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.nudToppingNum);
            this.Controls.Add(this.lblTopping);
            this.Controls.Add(this.lblXLarge);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.nudSizeNum);
            this.Controls.Add(this.lblSelectSize);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order By Mohammed";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppingNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSelectSize;
        private System.Windows.Forms.NumericUpDown nudSizeNum;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.Label lblXLarge;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.NumericUpDown nudToppingNum;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblHST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotalAnswer;
        private System.Windows.Forms.Label lblHSTAnswer;
        private System.Windows.Forms.Label lblTotalAnswer;
    }
}

