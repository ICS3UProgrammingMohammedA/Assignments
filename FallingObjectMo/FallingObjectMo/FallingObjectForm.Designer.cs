namespace FallingObjectMo
{
    partial class frmFallingObject
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
            this.lblEnterTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblheight = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterTime
            // 
            this.lblEnterTime.AutoSize = true;
            this.lblEnterTime.Location = new System.Drawing.Point(80, 100);
            this.lblEnterTime.Name = "lblEnterTime";
            this.lblEnterTime.Size = new System.Drawing.Size(0, 13);
            this.lblEnterTime.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 88);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(568, 25);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Enter the time (in seconds)  since you released the object:";
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheight.Location = new System.Drawing.Point(12, 319);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(446, 25);
            this.lblheight.TabIndex = 2;
            this.lblheight.Text = "The height of the object above the ground is: ";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(497, 319);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(83, 25);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "Answer";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(605, 93);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(100, 20);
            this.txtSeconds.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(297, 187);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(126, 51);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmFallingObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 463);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblheight);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblEnterTime);
            this.Name = "frmFallingObject";
            this.Text = "Falling Object Mo";
            this.Load += new System.EventHandler(this.frmFallingObject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Button btnCalculate;
    }
}

