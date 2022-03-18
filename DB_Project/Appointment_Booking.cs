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
    public partial class Appointment_Booking : Form
    {
        Controller controllerObj;
        int DEP_NUM;
        public Appointment_Booking()
        {
            InitializeComponent();
           
            controllerObj = new Controller();
        }

        private void Appointment_Booking_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void Residence_ID_textbox_TextChanged(object sender, EventArgs e)
        {
            Department_combobox.SelectedIndex = -1;
            Service_combobox.SelectedIndex = -1;
        }

        private void Residence_ID_textbox_Leave(object sender, EventArgs e)
        {
            //Department_combobox.SelectedIndex = -1;
            //Service_combobox.SelectedIndex = -1;
            //if (Residence_ID_textbox.Text == "")
            //{
            //    MessageBox.Show("Please enter your Residence_ID");
            //    return;
            //}

            //int R_ID = int.Parse(Residence_ID_textbox.Text);
            //int chk = controllerObj.Check_Residence_ID(R_ID);//checks if the residence ID is in the database
            //if (chk != 1)
            //{
            //    MessageBox.Show("Please enter a valid Residence ID");
            //    Residence_ID_textbox.Clear();

            //    return;
            //}

    





        }

        private void Department_combobox_MouseClick(object sender, MouseEventArgs e)
        {

            Department_combobox.SelectedIndex = -1;
            Service_combobox.SelectedIndex = -1;
            if (Residence_ID_textbox.Text == "")
            {
                MessageBox.Show("Please enter your Residence_ID");
                return;
            }

            int R_ID = int.Parse(Residence_ID_textbox.Text);
            int chk = controllerObj.Check_Residence_ID(R_ID);//checks if the residence ID is in the database
            if (chk != 1)
            {
                MessageBox.Show("Please enter a valid Residence ID");
                Residence_ID_textbox.Clear();

                return;
            }




            /////////////////////////////////////////////////////////////////////////////
            Service_combobox.Items.Clear() ;

            Department_combobox.Items.Clear();

            if (Residence_ID_textbox.Text == "")
            {
                MessageBox.Show("Please enter your Residence_ID first");
                return;
            }


            DataTable Sub_Dep = controllerObj.Get_Subscribed_Departments(int.Parse(Residence_ID_textbox.Text));
            if (Sub_Dep==null)
            {
                MessageBox.Show("This Residence isn't subscribed in any services");
                return;
            }
          
            foreach (DataRow row in Sub_Dep.Rows)
            {
                int x = int.Parse(row[0].ToString());
                string Sub_Alpha= controllerObj.SelectDepName_From_ID(x);
                Department_combobox.Items.Add (Sub_Alpha);
            }



        }

        private void Service_combobox_MouseClick(object sender, MouseEventArgs e)
        {
            Service_combobox.Items.Clear();

            if (Department_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose department first");
                return;
            }

             DEP_NUM = controllerObj.getdepid(Department_combobox.Text);
            DataTable Sub_Ser = controllerObj.Get_Subscribed_Services(int.Parse(Residence_ID_textbox.Text),DEP_NUM);
            if (Sub_Ser == null)
            {
                MessageBox.Show("This Residence isn't subscribed in any services ");
                return;
            }

            foreach (DataRow row in Sub_Ser.Rows)
            {
                int x = int.Parse(row[0].ToString());
                DataTable Sub_Alpha = controllerObj.SelectSerName_From_ID(x,DEP_NUM);
                Service_combobox.Items.Add(Sub_Alpha.Rows[0][0].ToString());
            }








        }

        private void Submit_Appointment_Button_Click(object sender, EventArgs e)
        {

            if(Residence_ID_textbox.Text==""||Department_combobox.Text==""||Service_combobox.Text=="")
            {
                MessageBox.Show("plaes fill out all the fields");
                return;
            }



            int SUR_NUM = controllerObj.getSerid(Service_combobox.Text);

            int x = controllerObj.Add_Appointment(DEP_NUM, SUR_NUM, int.Parse(Residence_ID_textbox.Text), Appointment_Date_Picker.Value, Appointment_Time_Picker.Value);

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Residence_Owner_Form p = new Residence_Owner_Form();
            p.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }
    }
}
