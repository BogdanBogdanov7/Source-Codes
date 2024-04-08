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
    public partial class Menu_Main : Form
    {
        public Menu_Main()
        {
            InitializeComponent();
        }
        public static int br = 0;

        private void Menu_Main_Load(object sender, EventArgs e)
        {
            br += neizv_chislo_2_klas.br;
            br += subirane_do_100.br;
            br += izvajdane_2_klas.br;
            br += stranica1.br;
            br += stranica2.br;
            br += umnojenie_2_klas.br;

            neizv_chislo_2_klas.br = 0;
            subirane_do_100.br = 0;
            izvajdane_2_klas.br = 0;
            stranica1.br = 0;
            stranica2.br = 0;
            umnojenie_2_klas.br = 0;

            points.Text = br.ToString();
        }
        private void btn_izhod_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void klas_1_show_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu_1_klas option = new Menu_1_klas();
            option.ShowDialog();
        }

        private void klas_2_show_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            klas_2_menu option = new klas_2_menu();
            option.ShowDialog();
        }

        private void klas_3_show_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game_Menu option = new Game_Menu();
            option.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            br += neizv_chislo_2_klas.br;
            br += subirane_do_100.br;
            br += izvajdane_2_klas.br;
            br += stranica1.br;
            br += stranica2.br;
            br += umnojenie_2_klas.br;
            neizv_chislo_2_klas.br = 0;
            subirane_do_100.br = 0;
            izvajdane_2_klas.br = 0;
            stranica1.br = 0;
            stranica2.br = 0;
            umnojenie_2_klas.br = 0;
            points.Text = br.ToString();
        }
        public static int SendPoints
        {
            get
            {
                return br;
            }
        }

        private void Menu_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
