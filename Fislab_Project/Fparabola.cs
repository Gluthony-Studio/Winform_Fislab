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
    public partial class Fparabola : Form
    {
        private int conn;
        private int cases = 0;
        public Fparabola(int Conn)
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

        private void Fparabola_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                comboBox1.Enabled = true;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Vertical Initial Velocity");
                comboBox1.Items.Add("Vertical Velocity");
                comboBox1.Items.Add("High");
                comboBox1.Items.Add("Maximum High");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                comboBox1.Enabled = true;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Horizontal Initial Velocity");
                comboBox1.Items.Add("Horizontal Velocity");
                comboBox1.Items.Add("Distance");
                comboBox1.Items.Add("Maximum Distance");
            }
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
                MessageBox.Show("Data is Empty!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbAnswer.Clear();
            tbClue1.Clear();
            tbClue2.Clear();
            tbClue3.Clear();
            tbClue4.Clear();
            comboBox1.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Enabled = false;
            cases = 0;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (cases != 0)
            {
                if (tbClue1.Text != null && tbClue2.Text != null && tbClue3.Text != null && tbClue4.Text != null)
                {
                    try
                    {
                        c_parabola para = new c_parabola();
                        double Clue1 = Convert.ToDouble(tbClue1.Text);
                        double Clue2 = Convert.ToDouble(tbClue2.Text);
                        double Clue3 = Convert.ToDouble(tbClue3.Text);
                        double Clue4 = Convert.ToDouble(tbClue4.Text);
                        double answer = 0.0;
                        string equation = "";
                        switch (cases)
                        {
                            case 1:
                                answer = para.calVoy(Clue1, Clue2);
                                equation = (Clue1 + " x Sin(" + Clue2 + ")");
                                break;
                            case 2:
                                answer = para.calVy(Clue1, Clue2, Clue3, Clue4);
                                equation = (Clue1 + " x Sin(" + Clue2 + ") - " + Clue3 + " x " + Clue4);
                                break;
                            case 3:
                                answer = para.calH(Clue1, Clue2, Clue3, Clue4);
                                equation = (Clue1 + " x " + Clue2 + " x Sin(" + Clue3 + ") - " + Clue4 + " x " + Clue2 + "^2");
                                break;
                            case 4:
                                answer = para.calHmax(Clue1, Clue2, Clue3);
                                equation = ("(" + Clue1 + "^2 x Sin(" + Clue2 + ")^2) / (2 x " + Clue3 + ")");
                                break;
                            case 5:
                                answer = para.calVox(Clue1, Clue2);
                                equation = (Clue1 + " x Cos(" + Clue2 + ")");
                                break;
                            case 6:
                                answer = para.calVx(Clue1, Clue2, Clue3, Clue4);
                                equation = (Clue1 + " x Sin(" + Clue2 + ") - " + Clue3 + " x " + Clue4);
                                break;
                            case 7:
                                answer = para.calS(Clue1, Clue2, Clue3);
                                equation = (Clue1 + " x " + Clue2 + " x Cos(" + Clue3 + ")");
                                break;
                            case 8:
                                answer = para.calSmax(Clue1, Clue2, Clue3);
                                equation = ("(" + Clue1 + "^2 x Sin(2 x " + Clue2 + ")) / " + Clue3);
                                break;
                        }
                        tbAnswer.Text = answer.ToString();
                        listLog.Items.Add("[" + lAnswer.Text + "] " + answer + " = " + equation);
                    }
                    catch
                    {
                        MessageBox.Show("Please input a valid number!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please input data");
                }
            }
            else
            {
                MessageBox.Show("Please choose a valid case");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lAnswer.Text = comboBox1.Text;
            switch (comboBox1.Text)
            {
                case "Vertical Initial Velocity":
                    cases = 1;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = true;
                    tbClue3.Enabled = false;
                    tbClue4.Enabled = false;
                    clue1.Text = "Initial Velocity";
                    clue2.Text = "Alpha";
                    clue3.Text = "-";
                    clue4.Text = "-";
                    break;
                case "Vertical Velocity":
                    cases = 2;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = true;
                    tbClue3.Enabled = true;
                    tbClue4.Enabled = true;
                    clue1.Text = "Initial Velocity";
                    clue2.Text = "Alpha";
                    clue3.Text = "Gravitation";
                    clue4.Text = "Time";
                    break;
                case "High":
                    cases = 3;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = true;
                    tbClue3.Enabled = true;
                    tbClue4.Enabled = true;
                    clue1.Text = "Initial Velocity";
                    clue2.Text = "Time";
                    clue3.Text = "Alpha";
                    clue4.Text = "Gravitation";
                    break;
                case "Maximum High":
                    cases = 4;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = true;
                    tbClue3.Enabled = true;
                    tbClue4.Enabled = false;
                    clue1.Text = "Initial Velocity";
                    clue2.Text = "Alpha";
                    clue3.Text = "Gravitation";
                    clue4.Text = "-";
                    break;
                case "Horizontal Initial Velocity":
                    cases = 5;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = true;
                    tbClue3.Enabled = false;
                    tbClue4.Enabled = false;
                    clue1.Text = "Initial Velocity";
                    clue2.Text = "Alpha";
                    clue3.Text = "-";
                    clue4.Text = "-";
                    break;
                case "Horizontal Velocity":
                    cases = 6;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = true;
                    tbClue3.Enabled = true;
                    tbClue4.Enabled = true;
                    clue1.Text = "Initial Velocity";
                    clue2.Text = "Alpha";
                    clue3.Text = "Gravitation";
                    clue4.Text = "Time";
                    break;
                case "Distance":
                    cases = 7;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = true;
                    tbClue3.Enabled = true;
                    tbClue4.Enabled = false;
                    clue1.Text = "Initial Velocity";
                    clue2.Text = "Time";
                    clue3.Text = "Alpha";
                    clue4.Text = "-";
                    break;
                case "Maximum Distance":
                    cases = 8;
                    tbClue1.Enabled = true;
                    tbClue2.Enabled = true;
                    tbClue3.Enabled = true;
                    tbClue4.Enabled = false;
                    clue1.Text = "Initial Velocity";
                    clue2.Text = "Alpha";
                    clue3.Text = "Gravitation";
                    clue4.Text = "-";
                    break;
                default:
                    cases = 0;
                    tbClue1.Enabled = false;
                    tbClue2.Enabled = false;
                    tbClue3.Enabled = false;
                    tbClue4.Enabled = false;
                    clue1.Text = "-";
                    clue2.Text = "-";
                    clue3.Text = "-";
                    clue4.Text = "-";
                    break;
            }
            if (tbClue3.Enabled==false)
            {
                tbClue3.Text = "0";
            }
            if (tbClue4.Enabled == false)
            {
                tbClue4.Text = "0";
            }
        }
    }
}
