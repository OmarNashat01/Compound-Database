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
    public partial class SignUp_Form : Form
    {
        Controller controllerObj;
        public SignUp_Form()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(IDTextbox.Text=="" || usernameTextBox.Text=="" || PasswordTextbox.Text=="")
            {
                MessageBox.Show("One or more fields are empty.");
                return;
            }

            string ID = IDTextbox.Text;
            if(ID.Length < 14)
            {
                MessageBox.Show("ID must be 14 characters.");
                return;
            }

            
            string username = usernameTextBox.Text;
            string password = PasswordTextbox.Text;
            if(controllerObj.getResidence_ID(ID) == null)
            {
                MessageBox.Show("You are not an owner in the residential compound.");
                return;
            }
            if (controllerObj.getUsername(username) != null)
            {
                MessageBox.Show("This username is taken.");
                return;
            }

            string passSHA1 = Encryptor.HashSh1(password);
            controllerObj.createAccount(ID, username, passSHA1);

            MessageBox.Show("Account created successfully.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }
    }
}
