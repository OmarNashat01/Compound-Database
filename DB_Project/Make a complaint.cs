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
    public partial class Make_a_complaint : Form
    {   Controller controllerObj;
        
        public Make_a_complaint()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectDepName();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Dname";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("More data needed");
                return;
            }
            else
            {
                //TODO: multi-lined complaints don't work
                DataTable a = controllerObj.SelectDnumber(comboBox1.Text);
                string b = a.Rows[0][0].ToString();
                int c = int.Parse(b);
                int result = controllerObj.InsertComplaint(Int32.Parse(textBox1.Text), c, textBox2.Text);
                if (result == 0)
                {
                    MessageBox.Show("Complaint wasn't submitted");
                }
                else
                {
                    MessageBox.Show("Complaint submitted successfully, thanks for your feedback!");
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {

            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your Residence_ID");
                return;
            }

            int R_ID = int.Parse(textBox1.Text);
            int chk = controllerObj.Check_Residence_ID(R_ID);//checks if the residence ID is in the database
            if (chk != 1)
            {
                MessageBox.Show("Please enter a valid Residence ID");
                textBox1.Clear();
            }


        }

        private void Make_a_complaint_Load(object sender, EventArgs e)
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
