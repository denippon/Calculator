namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nPlus = new System.Windows.Forms.Button();
            this.nMinus = new System.Windows.Forms.Button();
            this.nDivided = new System.Windows.Forms.Button();
            this.nTimes = new System.Windows.Forms.Button();
            this.nClear = new System.Windows.Forms.Button();
            this.nBack = new System.Windows.Forms.Button();
            this.nEquals = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.nDot = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(302, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nPlus
            // 
            this.nPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nPlus.Location = new System.Drawing.Point(260, 187);
            this.nPlus.Name = "nPlus";
            this.nPlus.Size = new System.Drawing.Size(55, 53);
            this.nPlus.TabIndex = 1;
            this.nPlus.Text = "+";
            this.nPlus.UseVisualStyleBackColor = true;
            this.nPlus.Click += new System.EventHandler(this.nPlus_Click);
            // 
            // nMinus
            // 
            this.nMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nMinus.Location = new System.Drawing.Point(199, 187);
            this.nMinus.Name = "nMinus";
            this.nMinus.Size = new System.Drawing.Size(55, 53);
            this.nMinus.TabIndex = 2;
            this.nMinus.Text = "-";
            this.nMinus.UseVisualStyleBackColor = true;
            this.nMinus.Click += new System.EventHandler(this.nMinus_Click);
            // 
            // nDivided
            // 
            this.nDivided.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nDivided.Location = new System.Drawing.Point(260, 128);
            this.nDivided.Name = "nDivided";
            this.nDivided.Size = new System.Drawing.Size(55, 53);
            this.nDivided.TabIndex = 3;
            this.nDivided.Text = "/";
            this.nDivided.UseVisualStyleBackColor = true;
            this.nDivided.Click += new System.EventHandler(this.nDivided_Click);
            // 
            // nTimes
            // 
            this.nTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nTimes.Location = new System.Drawing.Point(199, 128);
            this.nTimes.Name = "nTimes";
            this.nTimes.Size = new System.Drawing.Size(55, 53);
            this.nTimes.TabIndex = 4;
            this.nTimes.Text = "*";
            this.nTimes.UseVisualStyleBackColor = true;
            this.nTimes.Click += new System.EventHandler(this.nTimes_Click);
            // 
            // nClear
            // 
            this.nClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nClear.Location = new System.Drawing.Point(260, 69);
            this.nClear.Name = "nClear";
            this.nClear.Size = new System.Drawing.Size(55, 53);
            this.nClear.TabIndex = 5;
            this.nClear.Text = "C";
            this.nClear.UseVisualStyleBackColor = true;
            this.nClear.Click += new System.EventHandler(this.nClear_Click);
            // 
            // nBack
            // 
            this.nBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nBack.Location = new System.Drawing.Point(199, 69);
            this.nBack.Name = "nBack";
            this.nBack.Size = new System.Drawing.Size(55, 53);
            this.nBack.TabIndex = 6;
            this.nBack.Text = "⇐";
            this.nBack.UseVisualStyleBackColor = true;
            this.nBack.Click += new System.EventHandler(this.nBack_Click);
            // 
            // nEquals
            // 
            this.nEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nEquals.Location = new System.Drawing.Point(135, 246);
            this.nEquals.Name = "nEquals";
            this.nEquals.Size = new System.Drawing.Size(55, 53);
            this.nEquals.TabIndex = 7;
            this.nEquals.Text = "=";
            this.nEquals.UseVisualStyleBackColor = true;
            this.nEquals.Click += new System.EventHandler(this.nEquals_Click);
            // 
            // n0
            // 
            this.n0.Location = new System.Drawing.Point(74, 246);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(55, 53);
            this.n0.TabIndex = 8;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // nDot
            // 
            this.nDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nDot.Location = new System.Drawing.Point(13, 246);
            this.nDot.Name = "nDot";
            this.nDot.Size = new System.Drawing.Size(55, 53);
            this.nDot.TabIndex = 9;
            this.nDot.Text = ".";
            this.nDot.UseVisualStyleBackColor = true;
            this.nDot.Click += new System.EventHandler(this.nDot_Click);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(13, 187);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(55, 53);
            this.n1.TabIndex = 10;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click_1);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(74, 187);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(55, 53);
            this.n2.TabIndex = 11;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(134, 187);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(55, 53);
            this.n3.TabIndex = 12;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(13, 128);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(55, 53);
            this.n4.TabIndex = 13;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(73, 128);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(55, 53);
            this.n5.TabIndex = 14;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(134, 128);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(55, 53);
            this.n6.TabIndex = 15;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(13, 69);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(55, 53);
            this.n7.TabIndex = 16;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(73, 69);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(55, 53);
            this.n8.TabIndex = 17;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(134, 69);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(55, 53);
            this.n9.TabIndex = 18;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 52);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.nDot);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.nEquals);
            this.Controls.Add(this.nBack);
            this.Controls.Add(this.nClear);
            this.Controls.Add(this.nTimes);
            this.Controls.Add(this.nDivided);
            this.Controls.Add(this.nMinus);
            this.Controls.Add(this.nPlus);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button nPlus;
        private System.Windows.Forms.Button nMinus;
        private System.Windows.Forms.Button nDivided;
        private System.Windows.Forms.Button nTimes;
        private System.Windows.Forms.Button nClear;
        private System.Windows.Forms.Button nBack;
        private System.Windows.Forms.Button nEquals;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button nDot;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

