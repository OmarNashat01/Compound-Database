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
    public partial class Employee_Form_Temp : Form
    {
        Controller controllerObj;
        int DEP_NUM;
        public Employee_Form_Temp(int Dep_Id)
        {
            controllerObj = new Controller();
            DEP_NUM = Dep_Id;
            InitializeComponent();
        }

        private void Employee_Form_Temp_Load(object sender, EventArgs e)
        {
            Employee_label.Text = controllerObj.SelectDepName_From_ID(DEP_NUM);
        }

        private void View__Appointments_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Get_Appointments_all(DEP_NUM);

            if (dt == null)
                return;

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

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ResidenceIDTextBox.Text == "")
                return;

            string resid = ResidenceIDTextBox.Text;

            controllerObj.ClearAppointment(Global.depnum, resid);


        }
    }
}
