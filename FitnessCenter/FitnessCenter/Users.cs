using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FitnessCenter
{
    public partial class Users : Form
    {
        String cs = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\PRAJAKTA\VisualStudio\FitnessCenter\FitnessCenter\GymDb.mdf;Integrated Security=True";
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            ut.Text = "NONE";
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void New_Click(object sender, EventArgs e)
        {
            ut.Text = "NONE";
            un.Clear();
            pw.Clear();
            cpw.Clear();
            ut.Focus();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            main f = new main();
            f.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(cs);
                SqlCommand myCommand = new SqlCommand("insert into Users (Username, Password, Usertype) values (@Username, @Password, @Usertype)");
                myCommand.Connection = myConnection;
                if (pw.Text != cpw.Text)
                    MessageBox.Show("Both the password fields must contain same values.");
                if (pw.Text == cpw.Text && pw.Text != "" && cpw.Text != "")
                    myCommand.Parameters.Add("@Password", cpw.Text);
                myCommand.Parameters.Add("@Username", un.Text);
                myCommand.Parameters.Add("@Usertype", ut.Text);
                myConnection.Open();
                if (myCommand.ExecuteNonQuery() > 0)
                {
                    if (ut.Text != "NONE" && un.Text != "" && pw.Text != "" && cpw.Text != "" && pw.Text == cpw.Text)
                        MessageBox.Show("User Created Successfully!!");
                    else if(ut.Text == "NONE" || un.Text == "" || pw.Text == "" || cpw.Text == "")
                        MessageBox.Show("A field entry is missing..");
                }
                else
                {
                    MessageBox.Show("Record failed");
                    ut.Text = "NONE";
                    un.Clear();
                    pw.Clear();
                    cpw.Clear();
                    ut.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during insert: " + ex.Message);
            }
        }
    }
}
