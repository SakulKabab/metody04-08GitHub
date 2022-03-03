using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metody04_08GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBoxX.Text), y = int.Parse(textBoxY.Text);
            string vysledek = CelaCisla.Mocnina(x, y);
            MessageBox.Show(x + "^" + y + " = " + vysledek);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBoxX.Text);
            int vysledek = CelaCisla.Faktorial(x);
            MessageBox.Show(x + "! = " + vysledek.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBoxX.Text);
            MessageBox.Show("Součet lichých cifer je " + CelaCisla.LichCifSoucet(x));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBoxX.Text);
            if (CelaCisla.JePrvocislo(x)) MessageBox.Show("Číslo " + x + " je prvočíslo.");
            else MessageBox.Show("Číslo " + x + " není prvočíslo");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBoxX.Text);
            MessageBox.Show("Počet sudých dělitelů je " + CelaCisla.PocSudDel(x));
        }
    }
}
