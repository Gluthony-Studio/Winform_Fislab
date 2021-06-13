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
    public partial class FQnA : Form
    {
        private bool connection;
        public FQnA()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KTkJ63vqljTTmt53tb8a4A93lrgN3sAuFG7q5t72",
            BasePath = "https://fislabproject-default-rtdb.firebaseio.com/"
        };
        private IFirebaseClient client;

        private void button1_Click(object sender, EventArgs e)
        {
            FDashboard dash = new FDashboard();
            dash.Show();
            this.Hide();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            panelInsert.Visible = true;
            panelList.Visible = false;
            tbQuestion.Clear();
        }

        private void btnLQ_Click(object sender, EventArgs e)
        {
            panelInsert.Visible = false;
            panelList.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(tbTitle.Text!=null && tbQuestion.Text != null)
            {
                try
                {
                    QnA q = new QnA
                    {
                        title = tbTitle.Text,
                        question = tbQuestion.Text,
                        answer = "-"
                    };
                    var setter = client.Set("Question/" + tbTitle.Text, q);
                    MessageBox.Show("Your question uploaded");
                    tbTitle.Clear();
                    tbQuestion.Clear();
                }
                catch
                {
                    MessageBox.Show("Please check your internet connection");
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (tbCari.Text != null)
            {
                try
                {
                    var result = client.Get("Question/" + tbCari.Text);
                    QnA q = result.ResultAs<QnA>();
                    panelDetail.Visible = true;
                    panelAnswer.Visible = false;
                    lTitle.Text = q.title;
                    lQuestion.Text = q.question;
                    lAnswer.Text = q.answer;
                }
                catch
                {
                    MessageBox.Show("Question not found");
                }
            }
            else
            {
                MessageBox.Show("Please input a keyword");
                tbCari.Focus();
            }

        }

        private void FQnA_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            panelAnswer.Visible = true;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (tbAnswer.Text != null)
            {
                try
                {
                    QnA q = new QnA
                    {
                        title = lTitle.Text,
                        question = lQuestion.Text,
                        answer = tbAnswer.Text
                    };
                    var setter = client.Update("Question/" + lTitle.Text, q);
                    MessageBox.Show("Your answer uploaded");
                    tbAnswer.Clear();
                    panelAnswer.Visible = false;
                }
                catch
                {
                    MessageBox.Show("Please check your internet connection!");
                }
            }
            else
            {
                MessageBox.Show("Please input your answer");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelAnswer.Visible = false;
        }

        private void panelAnswer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
