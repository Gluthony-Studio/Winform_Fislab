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
    public partial class Fgmb : Form
    {
        private int conn;
        private int cases=0;
        public Fgmb(int Conn)
        {
            InitializeComponent();
            conn = Conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fmenu menu = new Fmenu(conn);
            menu.Show();
            this.Hide();
        }

        private void Fgmb_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lAnswer.Text = comboBox1.Text;
            switch (comboBox1.Text)
            {
                case "Angle(Teta)":
                    clue1.Text = "Initial Teta";
                    clue2.Text = "Velocity of Teta";
                    clue3.Text = "Time";
                    cases = 1;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = true;
                    tbClue3.Enabled = true;
                    break;
                case "Angle's Velocity":
                    clue1.Text = "Frequency";
                    clue2.Text = "-";
                    clue3.Text = "-";
                    cases = 2;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = false;
                    tbClue3.Enabled = false;
                    break;
                case "Period":
                    clue1.Text = "Velocity of Teta";
                    clue2.Text = "-";
                    clue3.Text = "-";
                    cases = 3;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = false;
                    tbClue3.Enabled = false;
                    break;
                case "Linear Velocity":
                    clue1.Text = "Velocity of Teta";
                    clue2.Text = "Radius";
                    clue3.Text = "-";
                    cases = 4;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = true;
                    tbClue3.Enabled = false;
                    break;
                case "Radius":
                    clue1.Text = "Linear Velocity";
                    clue2.Text = "Frequency";
                    clue3.Text = "-";
                    cases = 5;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = true;
                    tbClue3.Enabled = false;
                    break;
                case "Frequency":
                    clue1.Text = "Period";
                    clue2.Text = "-";
                    clue3.Text = "-";
                    cases = 6;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = false;
                    tbClue3.Enabled = false;
                    break;
                default:
                    clue1.Text = "-";
                    clue2.Text = "-";
                    clue3.Text = "-";
                    cases = 0;
                    tbClue1.Enabled = false;
                    tbClue2.Enabled = false;
                    tbClue3.Enabled = false;
                    break;
            }
            if (tbClue2.Enabled == false)
            {
                tbClue2.Text = "0";
            }
            if (tbClue2.Enabled == false)
            {
                tbClue3.Text = "0";
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (cases != 0)
            {
                if (tbClue1.Text != null && tbClue2.Text != null && tbClue3 != null)
                {
                    try
                    {
                        c_gmb gmb = new c_gmb();
                        double Clue1 = Convert.ToDouble(tbClue1.Text);
                        double Clue2 = Convert.ToDouble(tbClue2.Text);
                        double Clue3 = Convert.ToDouble(tbClue3.Text);
                        double answer = 0.0;
                        string equation = "";
                        switch (cases)
                        {
                            case 1:
                                answer = gmb.calTeta(Clue1, Clue2, Clue3);
                                equation = (Clue1+" + "+Clue2+" x "+Clue3);
                                break;
                            case 2:
                                answer = gmb.calVteta(Clue1);
                                equation = ("2 x PI x " + Clue1);
                                break;
                            case 3:
                                answer = gmb.calPeriod(Clue1);
                                equation = ("(2 x PI) / " + Clue1);
                                break;
                            case 4:
                                answer = gmb.calVlin(Clue1, Clue2);
                                equation = (Clue1 + " x " + Clue2);
                                break;
                            case 5:
                                answer = gmb.calRadius(Clue1, Clue2);
                                equation = (Clue1 + " / (2 x PI x " + Clue2);
                                break;
                            case 6:
                                answer = gmb.calFrec(Clue1);
                                equation = ("1 / " + Clue1);
                                break;
                        }
                        tbAnswer.Text = answer.ToString();
                        listLog.Items.Add("["+lAnswer.Text+"] "+answer+" = "+equation);
                    }
                    catch
                    {
                        MessageBox.Show("Please input a valid number!");
                    }
                }
                else
                {
                    MessageBox.Show("Please input a known value");
                }
            }
            else
            {
                MessageBox.Show("Please choose a valid case!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbAnswer.Clear();
            tbClue1.Clear();
            tbClue2.Clear();
            tbClue3.Clear();
            comboBox1.Text = "";
            comboBox1.Focus();
            cases = 0;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            panelInput.Visible = true;
            panelList.Visible = false;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            panelInput.Visible = false;
            panelList.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listLog.Items.Count != 0)
            {
                listLog.Items.Remove(listLog.SelectedItem);
            }
            else
            {
                MessageBox.Show("Data is empty!");
            }
            
        }
    }
}
