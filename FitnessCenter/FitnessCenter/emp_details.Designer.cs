namespace FitnessCenter
{
    partial class emp_details
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
            this.dateofjoin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.emptype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pno = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.new1 = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateofjoin
            // 
            this.dateofjoin.Location = new System.Drawing.Point(177, 61);
            this.dateofjoin.Name = "dateofjoin";
            this.dateofjoin.Size = new System.Drawing.Size(200, 20);
            this.dateofjoin.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Of Joining";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(177, 173);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 5;
            // 
            // emptype
            // 
            this.emptype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emptype.FormattingEnabled = true;
            this.emptype.Items.AddRange(new object[] {
            "EMPLOYEE",
            "TRAINER",
            "FRONTDESK",
            "NONE"});
            this.emptype.Location = new System.Drawing.Point(130, 126);
            this.emptype.Name = "emptype";
            this.emptype.Size = new System.Drawing.Size(121, 21);
            this.emptype.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(130, 219);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(470, 20);
            this.address.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Salary";
            // 
            // pno
            // 
            this.pno.Location = new System.Drawing.Point(168, 270);
            this.pno.Name = "pno";
            this.pno.Size = new System.Drawing.Size(100, 20);
            this.pno.TabIndex = 12;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(151, 320);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(100, 20);
            this.salary.TabIndex = 13;
            // 
            // new1
            // 
            this.new1.BackColor = System.Drawing.Color.Teal;
            this.new1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new1.Location = new System.Drawing.Point(47, 392);
            this.new1.Name = "new1";
            this.new1.Size = new System.Drawing.Size(75, 32);
            this.new1.TabIndex = 14;
            this.new1.Text = "NEW";
            this.new1.UseVisualStyleBackColor = false;
            this.new1.Click += new System.EventHandler(this.new1_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Teal;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(302, 392);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(87, 32);
            this.submit.TabIndex = 15;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Teal;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(554, 392);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 32);
            this.exit.TabIndex = 16;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FitnessCenter.Properties.Resources.gymlogo1;
            this.pictureBox1.InitialImage = global::FitnessCenter.Properties.Resources.gymlogo;
            this.pictureBox1.Location = new System.Drawing.Point(575, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 125);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // emp_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.new1);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.pno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emptype);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateofjoin);
            this.Name = "emp_details";
            this.Text = "EMPLOYEE DETAILS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.emp_details_FormClosing);
            this.Load += new System.EventHandler(this.emp_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateofjoin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox emptype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pno;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Button new1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}