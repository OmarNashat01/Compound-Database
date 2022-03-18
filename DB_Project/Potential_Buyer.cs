using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class Potential_Buyer : Form
    {
        public Potential_Buyer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_forsale p = new View_forsale();
            p.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Services p = new View_Services();
            p.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }
    }
}
