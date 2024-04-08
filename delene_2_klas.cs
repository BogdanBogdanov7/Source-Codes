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
    public partial class delene_2_klas : Form
    {
        public delene_2_klas()
        {
            InitializeComponent();
        }

        private void delene_2_klas_Load(object sender, EventArgs e)
        {
            int[] num = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
            int[] num1 = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };//, 55, 60, 65, 70, 75, 80, 85, 90, 95 };

            Random rd = new Random();
            int randomIndex = rd.Next(0, 20);

            Random V = new Random();
            int randomIndex1 = V.Next(0, 10);

            int PChislo = num[randomIndex];
            int VChislo = num1[randomIndex1];

            int result1 = PChislo / VChislo;

            first.Text = PChislo.ToString();
            second.Text = VChislo.ToString();
            result.Text = result1.ToString();

            switch (PChislo)
            {
                case 1: 
                default:
            }

            if (PChislo >= VChislo && PChislo % VChislo == 0)
            {
                Random rd1 = new Random();
                int randomIndex2 = rd1.Next(0, 20);

                Random Z = new Random();
                int randomIndex3 = Z.Next(0, 19);

                int EChislo = num[randomIndex2];
                int TCh = num1[randomIndex3];
                int TChislo = V.Next(TCh, EChislo);

                int result2 = EChislo / TChislo;

                first.Text = EChislo.ToString();
                second.Text = TChislo.ToString();
                result.Text = result2.ToString();
            }
            else
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] num = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
            int[] num1 = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };//, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };

            Random rd = new Random();
            int randomIndex = rd.Next(0, 20);

            Random V = new Random();
            int randomIndex1 = V.Next(0, 10);

            int PChislo = num[randomIndex];
            int VChislo = num1[randomIndex1];

            int result1 = PChislo / VChislo;

            first.Text = PChislo.ToString();
            second.Text = VChislo.ToString();
            result.Text = result1.ToString();
        }
    }
}
