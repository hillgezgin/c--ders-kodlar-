using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sinema salon;
       
        private void olustur_Click(object sender, EventArgs e)
        {
            salon = new Sinema(textBox1.Text, Convert.ToInt32(textBox2.Text));
            label3.Text = "Salon oluşturuldu.Koltuk sayısı:" + textBox2.Text;
        }

        private void satis_Click(object sender, EventArgs e)
        {
            salon.Biletsat(indirimdurumu.Checked, Convert.ToInt32(textBox2.Text));
            label3.Text = "Bilet satıldı.";
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            salon.Biletİptal(indirimdurumu.Checked, Convert.ToInt32(textBox2.Text));
            label3.Text = "Biletiniz İptal edildi.";
        }

        private void bakiye_Click(object sender, EventArgs e)
        {
            salon.BakiyeSor();
            label3.Text = "Şuan bakiyeniz:" + salon.BakiyeSor();
        }
    }
}
