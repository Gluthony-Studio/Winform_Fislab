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
    public partial class FLogin : Form
    {
        private bool connection;
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (connection == true)
            {
                if (tbUsername.Text != null && tbPassword.Text != null)
                {
                    try
                    {
                        var result = client.Get("Account/" + tbUsername.Text);
                        userAccount account = result.ResultAs<userAccount>();
                        if (account.password == tbPassword.Text)
                        {
                            successlogin();
                        }
                        else
                        {
                            MessageBox.Show("Your password is incorrect!");
                            tbPassword.Clear();
                            tbPassword.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Your username is incorrect");
                        tbUsername.Clear();
                        tbUsername.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please input username and password");
                }
            }
            else
            {
                MessageBox.Show("Pleas check your internet connection");
            }
        }
        public void successlogin()
        {
            MessageBox.Show("Your account succes login!");
            FDashboard dashboard = new FDashboard();
            dashboard.Show();
            this.Hide();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KTkJ63vqljTTmt53tb8a4A93lrgN3sAuFG7q5t72",
            BasePath = "https://fislabproject-default-rtdb.firebaseio.com/"
        };
        private IFirebaseClient client;
        private void FLogin_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                connection = true;
            }
            else
            {
                connection = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FHome home = new FHome();
            home.Show();
            this.Hide();
        }
    }
}
