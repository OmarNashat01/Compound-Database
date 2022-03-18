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
    public partial class Subscribe_in_a_Service : Form
    {
        Controller controllerObj;
        int SELECTED_DEPARTMENT;
        public Subscribe_in_a_Service()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectDepName();
            Dep_combobox.DataSource = dt;
            Dep_combobox.DisplayMember = "Dname";

            

          








        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   if (Res_id.Text == "")
            {
                MessageBox.Show("enter residence ID");
                return;
            }

            int x = controllerObj.Check_Residence_ID(int.Parse(Res_id.Text));//x contains residence id in integer form
            if(x!=1)
            {
                MessageBox.Show("enter a valid residence ID");
                return;
            }

            if (Service_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a service type");
                return;

            }





            int SELECTED_SERVICE = controllerObj.SelectServiceID(Service_combobox.Text, SELECTED_DEPARTMENT);
            x = int.Parse(Res_id.Text);
            int chk = controllerObj.Add_subscription(SELECTED_DEPARTMENT, SELECTED_SERVICE, x);
            if(chk==0)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                MessageBox.Show("Subscription Successful");
            }




            




            

            

            
        }

        private void Service_combobox_MouseClick(object sender, MouseEventArgs e)
        {

            DataTable a = controllerObj.SelectDnumber(Dep_combobox.Text);
            string b = a.Rows[0][0].ToString();
            int c = int.Parse(b);
            SELECTED_DEPARTMENT = c;


            a = controllerObj.SelectDepServices(c);
            Service_combobox.DataSource = a;
            Service_combobox.DisplayMember = "Service_type";

        }

        private void Dep_combobox_Leave(object sender, EventArgs e)
        {
            

        }

        private void Dep_combobox_MouseClick(object sender, MouseEventArgs e)
        {
            Service_combobox.SelectedIndex = -1;
        }

        private void Dep_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Residence_Owner_Form p = new Residence_Owner_Form();
            p.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }
    }
}
