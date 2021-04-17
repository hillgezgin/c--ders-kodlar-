using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 17;
            int sayi2 = 20;
            int toplam = sayi1 + sayi2;
            MessageBox.Show("İşlem sonucu:" + toplam.ToString());

        }

        protected void kapat_Click(object sender, EventArgs e)
        {

        }
        // erişimbelirteci int-string-double-char-(void) metodunismi(int a,string isim)
        // {}

        public void hesapla(string isim)
        {
            
           TextBox1.text="Merhaba"+isim;
        }

        hesapla("hilal");


         
        

        private void goster_Click(object sender, EventArgs e)
        {
            //string alinanmetin = eposta.Text;
            // MessageBox.Show(alinanmetin);
            int yas = Convert.ToInt16(eposta.Text);
            if (yas >= 18)
            {
                label2.Text="Oturum açıldı";
            }
            else
                label2.Text ="Yaş 18'den küçük olduğu için kayıt yapılamıyor.";
            
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("Ubuntu");
            comboBox1.Items.Add(cmb.Text);
            listBox1.Items.Add(cmb.Text);
            

        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            
        }

        private void saybtn_Click(object sender, EventArgs e)
        {
            int sayi= comboBox1.Items.Count;
            MessageBox.Show("hello world");
            
        }
    }
}
