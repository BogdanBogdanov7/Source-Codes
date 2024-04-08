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
    public partial class subirane_do_100 : Form
    {
        public subirane_do_100()
        {
            InitializeComponent();
        }
        public static int br;
        private void subirane_do_100_Load(object sender, EventArgs e)
        {
            Random P = new Random();
            Random V = new Random();

            int PMax = 100;

            int PChislo = P.Next(0, PMax);
            int VChislo = V.Next(0, PChislo);

            int result1 = PChislo + VChislo;

            first.Text = PChislo.ToString();
            second.Text = VChislo.ToString();
            result.Text = result1.ToString();

            if (result1 > 100)
            {
                Random E = new Random();
                Random T = new Random();

                int EMax = 50;
                int TMax = 50;

                int EChislo = E.Next(0, EMax);
                int TChislo = T.Next(0, TMax);

                int result2 = EChislo + TChislo;

                first.Text = EChislo.ToString();
                second.Text = TChislo.ToString();
                result.Text = result2.ToString();
            }
            else
            {
                Random Z = new Random();
                Random A = new Random();

                int ZMax = 100;

                int ZChislo = Z.Next(0, ZMax);
                int AChislo = A.Next(0, ZChislo);

                int result3 = ZChislo + AChislo;

                first.Text = ZChislo.ToString();
                second.Text = AChislo.ToString();
                result.Text = result3.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            klas_2_menu option = new klas_2_menu();
            option.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (result.Text == textBox1.Text)
            {
                wrong.Visible = false;
                correct.Visible = true;
                button3.Enabled = true;
                br++;
                points.Text = br.ToString();
            }
            else
            {
                button3.Enabled = false;
                correct.Visible = false;
                wrong.Visible = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            correct.Visible = false;
            button3.Enabled = false;

            Random P = new Random();
            Random V = new Random();

            int PMax = 100;

            int PChislo = P.Next(0, PMax);
            int VChislo = V.Next(0, PChislo);

            int result1 = PChislo + VChislo;

            first.Text = PChislo.ToString();
            second.Text = VChislo.ToString();
            result.Text = result1.ToString();

            if (result1 > 100)
            {
                Random E = new Random();
                Random T = new Random();

                int EMax = 50;
                int TMax = 50;

                int EChislo = E.Next(0, EMax);
                int TChislo = T.Next(0, TMax);

                int result2 = EChislo + TChislo;

                first.Text = EChislo.ToString();
                second.Text = TChislo.ToString();
                result.Text = result2.ToString();
            }
            else
            {
                Random Z = new Random();
                Random A = new Random();

                int ZMax = 100;

                int ZChislo = Z.Next(0, ZMax);
                int AChislo = A.Next(0, ZChislo);

                int result3 = ZChislo + AChislo;

                first.Text = ZChislo.ToString();
                second.Text = AChislo.ToString();
                result.Text = result3.ToString();
            }
        }

        private void subirane_do_100_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            klas_2_menu option = new klas_2_menu();
            option.ShowDialog();
        }
    }
}
