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
    public partial class Security_Admin : Form
    {
        Controller controllerObj;
        DataTable DT;
        public Security_Admin()
        {
            
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Security_Admin_Load(object sender, EventArgs e)
        {
            DT = controllerObj.Get_Visitors_all();
            Visitors_datagrid.DataSource = DT;
            Visitors_datagrid.Refresh();

        }

        private void Mark_As_Left_btn_Click(object sender, EventArgs e)
        {
            if (Residence_ID_textbox.Text == "")
            {
                MessageBox.Show("Please enter your Residence_ID");
                return;
            }

            int R_ID = int.Parse(Residence_ID_textbox.Text);
           
            


            int x = 0;

            foreach(DataRow row in DT.Rows)
            {
                if(int.Parse(row[0].ToString())==R_ID)
                {
                    x = 1;
                }

            }

            if(x==0)
            {
                MessageBox.Show("Please enter a valid Residence ID");

                Residence_ID_textbox.Clear();
                Residence_ID_textbox.Focus();
                return;
            }


            int chk = controllerObj.Updatevisitors(R_ID, 0);

            MessageBox.Show("Marked visitors of residence " + R_ID + " as left.");



            DT = controllerObj.Get_Visitors_all();
            Visitors_datagrid.DataSource = DT;
            Visitors_datagrid.Refresh();





        }

        private void Show_Emergency_btn_Click(object sender, EventArgs e)
        {

            DT = controllerObj.Get_Emergency_all();
            Visitors_datagrid.DataSource = DT;
            Visitors_datagrid.Refresh();


        }

        private void Show_Visitors_btn_Click(object sender, EventArgs e)
        {
            DT = controllerObj.Get_Visitors_all();
            Visitors_datagrid.DataSource = DT;
            Visitors_datagrid.Refresh();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }
    }
}
