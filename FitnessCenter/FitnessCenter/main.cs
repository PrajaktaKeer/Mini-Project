using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenter
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (security.UserType == "CLIENT")
                MessageBox.Show("Access Denied!!", "CLIENTS cannot access these menu items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Admission f = new Admission();
                this.Hide();
                f.Show();
            }
        }

        private void employee_Click(object sender, EventArgs e)
        {
            if (security.UserType == "CLIENT" || security.UserType == "TRAINER")
                MessageBox.Show("Access Denied!!", "CLIENTS cannot access these menu items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Hide();
                emp_details e1 = new emp_details();
                e1.Show();
            }
        }

        private void offers_Click(object sender, EventArgs e)
        {
            this.Hide();
            offer o = new offer();
            o.Show();
        }

        private void users_Click(object sender, EventArgs e)
        {
            if (security.UserType == "CLIENT" || security.UserType == "TRAINER")
                MessageBox.Show("Access Denied!!", "CLIENTS cannot access these menu items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Users u = new Users();
                this.Hide();
                u.Show();
            }
        }

        private void nutrition_Click(object sender, EventArgs e)
        {
            if (security.UserType == "CLIENT")
                MessageBox.Show("Access Denied!!", "CLIENTS cannot access these menu items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Hide();
                nutri nt = new nutri();
                nt.Show();
            }
        }

        private void payments_Click(object sender, EventArgs e)
        {
            if (security.UserType == "CLIENT" || security.UserType == "TRAINER")
                MessageBox.Show("Access Denied!!", "CLIENTS AND TRAINERS cannot access these menu items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                payment p = new payment();
                this.Hide();
                p.Show();
            }
        }

        private void displayDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.UserType == "MANAGER")
            {
                this.Hide();
                manlogin mn = new manlogin();
                mn.Show();
            }
            else
                MessageBox.Show("Access Denied!!", "Other users cannot access these menu items", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void aTTENDANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attendance a = new attendance();
            this.Hide();
            a.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }
    }
}
