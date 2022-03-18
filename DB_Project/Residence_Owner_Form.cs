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
    public partial class Residence_Owner_Form : Form
    {
        public Residence_Owner_Form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subscribe_in_a_Service r = new Subscribe_in_a_Service();
            r.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Make_a_complaint p =new  Make_a_complaint();
            p.Show();
            Visible = false;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visitors p = new Visitors();
            p.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mark_for_sale p = new Mark_for_sale();
            p.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Appointment_Booking p = new Appointment_Booking();
            p.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }
    }
}
