using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Fislab_Project
{
    public partial class FHome : Form
    {
        private bool connection;
        public FHome()
        {
            InitializeComponent();
            connect data = new connect();
            connection = data.check();
            if(connection == true)
            {
                lblConnect.Text = "You're connected to internet";
            }
        }

        private void FHome_Load(object sender, EventArgs e)
        {
            connect data = new connect();
            connection = data.check();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(connection == true)
            {
                FLogin login = new FLogin();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You're not connected to internet");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(connection == true)
            {
                FSignUp signup = new FSignUp();
                signup.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You're not connected to internet");
            }
        }

        private void btnOffline_Click(object sender, EventArgs e)
        {
            Fmenu menu = new Fmenu();
            menu.Show();
            this.Hide();
        }
    }
}
