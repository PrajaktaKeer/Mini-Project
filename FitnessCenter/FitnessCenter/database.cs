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
    public partial class database : Form
    {
        public database()
        {
            InitializeComponent();
        }

        String cs = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\PRAJAKTA\VisualStudio\FitnessCenter\FitnessCenter\GymDb.mdf;Integrated Security=True";

        //String client = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PRAJAKTA\VisualStudio\FitnessCenter\FitnessCenter\clients.mdf;Integrated Security=True";
        //String employee = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PRAJAKTA\VisualStudio\FitnessCenter\FitnessCenter\employee.mdf;Integrated Security=True";
        //String login = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\PRAJAKTA\VisualStudio\FitnessCenter\FitnessCenter\Login1.mdf;Integrated Security=True";
        //String payment = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PRAJAKTA\VisualStudio\FitnessCenter\FitnessCenter\payment.mdf;Integrated Security=True";

        private void eMPLOYEEDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(cs))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Employee ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void cLIENTDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(cs))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Client ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void database_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lOGINCREDENTIALSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(cs))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Users ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void pAYMENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(cs))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Payment ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main m = new main();
            this.Hide();
            m.Show();
        }

        private void oFFERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(cs))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Offers ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void nUTRITIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(cs))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Nutrition ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void aTTENDANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(cs))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Attendance ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }
    }
}
