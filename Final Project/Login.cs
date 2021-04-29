using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            PasswordTxtBox.PasswordChar = '*';
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxtBox.Text == " ")
            {
                MessageBox.Show("Please enter password");
            }
            else if (PasswordTxtBox.Text == "hire")
            {
                Hiring x = new Hiring ();
                x.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (UserNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a username");
            }
            else if (UserNameTextBox.Text == "Pro Athlete")
            {
            }
            else
            {
                MessageBox.Show("Wrong username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
