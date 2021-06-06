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
        public Fmenu()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lbltimer.Text = Convert.ToString(date);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FThermal thermal = new FThermal();
            thermal.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fgmb gmb = new Fgmb();
            gmb.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fparabola parabola = new Fparabola();
            parabola.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fkatrol katrol = new Fkatrol();
            katrol.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fglbb glbb = new Fglbb();
            glbb.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fglb glb = new Fglb();
            glb.Show();
            this.Hide();
        }
    }
}
