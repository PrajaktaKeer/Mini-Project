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
    public partial class nutri : Form
    {
        String cs = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\PRAJAKTA\VisualStudio\FitnessCenter\FitnessCenter\GymDb.mdf;Integrated Security=True";

        public nutri()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblage_Click(object sender, EventArgs e)
        {

        }

        private void lblht_Click(object sender, EventArgs e)
        {

        }

        private void lblgen_Click(object sender, EventArgs e)
        {

        }

        private void txtht_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtid.Text = " ";
            txtage.Text = " ";
            txtht.Text = " ";
            txtwt.Text = " ";
            cmb1.Text = "NULL";
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            chk5.Checked = false;
            rad1.Checked = false;
            rad2.Checked = false;
            radlun.Checked = false;
            rad3.Checked = false;
            rad4.Checked = false;
            rad7.Checked = false;
            rad8.Checked = false;
            raddin.Checked = false;

            txt1.Text = " ";
            cmb2.Text = "NULL";
            cmb3.Text = "NULL";
            cmb4.Text = "NULL";


            {
                MessageBox.Show("Enter new details", "Offers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection1 = new SqlConnection(cs);
            SqlConnection myConnection2 = new SqlConnection(cs);
            /*if ((string.IsNullOrWhiteSpace(cmb1.Text) || cmb1.Text == "NULL") && (string.IsNullOrWhiteSpace(cmb2.Text) || cmb2.Text == "NULL") && (string.IsNullOrWhiteSpace(cmb3.Text) || cmb3.Text == "NULL"))
            {
                MessageBox.Show("Please select proper choices", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(cmb1.Text) || cmb1.Text == "NULL")
            {
                MessageBox.Show("Please select gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(cmb2.Text) || cmb2.Text == "NULL")
            {
                MessageBox.Show("Please select BMI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            /*if ((string.IsNullOrWhiteSpace(cmb3.Text) || cmb3.Text == "NULL") || (string.IsNullOrWhiteSpace(cmb4.Text) || cmb4.Text == "NULL") || (txt1.Text == " ") || (txtid.Text == " ") || (txtage.Text == " ") || (txtht.Text == " ") || (txtwt.Text == " ") || (chk1.Checked == false && chk2.Checked == false && chk3.Checked == false && chk4.Checked == false && chk5.Checked == false) || (rad1.Checked == false && rad2.Checked == false) || (rad3.Checked == false && rad4.Checked == false) || (rad7.Checked == false && rad8.Checked == false) || (radlun.Checked == false && raddin.Checked == false))
            {
                MessageBox.Show("Please enter all inf", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            try
            {
                string str= " ";
                string str1 = " ";
                string str2= " ";
                string str3 = " ";
                string str4 = " ";
                if (chk1.Checked)
                {
                    str = chk1.Text;

                }
                if(chk2.Checked)
                {
                    str += "," + chk2.Text;
                }
                if (chk3.Checked)
                {
                    str += "," + chk3.Text;
                }
                if (chk4.Checked)
                {
                    str += "," + chk4.Text;
                }
                if (chk5.Checked)
                {
                    str += "," + chk5.Text;
                }
                if (rad1.Checked)
                {
                    str1 = rad1.Text;
                }
                else str1 = rad2.Text;

                if (rad3.Checked)
                {
                    str2 = rad3.Text;
                }
                else str2 = rad4.Text;

                if (rad7.Checked)
                {
                    str3 = rad7.Text;
                }
                else str3 = rad8.Text;

                if (radlun.Checked)
                {
                    str4 = radlun.Text;
                }
                else str4 = raddin.Text;

                string dat = "Insert into [Nutrition](Id,age,gender,height,weight,serious_illness,bmi,fluid_consu,no_of_eatings,ailments,smoking,dairy_pro_consu,special_diet,main_meal) Values( ' " + txtid.Text + "' ,'" + txtage.Text + "' ,'" + cmb1.SelectedItem + "' ,'" + txtht.Text + "' ,'" + txtwt.Text + "' ,'" + txt1.Text + "' ,'" + cmb2.SelectedItem + "' ,'" + cmb3.SelectedItem + "','" + cmb4.SelectedItem + "',@ailments,@smoking,@dairy,@diet,@meal)";
                SqlCommand com = new SqlCommand(dat, myConnection1);
                myConnection1.Open();
                com.Parameters.AddWithValue("@ailments", str);
                com.Parameters.AddWithValue("@smoking", str1);
                com.Parameters.AddWithValue("@dairy", str2);
                com.Parameters.AddWithValue("@diet", str3);
                com.Parameters.AddWithValue("@meal", str4);

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
                    //myConnection1 = new SqlConnection(cs);*/
                    //myConnection1.Open();
                    if (com.ExecuteNonQuery() > 0)
                    {
                        if ((!string.IsNullOrWhiteSpace(cmb3.Text) || cmb3.Text != "NULL") || !(string.IsNullOrWhiteSpace(cmb4.Text) || cmb4.Text != "NULL") || (txt1.Text != " ") || (txtid.Text != " ") || (txtage.Text != " ") || (txtht.Text != " ") || (txtwt.Text != " ") || (chk1.Checked != false && chk2.Checked != false && chk3.Checked != false && chk4.Checked != false && chk5.Checked != false) || (rad1.Checked != false && rad2.Checked != false) || (rad3.Checked != false && rad4.Checked != false) || (rad7.Checked != false && rad8.Checked != false) || (radlun.Checked != false && raddin.Checked != false))
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nutri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            main m = new main();
            this.Hide();
            m.Show();
        }
    }
}
