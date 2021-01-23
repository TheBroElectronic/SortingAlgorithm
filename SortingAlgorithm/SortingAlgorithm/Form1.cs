using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap grafic = new Bitmap(SortingAlgorithm.Properties.Resources.xd);
        int[] numb = new int[320];

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 320; i++)
            {
                numb[i] = rnd.Next(2, 220);
            }
            Graficate(numb);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 320; i++)
            {
                numb[i] = rnd.Next(2, 220);
            }
            if (MyAlgorithmBox.Checked)
            {
                Algorithm();
                Graficate(numb);
            }
            else if (CalgorithmBox.Checked)
            {
                Array.Sort(numb);
                Array.Reverse(numb);
                Graficate(numb);
            }
            else Graficate(numb);
        }

        void Graficate(int[] num)
        {
            grafic = new Bitmap(SortingAlgorithm.Properties.Resources.xd);
            int x2 = 0;
            for (int x = 0; x < num.Length; x++) //leer tabla
            {
                int y = num[x] * 2;
                for (int i = grafic.Height - 1; i > y; i--)//graficar tabla
                {
                    grafic.SetPixel(x + x2, i, Color.Black);
                    grafic.SetPixel(x + 1 + x2, i, Color.Blue);
                    grafic.SetPixel(x + 2 + x2, i, Color.Black);
                }
                x2 += 1;
            }
            pictureBox.Image = grafic;
            pictureBox.Refresh();
        }

        void Algorithm()
        {
            int numMax = 0, posAux = 0, numAux = 0;
            for(int pos = 0; pos < numb.Length; pos++)
            {
                for(int bus = pos; bus < numb.Length; bus++)
                {
                    if (numb[bus] > numMax)
                    {
                        numMax = numb[bus];
                        posAux = bus;
                    }
                }
                numAux = numb[posAux];
                numb[posAux] = numb[pos];
                numb[pos] = numAux;
                numMax = 0;
                if(graficBtn.Checked)Graficate(numb);
            }
        }

        private void MyAlgorithmBox_CheckedChanged(object sender, EventArgs e)
        {
            if(CalgorithmBox.Checked) CalgorithmBox.Checked = false;
        }

        private void CalgorithmBox_CheckedChanged(object sender, EventArgs e)
        {
            if(MyAlgorithmBox.Checked) MyAlgorithmBox.Checked = false;
        }
    }
}
