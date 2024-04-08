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
    public partial class Menu_1_klas : Form
    {
        public Menu_1_klas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_subirane_Click(object sender, EventArgs e)
        {
            this.Hide();
            stranica1 option = new stranica1();
            option.ShowDialog();
        }

        private void btn_izvajdane_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            stranica2 option = new stranica2();
            option.ShowDialog();
        }

        private void btn_izhod_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Main option = new Menu_Main();
            option.ShowDialog();
        }

        private void Menu_1_klas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu_Main option = new Menu_Main();
            option.ShowDialog();
        }
    }
}
