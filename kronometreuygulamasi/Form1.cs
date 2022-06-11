using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometreuygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int salise = 0;
        int saniye = 0;
        int dakika = 0;
        int saat = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            
            if(salise == 60)
            {
                saniye++;
                salise = 0;
            }
            if(saniye == 60)
            {
                dakika++;
                saniye = 0;
            }
            if (dakika== 60)
            {
                saat++;
                dakika = 0;
            }
            label7.Text = salise.ToString();
            label5.Text = saniye.ToString();
            label3.Text = dakika.ToString();
            label2.Text = saat.ToString();

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
            listBox1.Items.Add(saat + " : " + dakika + " : " + saniye + " : " + salise);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            timer1.Stop();
            salise = 0;
            saniye = 0;
            dakika = 0;
            saat = 0;

            label7.Text = salise.ToString();
            label5.Text = saniye.ToString();
            label3.Text = dakika.ToString();
            label2.Text = saat.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
