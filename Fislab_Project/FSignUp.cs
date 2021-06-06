using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fislab_Project
{
    public partial class FSignUp : Form
    {
        private bool connection;
        public FSignUp()
        {
            InitializeComponent();
            connect data = new connect();
            connection = data.check();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(connection == true)
            {
                userAccount user = new userAccount();
                if(tbUsername.Text != null || tbPassword.Text != null || tbEmail.Text != null)
                {
                    user.signup(tbUsername.Text, tbEmail.Text, tbPassword.Text);
                }
                else
                {
                    MessageBox.Show("Input your data!");
                }                
            }
            else
            {
                MessageBox.Show("You're not connected to internet");
            }
        }
        public void success()
        {
            FLogin login = new FLogin();
            login.Show();
            this.Hide();
        }
        public void failed()
        {
            MessageBox.Show("Your account failed to regster");
        }
    }
}
