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
    public partial class Admin_Selector : Form
    {
        public Admin_Selector()
        {
            InitializeComponent();
        }

        private void Maintainance_Admin_btn_Click(object sender, EventArgs e)
        {
            Admin_Form_temp p = new Admin_Form_temp(4);
            p.Show();
            this.Hide();
        }

        private void Gardening_Admin_btn_Click(object sender, EventArgs e)
        {
            Admin_Form_temp p = new Admin_Form_temp(7);
            p.Show();
            this.Hide();
        }

        private void Gym_Admin_btn_Click(object sender, EventArgs e)
        {
            Admin_Form_temp p = new Admin_Form_temp(1);
            p.Show();
            this.Hide();
        }

        private void Spa_Admin_btn_Click(object sender, EventArgs e)
        {
            Admin_Form_temp p = new Admin_Form_temp(2);
            p.Show();
            this.Hide();
        }

        private void Cleaning_Admin_btn_Click(object sender, EventArgs e)
        {
            Admin_Form_temp p = new Admin_Form_temp(5);
            p.Show();
            this.Hide();
        }

        private void Laundry_Admin_btn_Click(object sender, EventArgs e)
        {
            Admin_Form_temp p = new Admin_Form_temp(6);
            p.Show();
            this.Hide();
        }

        private void Security_Admin_btn_Click(object sender, EventArgs e)
        {
            Security_Admin p = new Security_Admin();
            p.Show();
            this.Hide();
        }
    }
}
