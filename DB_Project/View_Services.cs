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
    public partial class View_Services : Form
    {
        Controller controllerObj;
        public View_Services()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dt = controllerObj.SelectDepName();
            Dep_combobox.DataSource = dt;
            Dep_combobox.DisplayMember = "Dname";

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void View_Services_Load(object sender, EventArgs e)
        {

            int DEP_NUM = controllerObj.getdepid(Dep_combobox.Text);

            DataTable dt = controllerObj.get_service_type(DEP_NUM);

            

           


            Services_Grid.DataSource = dt;
            Services_Grid.Refresh();


        }

        private void Dep_combobox_Leave(object sender, EventArgs e)
        {
            
        }

        private void Dep_combobox_SelectedValueChanged(object sender, EventArgs e)
        {

       

        }

        private void Dep_combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int DEP_NUM = controllerObj.getdepid(Dep_combobox.Text);

            DataTable dt = controllerObj.get_service_type(DEP_NUM);

            Services_Grid.DataSource = dt;
            Services_Grid.Refresh();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Potential_Buyer p = new Potential_Buyer();
            p.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }
    }
}
