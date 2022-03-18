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
    public partial class Mark_for_sale : Form
    {
        Controller controllerObj;
        public Mark_for_sale()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your Residence_ID");
                return;
            }
            else
            { 

                int R_ID = int.Parse(textBox1.Text);
                int chk = controllerObj.Check_Residence_ID(R_ID);//checks if the residence ID is in the database
                if (chk != 1)
                {
                    MessageBox.Show("Please enter a valid Residence ID");
                    textBox1.Clear();
                    return;
                }



            }
            int y = 1;
            int result = controllerObj.Updatepropertyforsale(Int32.Parse(textBox1.Text), y);
            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }

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
