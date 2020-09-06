namespace FitnessCenter
{
    partial class payment
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
            this.gymaddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regno = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.DateOfPayment = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.payselect = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cno = new System.Windows.Forms.TextBox();
            this.bank = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.pno = new System.Windows.Forms.TextBox();
            this.pay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.new1 = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gymaddress
            // 
            this.gymaddress.AutoSize = true;
            this.gymaddress.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymaddress.Location = new System.Drawing.Point(216, 23);
            this.gymaddress.Name = "gymaddress";
            this.gymaddress.Size = new System.Drawing.Size(247, 60);
            this.gymaddress.TabIndex = 0;
            this.gymaddress.Text = "Best Gym, 1st floor, Piccasso Arcade, \r\nSalunkhe Vihar Road, Pune 411048.  \r\nTele" +
    "phone No. 020-26450078 \r\nWebsite. www.bestgym.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Regestration Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // regno
            // 
            this.regno.Location = new System.Drawing.Point(579, 114);
            this.regno.Name = "regno";
            this.regno.Size = new System.Drawing.Size(100, 20);
            this.regno.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(223, 182);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 7;
            // 
            // DateOfPayment
            // 
            this.DateOfPayment.Location = new System.Drawing.Point(531, 83);
            this.DateOfPayment.Name = "DateOfPayment";
            this.DateOfPayment.Size = new System.Drawing.Size(200, 20);
            this.DateOfPayment.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Recieved with thanks from Mr./Ms.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "the sum of rupees";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(457, 182);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 20);
            this.sum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "only";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "By Cash/Cheque/Credit Card";
            // 
            // payselect
            // 
            this.payselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payselect.FormattingEnabled = true;
            this.payselect.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Credit Card",
            "None"});
            this.payselect.Location = new System.Drawing.Point(219, 221);
            this.payselect.Name = "payselect";
            this.payselect.Size = new System.Drawing.Size(121, 21);
            this.payselect.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cheque/Credit card  number";
            // 
            // cno
            // 
            this.cno.Location = new System.Drawing.Point(562, 222);
            this.cno.Name = "cno";
            this.cno.Size = new System.Drawing.Size(100, 20);
            this.cno.TabIndex = 16;
            // 
            // bank
            // 
            this.bank.Location = new System.Drawing.Point(114, 267);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(100, 20);
            this.bank.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Bank";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Email Id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(347, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Telephone Number";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(139, 311);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 23;
            // 
            // pno
            // 
            this.pno.Location = new System.Drawing.Point(502, 311);
            this.pno.Name = "pno";
            this.pno.Size = new System.Drawing.Size(100, 20);
            this.pno.TabIndex = 24;
            // 
            // pay
            // 
            this.pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.Location = new System.Drawing.Point(401, 383);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(119, 28);
            this.pay.TabIndex = 28;
            this.pay.Text = "PAYMENT";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FitnessCenter.Properties.Resources.gymlogo1;
            this.pictureBox1.InitialImage = global::FitnessCenter.Properties.Resources.gymlogo;
            this.pictureBox1.Location = new System.Drawing.Point(44, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 125);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(628, 383);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(119, 28);
            this.exit.TabIndex = 29;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // new1
            // 
            this.new1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new1.Location = new System.Drawing.Point(219, 383);
            this.new1.Name = "new1";
            this.new1.Size = new System.Drawing.Size(119, 28);
            this.new1.TabIndex = 30;
            this.new1.Text = "NEW";
            this.new1.UseVisualStyleBackColor = true;
            this.new1.Click += new System.EventHandler(this.new1_Click);
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(44, 383);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(119, 28);
            this.print.TabIndex = 31;
            this.print.Text = "PRINT";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.print);
            this.Controls.Add(this.new1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.pno);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.cno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.payselect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateOfPayment);
            this.Controls.Add(this.name);
            this.Controls.Add(this.regno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gymaddress);
            this.Name = "payment";
            this.Text = "payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.payment_FormClosing);
            this.Load += new System.EventHandler(this.payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gymaddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regno;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DateTimePicker DateOfPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox payselect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cno;
        private System.Windows.Forms.TextBox bank;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox pno;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button new1;
        private System.Windows.Forms.Button print;
    }
}