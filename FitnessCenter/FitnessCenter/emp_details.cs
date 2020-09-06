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
    public partial class emp_details : Form
    {
        String cs = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\PRAJAKTA\VisualStudio\FitnessCenter\FitnessCenter\GymDb.mdf;Integrated Security=True";
        public emp_details()
        {
            InitializeComponent();
        }

        private void new1_Click(object sender, EventArgs e)
        {
            emptype.Text = "NONE";
            name.Clear();
            address.Clear();
            pno.Clear();
            salary.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }

        private void emp_details_Load(object sender, EventArgs e)
        {
            emptype.Text = "NONE";
        }

        private void emp_details_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(cs);
                SqlCommand myCommand = new SqlCommand("insert into Employee (Name, DateOfJoin, Type, Address, PhoneNumber, Salary) values (@Name, @DateOfJoin, @Type, @Address, @PhoneNumber, @Salary)");
                myCommand.Connection = myConnection;
                //myCommand.Parameters.Add("@Empid", eid.Text);
                myCommand.Parameters.Add("@Name", name.Text);
                myCommand.Parameters.Add("@DateOfJoin", dateofjoin.Value);
                myCommand.Parameters.Add("@Type", emptype.Text);
                myCommand.Parameters.Add("@Address", address.Text);
                myCommand.Parameters.Add("@PhoneNumber", pno.Text);
                myCommand.Parameters.Add("@Salary", salary.Text);

                myConnection.Open();
                if (myCommand.ExecuteNonQuery() > 0)
                {
                    if (emptype.Text != "NONE" && name.Text != "" && address.Text != "" &&  pno.Text != "" && salary.Text != "" )
                        MessageBox.Show("Record inserted");
                    else
                        MessageBox.Show("A field entry is missing..");
                }
                else
                {
                    MessageBox.Show("Record failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during insert: " + ex.Message);
            }
        }
    }
}
