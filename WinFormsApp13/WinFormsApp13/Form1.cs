using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            int sira = listView1.Items.Count;
            listView1.Items.Add(ad.Text);
            listView1.Items[sira].SubItems.Add(sehir.Text);
            listView1.Items[sira].SubItems.Add(email.Text);
            temizle();
        }

        void temizle()
        {
            ad.Text = sehir.Text = email.Text = string.Empty;
            ad.Focus();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                string ad_soyad = ad.Text;
                string sehir_2 = sehir.Text;
                string epostam = email.Text;
                listView1.SelectedItems[0].Text = ad_soyad;
                listView1.SelectedItems[0].SubItems[1].Text = sehir_2;
                listView1.SelectedItems[0].SubItems[2].Text = epostam;
                MessageBox.Show("Kayıt güncellendi!");
            }
            else
            {
                MessageBox.Show("Güncellemek için bir kayıt seçiniz!");
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                listView1.SelectedItems[0].Remove();
                MessageBox.Show("Kayıt silindi");
            }
            else
            {
                MessageBox.Show("Silmek için kayır seçiniz!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi=listView1.Items.Count;
            MessageBox.Show("Listede "+ sayi.ToString()+" kayıt vardır." );
        }
    }
}
