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
    public partial class Game_Menu : Form
    {
        public Game_Menu()
        {
            InitializeComponent();
        }
        public static int br = Menu_Main.SendPoints;
        public void Game_Menu_Load(object sender, EventArgs e)
        {
            points.Text = Menu_Main.SendPoints.ToString();

            if (Menu_Main.SendPoints >= 15)
            {
                tic_tac_toe_button.Enabled = true;
            }
            else
            {
                tic_tac_toe_button.Enabled = false;
            }
            if (Menu_Main.SendPoints >= 30)
            {
                tetris.Enabled = true;
            }
            else
            {
                tetris.Enabled = false;
            }
        }
        public void tic_tac_toe_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Main.br -= 15;
            points.Text = Menu_Main.br.ToString();
            tic_tac_toe option = new tic_tac_toe();
            option.ShowDialog();
            if (br >= 15)
            {
                tic_tac_toe_button.Enabled = true;
            }
            else
            {
                tic_tac_toe_button.Enabled = false;
            }
            if (br >= 30)
            {
                tetris.Enabled = true;
            }
            else
            {
                tetris.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Main option = new Menu_Main();
            option.ShowDialog();
        }

        public void tetris_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Main.br -= 30;
            points.Text = Menu_Main.br.ToString();
            tetris option = new tetris();
            option.ShowDialog();
            if (br >= 15)
            {
                tic_tac_toe_button.Enabled = true;
            }
            else
            {
                tic_tac_toe_button.Enabled = false;
            }
            if (br >= 30)
            {
                tetris.Enabled = true;
            }
            else
            {
                tetris.Enabled = false;
            }
        }

        private void Game_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu_Main option = new Menu_Main();
            option.ShowDialog();
        }
    }
}
