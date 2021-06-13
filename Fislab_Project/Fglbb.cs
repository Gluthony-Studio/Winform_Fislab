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
    public partial class Fglbb : Form
    {
        private int cases = 0;
        private int conn;
        public Fglbb(int Conn)
        {
            InitializeComponent();
            conn = Conn;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            panelInput.Visible = true;
            panelLog.Visible = false;
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            panelInput.Visible = false;
            panelLog.Visible = true;
            tbAnswer.Clear();
            tbclue1.Clear();
            tbclue2.Clear();
            tbClue3.Clear();
            comboBox1.Focus();
        }
        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            Fmenu menu = new Fmenu(conn);
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listLog.Items.Remove(listLog.SelectedItem);
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LAnswer.Text = comboBox1.Text;
            switch (comboBox1.Text)
            {
                case "Acceleration":
                    cases = 1;
                    clue1.Text = "Time";
                    clue2.Text = "Inital Velocity";
                    clue3.Text = "Final Velocity";
                    break;
                case "Time":
                    cases = 2;
                    clue1.Text = "Distance";
                    clue2.Text = "Inital Velocity";
                    clue3.Text = "Final Velocity";
                    break;
                case "Distance":
                    cases = 3;
                    clue1.Text = "Time";
                    clue2.Text = "Inital Velocity";
                    clue3.Text = "Acceleration";
                    break;
                case "Initial Velocity":
                    cases = 4;
                    clue1.Text = "Time";
                    clue2.Text = "Acceleration";
                    clue3.Text = "Final Velocity";
                    break;
                case "Final Velocity":
                    cases = 5;
                    clue1.Text = "Time";
                    clue2.Text = "Inital Velocity";
                    clue3.Text = "Acceleration";
                    break;
                default:
                    cases = 0;
                    tbclue1.Enabled = false;
                    tbclue2.Enabled = false;
                    tbClue3.Enabled = false;
                    break;
            }
            if (cases != 0)
            {
                tbclue1.Enabled = true;
                tbclue2.Enabled = true;
                tbClue3.Enabled = true;
            }
        }
        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            if (cases != 0)
            {
                if (tbclue1 != null && tbclue2 != null && tbClue3 != null)
                {
                    try
                    {
                        c_glbb glbb = new c_glbb();
                        double Clue1 = Convert.ToDouble(tbclue1.Text);
                        double Clue2 = Convert.ToDouble(tbclue2.Text);
                        double Clue3 = Convert.ToDouble(tbClue3.Text);
                        double answer = 0;
                        string equation = "";
                        switch (cases)
                        {
                            case 1:
                                answer = glbb.calculatea(Clue1, Clue2, Clue3);
                                equation = ("(" + Clue3 + " - " + Clue2 + ") / " + Clue1);
                                break;
                            case 2:
                                answer = glbb.calculateT(Clue1, Clue2, Clue3);
                                equation = ("(2 x " + Clue1 + ") / (" + Clue2 + " + " + Clue3 + ")");
                                break;
                            case 3:
                                answer = glbb.calculateS(Clue1, Clue2, Clue3);
                                equation = (Clue2 + " x " + Clue1 + " + (" + Clue3 + " / 2) " + Clue1 + "^2");
                                break;
                            case 4:
                                answer = glbb.calculatevo(Clue3, Clue2, Clue1);
                                equation = (Clue3 + " - " + Clue2 + " x " + Clue1);
                                break;
                            case 5:
                                answer = glbb.calculatevt(Clue2, Clue3, Clue1);
                                equation = (Clue2 + " + " + Clue3 + " x " + Clue1);
                                break;
                        }
                        tbAnswer.Text = answer.ToString();
                        listLog.Items.Add("[" + LAnswer.Text + "] " + tbAnswer.Text + " = " + equation);
                    }
                    catch
                    {
                        MessageBox.Show("Please Input a valid number");
                        tbclue1.Clear();
                        tbclue2.Clear();
                        tbClue3.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please input data");
                }
            }
            else
            {
                MessageBox.Show("Please choose a case");
                comboBox1.Focus();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            tbAnswer.Clear();
            tbclue1.Clear();
            tbclue2.Clear();
            tbClue3.Clear();
            comboBox1.Focus();
        }
    }
}
