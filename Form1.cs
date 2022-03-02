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
    }
}
