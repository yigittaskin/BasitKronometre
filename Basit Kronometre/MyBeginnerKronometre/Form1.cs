using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBeginnerKronometre
{
    public partial class Form1 : Form
    {
        int saat = 0;
        int dakika = 0;
        int saniye = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            saat = 0;
            dakika = 0;
            saniye = 0;
            label1.Text = saat.ToString() + " : " + dakika.ToString() + " : " + saniye.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = saat.ToString() + " : " + dakika.ToString() + " : " + saniye.ToString();
            if (saniye == 59)
            {
                saniye = 0;
                dakika++;
            }
            else if (dakika == 60)
            {
                saniye = 0;
                dakika = 0;
                saat++;
            }
            saniye++;
        }
    }
}
