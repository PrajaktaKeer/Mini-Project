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
    public partial class Admission : Form
    {
        String cs = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\PRAJAKTA\VisualStudio\FitnessCenter\FitnessCenter\GymDb.mdf;Integrated Security=True";
        public Admission()
        {
            InitializeComponent();
        }

        private void Admission_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Admission_Load(object sender, EventArgs e)
        {
            progchoose.Text = "NONE";
        }

        private void exit1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main f = new main();
            f.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(cs);
                SqlCommand myCommand = new SqlCommand("insert into Client (Program, FirstName, LastName, StreetAddress, City, State, Pincode, MobileNumber, Email, DateOfBirth, EmergencyContact, Promotions, MemberRefferal, MembershipPlan, PrepaidMembership, StartDate) values (@Program, @FirstName, @LastName, @StreetAddress, @City, @State, @Pincode, @MobileNumber, @Email, @DateOfBirth, @EmergencyContact, @Promotions, @MemberRefferal, @MembershipPlan, @PrepaidMembership, @StartDate)");
                myCommand.Connection = myConnection;
               // myCommand.Parameters.Add("@MemberId", memid.Text);
                myCommand.Parameters.Add("@Program", progchoose.Text);
                myCommand.Parameters.Add("@FirstName", fname.Text);
                myCommand.Parameters.Add("@LastName", lname.Text);
                myCommand.Parameters.Add("@StreetAddress", address.Text);
                myCommand.Parameters.Add("@City", city.Text);
                myCommand.Parameters.Add("@State", state.Text);
                myCommand.Parameters.Add("@Pincode", pcode.Text);
                myCommand.Parameters.Add("@MobileNumber", mno.Text);
                myCommand.Parameters.Add("@Email", emid.Text);
                myCommand.Parameters.Add("@DateOfBirth", dob.Value);
                myCommand.Parameters.Add("@EmergencyContact", econtact.Text);
                myCommand.Parameters.Add("@Promotions", pro.Text);
                myCommand.Parameters.Add("@MemberRefferal", memref.Text);
                if(family.Checked == true)
                    myCommand.Parameters.Add("@MembershipPlan", "family");
                if(single.Checked == true)
                    myCommand.Parameters.Add("@MembershipPlan", "single");
                myCommand.Parameters.Add("@PrepaidMembership", premem.Text);
                myCommand.Parameters.Add("@StartDate", sdate.Value);

                myConnection.Open();
                if (myCommand.ExecuteNonQuery() > 0)
                {
                    if(progchoose.Text != "NONE" && fname.Text != "" && lname.Text != "" && address.Text != "" && city.Text != "" && state.Text != "" && pcode.Text != "" && mno.Text != "" && emid.Text != "" && econtact.Text != "" && pro.Text != "" && premem.Text != "")
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

        private void nw_Click(object sender, EventArgs e)
        {
            progchoose.Text = "NONE";
            fname.Clear();
            lname.Clear();
            address.Clear();
            city.Clear();
            state.Clear();
            pcode.Clear();
            mno.Clear();
            emid.Clear();
            econtact.Clear();
            pro.Clear();
            memref.Clear();
            family.Checked = false;
            single.Checked = false;
            premem.Clear();
        }

        private void payment_Click(object sender, EventArgs e)
        {
            this.Hide();
            payment p = new payment();
            p.Show();
        }
    }
}
