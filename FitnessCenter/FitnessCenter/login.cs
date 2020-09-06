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
    public partial class Login : Form
    {
        //security UT;
        String cs = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\PRAJAKTA\VisualStudio\FitnessCenter\FitnessCenter\GymDb.mdf;Integrated Security=True";
       // String cs = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Jinx\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\MyDb.mdf;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void usertype_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ut.Text = "NONE";
            un.Text = "";
            pw.Text = "";
        }

        private void log_Click(object sender, EventArgs e)
        {
            //string username, password;
            //username = "prajakta";
            //password = "23269";

            if (string.IsNullOrWhiteSpace(un.Text))
            {
                MessageBox.Show("Please input proper Username...!");
            }
            if (string.IsNullOrWhiteSpace(ut.Text) || ut.Text == "NONE")
            {
                MessageBox.Show("Please input proper Usertype...!");
            }
            if (string.IsNullOrWhiteSpace(pw.Text))
            {
                MessageBox.Show("Please input proper Password...!");
            }
            /*else if ((un.Text == username) && (pw.Text == password) && ut.Text != "NONE")
            {
                //MessageBox.Show("Welcome" + "!");
                main frm = new main();
                this.Hide();
                frm.Show();
            }
            else if ((un.Text != username) && (pw.Text != password))
            {
                MessageBox.Show("Please input proper Username and/or Password...!");
            }*/
            
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT Username,Password,Usertype FROM Users WHERE Username = @Username AND Password = @Password AND Usertype = @Usertype", myConnection);

                SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);
                SqlParameter uType = new SqlParameter("@Usertype", SqlDbType.VarChar);

                uName.Value = un.Text;
                uPassword.Value = pw.Text;
                uType.Value = ut.Text;

                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);
                myCommand.Parameters.Add(uType);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true && ut.Text != "NONE")
                {
                    //UT.UserType = ut.Text;
                    security.UserType = ut.Text;
                    MessageBox.Show("You have logged in successfully " + un.Text);
                    main frm = new main();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    un.Clear();
                    pw.Clear();
                    un.Focus();
                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            ut.Text = "NONE";
        }
    }
}
