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
    
    public partial class Admin_Form_temp : Form
    {
        Controller controllerObj;
        int DEP_NUM;
        public Admin_Form_temp(int Dep_nnum)
        {
            DEP_NUM = Dep_nnum;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void View_Subsciptions_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Get_Subscribed_Services_all(DEP_NUM);
           
            dt.Columns.Add("Service type", typeof(string));
            foreach(DataRow row in dt.Rows)
            {
                DataTable x = controllerObj.SelectSerName_From_ID(int.Parse(row[0].ToString()),DEP_NUM);
                row[2]=x.Rows[0][0] ;


            }
            dt.Columns.RemoveAt(0);
            Gardening_Datagrid.DataSource = dt;
            Gardening_Datagrid.Refresh();



        }

        private void Admin_Form_temp_Load(object sender, EventArgs e)
        {
            Dep_label.Text = controllerObj.SelectDepName_From_ID(DEP_NUM);
        }

        private void View__Appointments_btn_Click(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.Get_Appointments_all(DEP_NUM);

            dt.Columns.Add("Service type", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                DataTable x = controllerObj.SelectSerName_From_ID(int.Parse(row[0].ToString()), DEP_NUM);
                row[4] = x.Rows[0][0];


            }
            dt.Columns.RemoveAt(0);
            Gardening_Datagrid.DataSource = dt;
            Gardening_Datagrid.Refresh();




        }

        private void View_Complaints_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Get_Complaints_all(DEP_NUM);
            Gardening_Datagrid.DataSource = dt;
            Gardening_Datagrid.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }
    }
}
