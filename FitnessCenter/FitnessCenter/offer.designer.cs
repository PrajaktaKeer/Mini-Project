namespace FitnessCenter
{
    partial class offer
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
            this.lbloffer = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timeslot = new System.Windows.Forms.DateTimePicker();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.cmb3 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbloffer
            // 
            this.lbloffer.AutoSize = true;
            this.lbloffer.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloffer.Location = new System.Drawing.Point(79, 121);
            this.lbloffer.Name = "lbloffer";
            this.lbloffer.Size = new System.Drawing.Size(79, 37);
            this.lbloffer.TabIndex = 0;
            this.lbloffer.Text = "Offer";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(79, 272);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(157, 37);
            this.lbldesc.TabIndex = 1;
            this.lbldesc.Text = "Description";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(79, 198);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(125, 37);
            this.lbltime.TabIndex = 2;
            this.lbltime.Text = "TimeSlot";
            // 
            // cmb1
            // 
            this.cmb1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb1.Items.AddRange(new object[] {
            "NONE",
            "TRAINER",
            "MANAGER",
            "CLIENT",
            "FRONTDESK"});
            this.cmb1.Location = new System.Drawing.Point(348, 121);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 23);
            this.cmb1.TabIndex = 3;
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(52, 347);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(161, 56);
            this.btnnew.TabIndex = 4;
            this.btnnew.Text = "NEW";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(313, 347);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(161, 56);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.timeslot);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Controls.Add(this.cmb3);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.cmb1);
            this.panel1.Controls.Add(this.lbltime);
            this.panel1.Controls.Add(this.lbldesc);
            this.panel1.Controls.Add(this.lbloffer);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 453);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FitnessCenter.Properties.Resources.gymlogo1;
            this.pictureBox1.InitialImage = global::FitnessCenter.Properties.Resources.gymlogo;
            this.pictureBox1.Location = new System.Drawing.Point(578, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 125);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 56);
            this.button1.TabIndex = 11;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeslot
            // 
            this.timeslot.Location = new System.Drawing.Point(313, 211);
            this.timeslot.Name = "timeslot";
            this.timeslot.Size = new System.Drawing.Size(200, 20);
            this.timeslot.TabIndex = 10;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(348, 70);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(121, 20);
            this.txtid.TabIndex = 9;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(88, 70);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(98, 37);
            this.lblid.TabIndex = 8;
            this.lblid.Text = "Reg ID";
            // 
            // cmb3
            // 
            this.cmb3.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cmb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb3.Items.AddRange(new object[] {
            "NONE",
            "Workout",
            "Yoga",
            "Massage"});
            this.cmb3.Location = new System.Drawing.Point(348, 272);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(121, 23);
            this.cmb3.TabIndex = 7;
            // 
            // offer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "offer";
            this.Text = "OfferForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.offer_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbloffer;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DateTimePicker timeslot;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}