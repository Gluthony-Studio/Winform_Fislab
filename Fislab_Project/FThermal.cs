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
    public partial class FThermal : Form
    {
        private int conn;
        public FThermal(int Conn)
        {
            InitializeComponent();
            conn = Conn;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(tbConvert.Text != null && cbThermal.Text != null) {
                C_thermal thermal = new C_thermal();
                double clue = Convert.ToDouble(tbConvert.Text);
                switch (cbThermal.Text)
                {
                    case "Celcius":
                        thermal.convertC(clue);
                        break;
                    case "Fahrenheit":
                        thermal.convertF(clue);
                        break;
                    case "Reamur":
                        thermal.convertR(clue);
                        break;
                    case "Kelvin":
                        thermal.convertK(clue);
                        break;
                }
                tbCelcius.Text = thermal.celcius.ToString();
                tbFarenheit.Text = thermal.fahrenheit.ToString();
                tbReamur.Text = thermal.reamur.ToString();
                tbKelvin.Text = thermal.kelvin.ToString();
            }
            else
            {
                MessageBox.Show("Please input thermal's data");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCelcius.Text = "";
            tbReamur.Text = "";
            tbFarenheit.Text = "";
            tbKelvin.Text = "";
            tbConvert.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fmenu menu = new Fmenu(conn);
            menu.Show();
            this.Hide();
        }
    }
}
