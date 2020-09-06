using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenter
{
    public partial class offer : Form
    {
        
        public offer()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmb1.Text = "NONE";
            cmb3.Text = "NONE";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            cmb1.Text = "NONE";
            cmb3.Text = "NONE";
            {
                MessageBox.Show("Enter Details of new Entry", "Offers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            String cs = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\PRAJAKTA\VisualStudio\FitnessCenter\FitnessCenter\GymDb.mdf;Integrated Security=True";
            try
            {
                SqlConnection myConnection1 = new SqlConnection(cs);
                SqlConnection myConnection2 = new SqlConnection(cs);
                SqlCommand myCommand = new SqlCommand("insert into Offers (RegNo, Offer, TimeSlot, Description) values (@RegNo, @Offer, @TimeSlot, @Description)");
                myCommand.Connection = myConnection1;
                myCommand.Parameters.Add("@RegNo", txtid.Text);
                myCommand.Parameters.Add("@Offer", cmb1.Text);
                myCommand.Parameters.Add("@TimeSlot", timeslot.Value);
                myCommand.Parameters.Add("@Description", cmb3.Text);

                SqlCommand myCommand1 = new SqlCommand("SELECT MemberId FROM Client WHERE MemberId = @MemberId", myConnection2);
                SqlParameter rno = new SqlParameter("@MemberId", SqlDbType.VarChar);
                rno.Value = txtid.Text;
                myCommand1.Parameters.Add(rno);
                myConnection2.Open();
                SqlDataReader myReader = myCommand1.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader.Read())
                {
                    if (myConnection2.State == ConnectionState.Open)
                    {
                        myConnection2.Dispose();
                    }
                    //SqlConnection myConnection1 = new SqlConnection(cs);
                    //myConnection1 = new SqlConnection(cs);
                    myConnection1.Open();
                    if (myCommand.ExecuteNonQuery() > 0)
                    {
                            if (cmb1.Text != "NONE" && txtid.Text != "" && cmb3.Text != "NONE")
                                MessageBox.Show("Record inserted");
                            else
                                MessageBox.Show("A field entry is missing..");
                    }
                    else
                    {
                        MessageBox.Show("Record failed");
                    }
                }
                else
                {
                    MessageBox.Show("Client With that regestration number does not exist..");
                }
                if (myConnection2.State == ConnectionState.Open)
                {
                    myConnection2.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during insert: " + ex.Message);
            }

        }

        private void offer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }
    }  
}
