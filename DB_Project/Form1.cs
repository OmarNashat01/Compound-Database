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
   

    public partial class LoginForm : Form
    {
        Controller controllerObj;


        public LoginForm()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
                return;

            // encrypt to sha1 and md5
            //string passwordmd5 = Encryptor.MD5Hash(PasswordTextBox.Text);
            string passwordsha1 = Encryptor.HashSh1(PasswordTextBox.Text);

            string username = UsernameTextBox.Text;

            DataTable dt = controllerObj.GetAccount(username, passwordsha1);

            if (dt == null)
            {
                MessageBox.Show("Wrong Username or Password try again..");
                return;
            }
            string type = dt.Rows[0]["User_type"].ToString();

            if ( type == "ResidenceOwner" )
            {
                string id = controllerObj.Get_Res_Owner_ID(username, passwordsha1);

                Global.Residence_Owner_ID = id;

                Residence_Owner_Form Rform = new Residence_Owner_Form();
                Rform.Show();
            }
            else if ( type == "Employee" )
            {
                string id = controllerObj.Get_Emp_ID(username, passwordsha1);

                Global.Employee_ID = id;
                int dnum = controllerObj.GetDnum(id);


                Employee_Form_Temp Empform = new Employee_Form_Temp(dnum);
                Empform.Show();
            }
            else if (type == "EmployeeAdmin")
            {
                string id = controllerObj.Get_Emp_ID(username, passwordsha1);

                Global.Employee_ID = id;
                int dnum = controllerObj.GetDnum(id);
                Global.depnum = dnum;

                Admin_Form_temp empadform = new Admin_Form_temp(dnum);
                empadform.Show();
            }
            else if ( type == "Admin" )
            {
                string id = controllerObj.Get_Emp_ID(username, passwordsha1);

                Global.Employee_ID = id;

                Admin_Form Adform = new Admin_Form();
                Adform.Show();
            }


            this.Hide();


        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            SignUp_Form suForm = new SignUp_Form();
            suForm.Show();

            this.Hide();
        }

        private void GuestBtn_Click(object sender, EventArgs e)
        {
            Potential_Buyer pbform = new Potential_Buyer();
            pbform.Show();

            this.Hide();
        }
    }
    static class Global
    {
        public static string Residence_Owner_ID = "";
        public static string Employee_ID = "";
        public static int depnum = 0;
    }
}
