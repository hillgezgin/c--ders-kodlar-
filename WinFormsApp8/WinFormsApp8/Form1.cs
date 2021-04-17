using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Toplama");
            comboBox1.Items.Add("Çıkarma");
            comboBox1.Items.Add("Bölme");
            comboBox1.Items.Add("Çarpma");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
              
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            int a, b;
            double sonuc=0;
            a = Convert.ToInt32(sayi1.Text);
            b = Convert.ToInt32(sayi2.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                sonuc = a + b;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                sonuc = a - b;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                sonuc = a / b;
            }
            else if (comboBox1.SelectedIndex == 3)
                    {
                sonuc = a * b;
            }

            label3.Text = sonuc.ToString();

        }
    }
}
