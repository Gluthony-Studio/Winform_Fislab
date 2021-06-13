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
    public partial class FSignUp : Form
    {
        private bool connection;
        
        public FSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection == true)
            {
                if (tbUsername.Text != null && tbEmail.Text!=null && tbPassword.Text!=null)
                {
                    try
                    {
                        var result = client.Get("Account/" + tbUsername);
                        userAccount Caccount = result.ResultAs<userAccount>();
                        failed();
                    }
                    catch
                    {
                        userAccount account = new userAccount
                        {
                            username = tbUsername.Text,
                            email = tbEmail.Text,
                            password = tbPassword.Text
                        };
                        var setter = client.Set("Account/" + tbUsername.Text, account);
                        success();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection!");
            }
        }
        public void success()
        {
            MessageBox.Show("Your account succesfull register. Please login");
            FLogin login = new FLogin();
            login.Show();
            this.Hide();
        }
        public void failed()
        {
            MessageBox.Show("Username sudah terpakai");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FLogin login = new FLogin();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FHome home = new FHome();
            home.Show();
            this.Hide();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KTkJ63vqljTTmt53tb8a4A93lrgN3sAuFG7q5t72",
            BasePath = "https://fislabproject-default-rtdb.firebaseio.com/"
        };
        private IFirebaseClient client;
        private void FSignUp_Load(object sender, EventArgs e)
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
    }
}
