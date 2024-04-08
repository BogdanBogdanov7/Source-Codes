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
    public partial class umnojenie_2_klas : Form
    {
        public umnojenie_2_klas()
        {
            InitializeComponent();
        }
        public static int br = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            klas_2_menu option = new klas_2_menu();
            option.ShowDialog();
        }

        private void umnojenie_2_klas_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;

            Random P = new Random();
            Random V = new Random();

            int PChislo = P.Next(0, 11);
            int VChislo = V.Next(0, 9);

            int total = PChislo * VChislo;

            first.Text = PChislo.ToString();
            second.Text = VChislo.ToString();
            result.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (result.Text == textBox1.Text)
            {
                button2.Enabled = false;
                wrong.Visible = false;
                correct.Visible = true;
                button3.Enabled = true;
                br += 3;
                points.Text = br.ToString();
            }
            else
            {
                button3.Enabled = false;
                correct.Visible = false;
                wrong.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = false;

            correct.Visible = false;
            textBox1.Text = "";

            Random P = new Random();
            Random V = new Random();

            int PChislo = P.Next(0, 11);
            int VChislo = V.Next(0, 9);

            int total = PChislo * VChislo;

            first.Text = PChislo.ToString();
            second.Text = VChislo.ToString();
            result.Text = total.ToString();
        }

        private void first_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            wrong.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void umnojenie_2_klas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            klas_2_menu option = new klas_2_menu();
            option.ShowDialog();
        }
    }
}
