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
    public partial class manlogin : Form
    {
        public manlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(key.Text == "bestgym786")
            {
                database d = new database();
                d.Show();
                this.Hide();
            }
        }

        private void manlogin_FormClosing(object sender, FormClosingEventArgs e)
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
