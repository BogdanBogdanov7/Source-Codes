using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu1
{
    public partial class izvajdane_2_klas : Form
    {
        public izvajdane_2_klas()
        {
            InitializeComponent();
        }
        public static int br = 0;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

            Random P = new Random();
            Random V = new Random();

            int PMax = 100;

            int PChislo = P.Next(0, PMax);
            int VChislo = V.Next(0, PChislo);

            int result1 = PChislo - VChislo;

            first.Text = PChislo.ToString();
            second.Text = VChislo.ToString();
            result.Text = result1.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            klas_2_menu option = new klas_2_menu();
            option.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == result.Text)
            {
                button2.Enabled = false;
                button1.Enabled = true;
                wrong.Visible = false;
                correct.Visible = true;
                br++;
            }
            else
            {
                button1.Enabled = false;
                correct.Visible = false;
                wrong.Visible = true;
            }
            points.Text = br.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;

            textBox1.Text = "";
            correct.Visible = false;
            button1.Enabled = false;

            Random P = new Random();
            Random V = new Random();

            int PMax = 100;

            int PChislo = P.Next(0, PMax);
            int VChislo = V.Next(0, PChislo);

            int result1 = PChislo - VChislo;

            first.Text = PChislo.ToString();
            second.Text = VChislo.ToString();
            result.Text = result1.ToString();
        }

        private void izvajdane_2_klas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            klas_2_menu option = new klas_2_menu();
            option.ShowDialog();
        }
    }
}
