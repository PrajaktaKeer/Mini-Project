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
using System.IO;

namespace FitnessCenter
{
    public partial class payment : Form
    {
        String cs = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\PRAJAKTA\VisualStudio\FitnessCenter\FitnessCenter\GymDb.mdf;Integrated Security=True";
        public payment()
        {
            InitializeComponent();
        }

        private void payment_Load(object sender, EventArgs e)
        {
            payselect.Text = "NONE";
        }

        private void payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }

        private void new1_Click(object sender, EventArgs e)
        {
            regno.Clear();
            name.Clear();
            sum.Clear();
            payselect.Text = "NONE";
            cno.Clear();
            bank.Clear();
            email.Clear();
            pno.Clear();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection1 = new SqlConnection(cs);
                SqlConnection myConnection2 = new SqlConnection(cs);
                SqlCommand myCommand = new SqlCommand("insert into Payment (Name, RegNo, DateOfPayment, Sum, ModeOfPayment, Cheque_CreditNo, BankName, EmailId, PhoneNumber) values (@Name, @RegNo, @DateOfPayment, @Sum, @ModeOfPayment, @Cheque_CreditNo, @BankName, @EmailId, @PhoneNumber)", myConnection1);
                //myCommand.Connection = myConnection;
                myCommand.Parameters.Add("@Name", name.Text);
                myCommand.Parameters.Add("@RegNo", regno.Text);
                myCommand.Parameters.Add("@DateOfPayment", DateOfPayment.Value);
                myCommand.Parameters.Add("@Sum", sum.Text);
                myCommand.Parameters.Add("@ModeOfPayment", payselect.Text);
                myCommand.Parameters.Add("@Cheque_CreditNo", cno.Text);
                myCommand.Parameters.Add("@BankName", bank.Text);
                myCommand.Parameters.Add("@EmailId", email.Text);
                myCommand.Parameters.Add("@PhoneNumber", pno.Text);

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
                    //SqlConnection myConnection1 = new SqlConnection(cs);
                    //myConnection1 = new SqlConnection(cs);
                    myConnection1.Open();
                    if (myCommand.ExecuteNonQuery() > 0)
                    {
                        if (payselect.Text != "NONE" && name.Text != "" && regno.Text != "" && sum.Text != "" && cno.Text != "" && bank.Text != "" && email.Text != "" && pno.Text != "")
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

        private void print_Click(object sender, EventArgs e)
        {
            String filename, rno;
            SqlConnection myConnection = new SqlConnection(cs);
            do
            {
                filename = Microsoft.VisualBasic.Interaction.InputBox("Enter file name", "FILE NAME", "file.txt");
                if (filename == "")
                    MessageBox.Show("Please enter filename!!");
            } while (filename == "");
            TextWriter txt = new StreamWriter("E:\\PRAJAKTA\\VisualStudio\\" + filename);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT * FROM Payment where RecieptNo =(Select Max(RecieptNo) from Payment)", myConnection);
            //SqlParameter rno = new SqlParameter("@RecieptNo", SqlDbType.VarChar);
            SqlDataReader data = myCommand.ExecuteReader();
            if (data.Read())
            {
                 rno = data.GetValue(0).ToString();
                txt.WriteLine("Reciept Number = " + rno);
            }

            txt.WriteLine("\nDATE = " + DateOfPayment.Value);
            txt.WriteLine("\nREG NO = " + regno.Text);
            txt.WriteLine("\nNAME = " + name.Text);
            txt.WriteLine("\nSUM = " + sum.Text);
            txt.WriteLine("\nMODE OF PAYMENT = " + payselect.Text);
            txt.Close();
        }
    }
}
