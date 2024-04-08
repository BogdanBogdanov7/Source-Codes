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
    public partial class stranica1 : Form
    {

        public stranica1()
        {
            InitializeComponent();
        }
        public static int br = 0;
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void stranica1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;

            Random P = new Random();
            Random V = new Random();

            int PMax = 11;
            int VMax = 10;

            int Pchislo = P.Next(0, PMax);
            int Vchislo = V.Next(0, VMax);

            int obshto = (Pchislo + Vchislo);

            LblPurvo.Text = Pchislo.ToString();
            LblVtoro.Text = Vchislo.ToString();
            LblResult.Text = obshto.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == LblResult.Text)
            {
                LblMessage.Visible = true;
                vuprositelen.Visible = false;
                LblMessage.Text = "Решението е вярно !";
                smiley.Visible = true;
                sad.Visible = false;
                br++;
                points.Text = br.ToString();
                button1.Enabled = false;
                button3.Enabled = true;
            }
            else
            {
                LblMessage.Visible = true;
                vuprositelen.Visible = false;
                smiley.Visible = false;
                LblMessage.Text = "Решението е грешно !";
                sad.Visible = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button1.Enabled = true;

            textBox1.Text = "";

            LblMessage.Visible = false;
            smiley.Visible = false;
            sad.Visible = false;
            vuprositelen.Visible = true;

            Random P = new Random();
            Random V = new Random();

            int PMax = 11;
            int VMax = 10;

            int Pchislo = P.Next(0, PMax);
            int Vchislo = V.Next(0, VMax);

            int obshto = (Pchislo + Vchislo);

            LblPurvo.Text = Pchislo.ToString();
            LblVtoro.Text = Vchislo.ToString();
            LblResult.Text = obshto.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu_1_klas option = new Menu_1_klas();
            option.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void stranica1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu_1_klas option = new Menu_1_klas();
            option.ShowDialog();
        }
    }
}
