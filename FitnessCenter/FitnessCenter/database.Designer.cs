namespace FitnessCenter
{
    partial class database
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eMPLOYEEDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINCREDENTIALSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAYMENTDETAILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFFERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUTRITIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.aTTENDANCEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMPLOYEEDATAToolStripMenuItem,
            this.cLIENTDATAToolStripMenuItem,
            this.lOGINCREDENTIALSToolStripMenuItem,
            this.pAYMENTDETAILSToolStripMenuItem,
            this.eXITToolStripMenuItem,
            this.oFFERSToolStripMenuItem,
            this.nUTRITIONToolStripMenuItem,
            this.aTTENDANCEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eMPLOYEEDATAToolStripMenuItem
            // 
            this.eMPLOYEEDATAToolStripMenuItem.Name = "eMPLOYEEDATAToolStripMenuItem";
            this.eMPLOYEEDATAToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.eMPLOYEEDATAToolStripMenuItem.Text = "EMPLOYEE DATA";
            this.eMPLOYEEDATAToolStripMenuItem.Click += new System.EventHandler(this.eMPLOYEEDATAToolStripMenuItem_Click);
            // 
            // cLIENTDATAToolStripMenuItem
            // 
            this.cLIENTDATAToolStripMenuItem.Name = "cLIENTDATAToolStripMenuItem";
            this.cLIENTDATAToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.cLIENTDATAToolStripMenuItem.Text = "CLIENT DATA";
            this.cLIENTDATAToolStripMenuItem.Click += new System.EventHandler(this.cLIENTDATAToolStripMenuItem_Click);
            // 
            // lOGINCREDENTIALSToolStripMenuItem
            // 
            this.lOGINCREDENTIALSToolStripMenuItem.Name = "lOGINCREDENTIALSToolStripMenuItem";
            this.lOGINCREDENTIALSToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.lOGINCREDENTIALSToolStripMenuItem.Text = "LOGIN CREDENTIALS";
            this.lOGINCREDENTIALSToolStripMenuItem.Click += new System.EventHandler(this.lOGINCREDENTIALSToolStripMenuItem_Click);
            // 
            // pAYMENTDETAILSToolStripMenuItem
            // 
            this.pAYMENTDETAILSToolStripMenuItem.Name = "pAYMENTDETAILSToolStripMenuItem";
            this.pAYMENTDETAILSToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.pAYMENTDETAILSToolStripMenuItem.Text = "PAYMENT DETAILS";
            this.pAYMENTDETAILSToolStripMenuItem.Click += new System.EventHandler(this.pAYMENTDETAILSToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // oFFERSToolStripMenuItem
            // 
            this.oFFERSToolStripMenuItem.Name = "oFFERSToolStripMenuItem";
            this.oFFERSToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.oFFERSToolStripMenuItem.Text = "OFFERS";
            this.oFFERSToolStripMenuItem.Click += new System.EventHandler(this.oFFERSToolStripMenuItem_Click);
            // 
            // nUTRITIONToolStripMenuItem
            // 
            this.nUTRITIONToolStripMenuItem.Name = "nUTRITIONToolStripMenuItem";
            this.nUTRITIONToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.nUTRITIONToolStripMenuItem.Text = "NUTRITION";
            this.nUTRITIONToolStripMenuItem.Click += new System.EventHandler(this.nUTRITIONToolStripMenuItem_Click);
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 37);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(763, 401);
            this.dgv1.TabIndex = 1;
            // 
            // aTTENDANCEToolStripMenuItem
            // 
            this.aTTENDANCEToolStripMenuItem.Name = "aTTENDANCEToolStripMenuItem";
            this.aTTENDANCEToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.aTTENDANCEToolStripMenuItem.Text = "ATTENDANCE";
            this.aTTENDANCEToolStripMenuItem.Click += new System.EventHandler(this.aTTENDANCEToolStripMenuItem_Click);
            // 
            // database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "database";
            this.Text = "MANAGE DATABASE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.database_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEEDATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTDATAToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ToolStripMenuItem lOGINCREDENTIALSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAYMENTDETAILSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oFFERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUTRITIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTTENDANCEToolStripMenuItem;
    }
}