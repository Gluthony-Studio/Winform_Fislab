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
    public partial class Fmenu : Form
    {
        private int conn;
        public Fmenu(int Conn)
        {
            InitializeComponent();
            timer1.Start();
            conn = Conn;
            if(conn == 1)
            {
                button7.Text = "DASHBOARD";
            }
            else
            {
                button7.Text = "HOME";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lbltimer.Text = Convert.ToString(date);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FThermal thermal = new FThermal(conn);
            thermal.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "DASHBOARD")
            {
                FDashboard dash = new FDashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                FHome home = new FHome();
                home.Show();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fgmb gmb = new Fgmb(conn);
            gmb.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fparabola parabola = new Fparabola(conn);
            parabola.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fglbb glbb = new Fglbb(conn);
            glbb.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fglb glb = new Fglb(conn);
            glb.Show();
            this.Hide();
        }
        private void Fmenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
