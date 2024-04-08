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
    public partial class neizv_chislo_2_klas : Form
    {
        public neizv_chislo_2_klas()
        {
            InitializeComponent();
        }
        public static int br = 0;
        private void neizv_chislo_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;

            Random P = new Random();
            Random R = new Random();

            int Pmax = 100;

            int PChislo = P.Next(0, Pmax);
            int RChislo = R.Next(0, PChislo);

            int x = PChislo - RChislo;

            label7.Text = x.ToString();

            label1.Text = PChislo.ToString();
            label4.Text = RChislo.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == label7.Text)
            {
                button2.Enabled = false;
                button3.Enabled = true;
                wrong.Visible = false;
                correct.Visible = true;
                br++;
                points.Text = br.ToString();
            }
            else
            {
                correct.Visible = false;
                wrong.Visible = true;
                button3.Enabled = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            wrong.Visible = false;
            correct.Visible = false;

            button2.Enabled = true;
            button3.Enabled = false;

            Random P = new Random();
            Random R = new Random();

            int Pmax = 100;

            int PChislo = P.Next(0, Pmax);
            int RChislo = R.Next(0, PChislo);

            int x = PChislo - RChislo;

            label7.Text = x.ToString();

            label1.Text = PChislo.ToString();
            label4.Text = RChislo.ToString();

            textBox1.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            klas_2_menu option = new klas_2_menu();
            option.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void neizv_chislo_2_klas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            klas_2_menu option = new klas_2_menu();
            option.ShowDialog();
        }
    }
}
