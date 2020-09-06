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
    public partial class attendance : Form
    {
        String cs = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\PRAJAKTA\VisualStudio\FitnessCenter\FitnessCenter\GymDb.mdf;Integrated Security=True";

        public attendance()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = 1;
            try
            {
                SqlConnection myConnection1 = new SqlConnection(cs);
                SqlConnection myConnection2 = new SqlConnection(cs);
                SqlCommand myCommand = new SqlCommand("insert into Attendance (RegNo, Attendance) values (@RegNo, @Attendance)");
                myCommand.Connection = myConnection1;
                myCommand.Parameters.Add("@RegNo", regno.Text);
                myCommand.Parameters.Add("@Attendance", r);
                /*SqlCommand myCommand2 = new SqlCommand("SELECT RegNo FROM Attendance WHERE RegNo = @RegNo", myConnection1);
                SqlDataReader data = myCommand.ExecuteReader();
                if (data.Read())
                {
                    int rno = data.GetValue(0).toInt();
                    txt.WriteLine("Reciept Number = " + rno);
                }*/
                //myCommand.Parameters.Add("@Attendance", @Attendance.getValue);

                SqlCommand myCommand1 = new SqlCommand("SELECT MemberId FROM Client WHERE MemberId = @MemberId", myConnection2);
                SqlParameter rno = new SqlParameter("@MemberId", SqlDbType.VarChar);
                rno.Value = regno.Text;
                myCommand1.Parameters.Add(rno);
                myConnection2.Open();
                SqlDataReader myReader = myCommand1.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader.Read())
                {
                    if (myConnection2.State == ConnectionState.Open)
                    {
                        myConnection2.Dispose();
                    }
                    myConnection1.Open();
                    if (myCommand.ExecuteNonQuery() > 0)
                    {
                        if (regno.Text != "")
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }
    }
}
