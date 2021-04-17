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

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Adı", 50);
            listView1.Columns.Add("Soyadı", 50);
            listView1.Columns.Add("Telefon", 15);
        }

        private void kydtbtn_Click(object sender, EventArgs e)
        {
            int sira = listView1.Items.Count;
            listView1.Items.Add(textBox1.Text);
            listView1.Items[sira].SubItems.Add(textBox2.Text);
            listView1.Items[sira].SubItems.Add(textBox3.Text);
            // textBox1.Text = textBox2.Text = textBox3.Text = "";
            textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
            textBox1.Focus();

        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                listView1.SelectedItems[0].Remove();
                MessageBox.Show("Seçilen veri silindi.");
            }
            else
            {
                MessageBox.Show("Bir seçim yapınız");
            }
        }

        private void gnclbtn_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                string ad = Interaction.InputBox("Adınızı Girin", "Güncelle");
                string soyad = Interaction.InputBox("Soyadınızı Girin", "Güncelle");
                string telefon = Interaction.InputBox("Telefon numaranızı Girin", "Güncelle");
                listView1.SelectedItems[0].Text = ad;
                listView1.SelectedItems[0].SubItems[1].Text = soyad;
                listView1.SelectedItems[0].SubItems[2].Text = telefon;
                MessageBox.Show("Seçim güncellendi");

            }
            else
            {
                MessageBox.Show("Bir seçim yapınız");
            }
        }
    }
}
