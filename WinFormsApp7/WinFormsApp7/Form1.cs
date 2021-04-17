using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            string mail = "hilal-trk@hotmail.com";
            string belirlisifre = "hilal1";

            if(belirlisifre == sifre.Text && mail==eposta.Text)
            {
                MessageBox.Show("Oturumunuz açıldı!", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else 
            { 
            MessageBox.Show("E-posta veya şifre hatalı!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  MessageBox.Show("Hoşgeldiniz oturum açmak için grekli alanları doldurun!");
        }

        private void kayit_Click(object sender, EventArgs e)
        {
            int yasdeger = Convert.ToInt32(yastext.Text);
            string kadı = adtext.Text;
            if (yasdeger>=18)
            {
                MessageBox.Show("Kayıt Başarılı!");
                label1.Text = kadı + "   " + yasdeger;
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı!");
                label1.Text = "Yaşınız 18'den küçüktür!";
            }
        }
    }
}
