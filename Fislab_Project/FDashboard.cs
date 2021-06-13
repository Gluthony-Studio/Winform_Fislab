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
    public partial class FDashboard : Form
    {
        public static int conn = 0;
        public FDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fmenu menu = new Fmenu(1);
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FQnA qna = new FQnA();
            qna.Show();
            this.Hide();
        }

        private void FDashboard_Load(object sender, EventArgs e)
        {
            conn = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FLogin login = new FLogin();
            login.Show();
            this.Hide();
        }
    }
}
