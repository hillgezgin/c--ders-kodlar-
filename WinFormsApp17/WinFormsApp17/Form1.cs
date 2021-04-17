using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class dikdörtgen
        {
            private int kkenar;
            public int Kkenar
            {
                get { return kkenar; }
                set { kkenar = value; }
            }

            private int ukenar;
            public int Ukenar
            {
                get { return ukenar; }
                set { ukenar = value; }
            }

            public int islem()
            {
                int sonuc, a, b;
                a = kkenar;
                b = ukenar;
                sonuc = a * b;
                return sonuc;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dikdörtgen d1 = new dikdörtgen();
            d1.Kkenar = int.Parse(textBox1.Text);
            d1.Ukenar = int.Parse(textBox2.Text);
            sonuclbl.Text = d1.islem().ToString();

        }
    }
}
