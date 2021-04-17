using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayi1.Text = "";
            sayi2.Text = "";
            sonuc.Text = "";
            islem.Text = "";
        }

        private void topla_Click(object sender, EventArgs e)
        {
            islem.Text = "+";
            int dsayi1, dsayi2,islemsonuc;
            dsayi1 =Convert.ToInt32(sayi1.Text);
            dsayi2 = Convert.ToInt32(sayi2.Text);
            islemsonuc = dsayi1 + dsayi2;
            sonuc.Text = "Sonuç =" + islemsonuc.ToString();
        }

        private void rakam1_Click(object sender, EventArgs e)
        {
            if (sayi1.Text == "")
            {
                sayi1.Text = "1";
            }
            else
            {
                sayi2.Text = "1";
            }
        }

        private void rakam2_Click(object sender, EventArgs e)
        {
            if (sayi1.Text == "")
            {
                sayi1.Text = "2";
            }
            else
            {
                sayi2.Text = "2";
            }
        }

        private void fark_Click(object sender, EventArgs e)
        {
            islem.Text = "-";
            int dsayi1, dsayi2, islemsonuc;
            dsayi1 = Convert.ToInt32(sayi1.Text);
            dsayi2 = Convert.ToInt32(sayi2.Text);
            islemsonuc = dsayi1 - dsayi2;
            sonuc.Text = "Sonuç =" + islemsonuc.ToString();
        }

        private void carp_Click(object sender, EventArgs e)
        {
            islem.Text = "*";
            int dsayi1, dsayi2, islemsonuc;
            dsayi1 = Convert.ToInt32(sayi1.Text);
            dsayi2 = Convert.ToInt32(sayi2.Text);
            islemsonuc = dsayi1 * dsayi2;
            sonuc.Text = "Sonuç =" + islemsonuc.ToString();

        }

        private void bolum_Click(object sender, EventArgs e)
        {
            islem.Text = "/";
            int dsayi1, dsayi2;
            double islemsonuc;
            dsayi1 = Convert.ToInt32(sayi1.Text);
            dsayi2 = Convert.ToInt32(sayi2.Text);
            islemsonuc = dsayi1 / dsayi2;
            sonuc.Text = "Sonuç =" + islemsonuc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1.Text = "";
            sayi2.Text = "";
            sonuc.Text = "";
            islem.Text = "";
        }

        private void rakam3_Click(object sender, EventArgs e)
        {
            if(sayi1.Text=="")
            {
                sayi1.Text = "3";
            }
            else
            {
                sayi2.Text = "3";
            }
        }

        private void rakam4_Click(object sender, EventArgs e)
        {
            if (sayi1.Text == "")
            {
                sayi1.Text = "4";
            }
            else
            {
                sayi2.Text = "4";
            }
        }

        private void rakam5_Click(object sender, EventArgs e)
        {
            if (sayi1.Text == "")
            {
                sayi1.Text = "5";
            }
            else
            {
                sayi2.Text = "5";
            }
        }

        private void rakam6_Click(object sender, EventArgs e)
        {
            if (sayi1.Text == "")
            {
                sayi1.Text = "6";
            }
            else
            {
                sayi2.Text = "6";
            }
        }

        private void rakam7_Click(object sender, EventArgs e)
        {
            if (sayi1.Text == "")
            {
                sayi1.Text = "7";
            }
            else
            {
                sayi2.Text = "7";
            }
        }

        private void rakam8_Click(object sender, EventArgs e)
        {
            if (sayi1.Text == "")
            {
                sayi1.Text = "8";
            }
            else
            {
                sayi2.Text = "8";
            }
        }

        private void rakam9_Click(object sender, EventArgs e)
        {
            if (sayi1.Text == "")
            {
                sayi1.Text = "9";
            }
            else
            {
                sayi2.Text = "9";
            }
        }
    }
}
