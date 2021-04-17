using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class notHesapla
        {
            private string isim;
            public string Isim
            {
                get { return isim; }
                set { isim = value.ToUpper(); }
            }
            private string soyisim;
            public string Soyisim
            {
                get { return soyisim; }
                set { soyisim = value.ToUpper(); }
            }
            private string ders;
            public string Ders
            {
                get { return ders; }
                set { ders = value; }
            }
            private int vize1;
            public int Vize1
            {
                get { return vize1; }
                set { vize1 = Math.Abs(value); }
            }
            private int vize2;
            public int Vize2
            {
                get { return vize2; }
                set { vize2 = Math.Abs(value); }
            }
            private int final;
            public int Final
            {
                get { return final; }
                set { final = Math.Abs(value); }
            }
            public double Ortalama()
            {
                return (vize1 + vize2 + final) / 3;
            }

        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            notHesapla not1 = new notHesapla();
            not1.Isim = ad.Text;
            not1.Soyisim = soyad.Text;
            not1.Ders = comboBox1.Text;
            not1.Vize1 = Convert.ToInt32(vize1.Text);
            not1.Vize2 = Convert.ToInt32(vize2.Text);
            not1.Final = Convert.ToInt32(final.Text);
            ListViewItem kayit = new ListViewItem();
            kayit.Text = not1.Isim;
            kayit.SubItems.Add(not1.Soyisim);
            kayit.SubItems.Add(not1.Ders);
            kayit.SubItems.Add(not1.Ortalama().ToString());
            listView1.Items.Add(kayit);
            ad.Text = soyad.Text = comboBox1.Text = vize1.Text = vize2.Text = final.Text = "";
        }
    }
}
