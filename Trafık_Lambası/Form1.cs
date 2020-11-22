using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafık_Lambası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
            if (sayac>=0 & sayac <= 30)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
            }
            if (sayac >= 31 & sayac <= 40)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Transparent;
            }
            if (sayac >= 41 & sayac <= 70)
            {
                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Green;
            }
            if (sayac == 71)
            {
                sayac = 0;
            }
        }
    }
}
