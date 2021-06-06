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
    public partial class FLogin : Form
    {
        private bool connection;
        public FLogin()
        {
            InitializeComponent();
            connect data = new connect();
            connection = data.check();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(connection == true)
            {
                userAccount user = new userAccount();
                if(tbUsername.Text != null || tbPassword.Text != null)
                {
                    user.login(tbUsername.Text, tbPassword.Text);
                }
                else
                {
                    MessageBox.Show("Input your username and password!");
                }
            }
            else
            {
                MessageBox.Show("You're not connected to internet");
            }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
