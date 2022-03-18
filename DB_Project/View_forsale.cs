using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DB_Project
{
   
    public partial class View_forsale : Form
    {
        Controller controllerObj;
        public View_forsale()
        {
            InitializeComponent();
            controllerObj = new Controller();
         

        }

        private void View_Click(object sender, EventArgs e)
        {
           
        }

        private void View_forsale_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Viewforsale();

            if (dt == null)
            {
                return;
            }

            dt.Columns.Add("Discount", typeof(string));
            Random rand = new Random();
            foreach (DataRow row in dt.Rows)
            {

                int discount = rand.Next(5, 15);
                string discount_alpha = discount.ToString() + "%";
                    
                
                row["Discount"] = discount_alpha;   
            }





            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.jumeirah.com/en");
        }

        private void button1_Click(object sender, EventArgs e)
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
