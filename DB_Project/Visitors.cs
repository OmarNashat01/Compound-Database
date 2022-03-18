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
    
    public partial class Visitors : Form
    {
        Controller controllerObj;
      
        public Visitors()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void ResidenceIDtextbox_Leave(object sender, EventArgs e)
        {
            if (ResidenceIDtextbox.Text == "")
            {
                MessageBox.Show("Please enter your Residence_ID");
                return;
            }

            int R_ID = int.Parse(ResidenceIDtextbox.Text);
            int chk = controllerObj.Check_Residence_ID(R_ID);//checks if the residence ID is in the database
            if (chk != 1)
            {
                MessageBox.Show("Please enter a valid Residence ID");
                ResidenceIDtextbox.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   if (ResidenceIDtextbox.Text==""||Visitorstextbox.Text=="")
            {
                MessageBox.Show("More data needed");
                return;
            }
            else {
                int result = controllerObj.Updatevisitors(Int32.Parse(ResidenceIDtextbox.Text), Int32.Parse(Visitorstextbox.Text));
                if (result == 0)
                {
                    MessageBox.Show("No rows are updated");
                }
                else
                {
                    MessageBox.Show("The row is updated successfully");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Residence_Owner_Form roform = new Residence_Owner_Form();
            roform.Show();
            this.Hide();
        }
    }
}
