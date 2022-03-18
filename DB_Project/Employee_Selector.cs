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
    public partial class Employee_Selector : Form
    {
        public Employee_Selector()
        {
            InitializeComponent();
        }

        private void Maintainance_Emp_btn_Click(object sender, EventArgs e)
        {
            Employee_Form_Temp p = new Employee_Form_Temp(4);
            p.Show();
            this.Hide();
        }

        private void Gardening_Emp_btn_Click(object sender, EventArgs e)
        {

            Employee_Form_Temp p = new Employee_Form_Temp(7);
            p.Show();
            this.Hide();
        }

        private void Gym_Emp_btn_Click(object sender, EventArgs e)
        {

            Employee_Form_Temp p = new Employee_Form_Temp(1);
            p.Show();
            this.Hide();
        }

        private void Spa_Emp_btn_Click(object sender, EventArgs e)
        {

            Employee_Form_Temp p = new Employee_Form_Temp(2);
            p.Show();
            this.Hide();
        }

        private void Cleaning_Emp_btn_Click(object sender, EventArgs e)
        {

            Employee_Form_Temp p = new Employee_Form_Temp(5);
            p.Show();
            this.Hide();
        }

        private void Laundry_Emp_btn_Click(object sender, EventArgs e)
        {

            Employee_Form_Temp p = new Employee_Form_Temp(6);
            p.Show();
            this.Hide();
        }

        private void Security_Emp_btn_Click(object sender, EventArgs e)
        {

            Security_Admin p = new Security_Admin();
            p.Show();
            this.Hide();
        }
    }
}
