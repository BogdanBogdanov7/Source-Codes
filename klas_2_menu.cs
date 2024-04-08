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
    public partial class klas_2_menu : Form
    {
        public klas_2_menu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game_Menu option = new Game_Menu();
            option.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            neizv_chislo_2_klas option = new neizv_chislo_2_klas();
            option.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            subirane_do_100 option = new subirane_do_100();
            option.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            izvajdane_2_klas option = new izvajdane_2_klas();
            option.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            umnojenie_2_klas option = new umnojenie_2_klas();
            option.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Main option = new Menu_Main();
            option.ShowDialog();
        }

        private void klas_2_menu_Load(object sender, EventArgs e)
        {

        }

        private void klas_2_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu_Main option = new Menu_Main();
            option.ShowDialog();
        }
    }
}
