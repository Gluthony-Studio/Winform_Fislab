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
        private int cases = 0;
        private int conn;
        public Fglb(int Conn)
        {
            InitializeComponent();
            conn = Conn;
        }

        private void Fglb_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            answer.Text = comboBox1.Text;
            switch (comboBox1.Text)
            {
                case "Velocity":
                    clue1.Text = "Time";
                    clue2.Text = "Distance";
                    cases = 1;
                    break;
                case "Time":
                    clue1.Text = "Velocity";
                    clue2.Text = "Distance";
                    cases = 2;
                    break;
                case "Distance":
                    clue1.Text = "Time";
                    clue2.Text = "Velocity";
                    cases = 3;
                    break;
                default:
                    cases = 0;
                    tbclue1.Enabled = false;
                    tbclue2.Enabled = false;
                    break;
            }
            if (cases != 0)
            {
                tbclue1.Enabled = true;
                tbclue2.Enabled = true;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Fmenu menu = new Fmenu(conn);
            menu.Show();
            this.Hide();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(cases != 0)
            {
                if(clue1.Text != null && clue2.Text != null)
                {
                    try {
                        c_glb glb = new c_glb();

                        double Clue1 = Convert.ToDouble(tbclue1.Text);
                        double Clue2 = Convert.ToDouble(tbclue2.Text);
                        double Answer = 0;
                        string equation = "";

                        switch (cases)
                        {
                            case 1:
                                Answer = glb.calculateV(Clue1, Clue2);
                                equation = (Clue2 + " / " + Clue1);
                                break;
                            case 2:
                                Answer = glb.calculateT(Clue1, Clue2);
                                equation = (Clue2+" / "+Clue1);
                                break;
                            case 3:
                                Answer = glb.calculateS(Clue1, Clue2);
                                equation = (Clue2+" x "+Clue1);
                                break;
                        }
                        tbanswer.Text = Answer.ToString();
                        listLog.Items.Add("["+answer.Text+"] "+Answer+" = "+equation);
                    }
                    catch
                    {
                        MessageBox.Show("Please input a valid number!");
                        tbclue1.Clear();
                        tbclue2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please input data");
                }
            }
            else
            {
                MessageBox.Show("Please choice a case");
                comboBox1.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbanswer.Clear();
            tbclue1.Clear();
            tbclue2.Clear();
            comboBox1.Text="";
            comboBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listLog.Items.Remove(listLog.SelectedItem);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            PanelInput.Visible = true;
            panelLog.Visible = false;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            PanelInput.Visible = false;
            panelLog.Visible = true;
            tbanswer.Clear();
            tbclue1.Clear();
            tbclue2.Clear();
            comboBox1.Focus();
        }

        private void PanelInput_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
