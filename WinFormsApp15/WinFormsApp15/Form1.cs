using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class sayilar
        {
            private int sayi_1;
            public int Sayi1
            {
                get { return sayi_1; }
                set { sayi_1 = value; }
            }

            private int sayi_2;
            public int Sayi2
            {
                get { return sayi_2; }
                set { sayi_2 = value; }
            }

        }

        class toplama : sayilar
        {
            private int sonuc;
            public int Sonuc
            {
                get { return sonuc; }
                set { sonuc = value; }
            }

            public int toplam()
            {
                sonuc = Sayi1 + Sayi2;
                return sonuc;
            }
        }
        class ortalama : sayilar
            {
                private double sonuc;
                public double Sonuc
                {
                    get { return sonuc; }
                    set { sonuc = value; }
                }
                public double Ortalama()
                {
                    sonuc = (Sayi1 + Sayi2)/2;
                    return sonuc;
                }
            }

        private void islem_Click(object sender, EventArgs e)
        {
            toplama t = new toplama();
            ortalama o = new ortalama();

            t.Sayi1 = Int16.Parse(textbox1.Text);
            t.Sayi2 = Int16.Parse(textbox2.Text);
            o.Sayi1 = Int16.Parse(textbox1.Text);
            o.Sayi2 = Int16.Parse(textbox2.Text);
            sonuctoplam.Text = Convert.ToString(t.toplam());
            sonucortalama.Text = Convert.ToString(o.Ortalama());
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            textbox1.Text = "";
            textbox2.Text = "";
        }

        /*  private void islem_Click(object sender, EventArgs e)
         {                


          }*/
    }
    }

