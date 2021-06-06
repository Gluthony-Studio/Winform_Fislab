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
    public partial class Fglb : Form
    {
        private int cases;
        public Fglb()
        {
            InitializeComponent();
        }

        private void Fglb_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Velocity":
                    clue1.Text = "Time";
                    clue2.Text = "Distance";
                    answer.Text = "Velocity";
                    cases = 1;
                    break;
                case "Time":
                    clue1.Text = "Velocity";
                    clue2.Text = "Distance";
                    answer.Text = "Time";
                    cases = 2;
                    break;
                case "Distance":
                    clue1.Text = "Time";
                    clue2.Text = "Velocity";
                    answer.Text = "Distance";
                    cases = 3;
                    break;
                default:
                    cases = 0;
                    break;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Fmenu menu = new Fmenu();
            menu.Show();
            this.Hide();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(cases != 0)
            {
                if(clue1.Text != null && clue2.Text != null)
                {
                    c_glb glb = new c_glb();

                    double Clue1 = Convert.ToDouble(clue1.Text);
                    double Clue2 = Convert.ToDouble(clue2.Text);
                    double Answer;
                    
                    switch (cases)
                    {
                        case 1:
                            Answer = glb.calculateV();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choice a case");
            }
        }
    }
}
