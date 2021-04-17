using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void anayemek_SelectedIndexChanged(object sender, EventArgs e)
        {
            anayemekliste.Items.Clear();
            if(anayemek.SelectedIndex==0)
            {
                anayemekliste.Items.Add("Karışık pizza-11 tl");
                anayemekliste.Items.Add("Margarita-9 tl");
                anayemekliste.Items.Add("Tavuklu-mantarlı pizza-11 tl");
            }
            else if(anayemek.SelectedIndex==1)
            {
                anayemekliste.Items.Add("Big burger-10 tl");
                anayemekliste.Items.Add("Chesee burger-8 tl");
                anayemekliste.Items.Add("Double burger-12 tl");
            }
            else if(anayemek.SelectedIndex==2)
            {
                anayemekliste.Items.Add("Tavuk dürüm-8 tl");
                anayemekliste.Items.Add("Urfa Dürüm-10 tl");
                anayemekliste.Items.Add("Adana dürüm-12 tl");
            }
        }


       
        private void siparis_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int yadet = Convert.ToInt32(yemekadet.Text);
            int iadet = Convert.ToInt32(icecekadet.Text);
            int cadet = Convert.ToInt32(corbaadet.Text);
            int ifiyat=0, cfiyat=0, yfiyat=0;

            // icecek fiyat belirleme
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 2 || comboBox1.SelectedIndex == 5)
            {
                ifiyat = 4;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ifiyat = 3;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                ifiyat = 2;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                ifiyat = 1;
            }
            else ifiyat = 5;

            // corba fiyat belirleme

            if (listBox1.SelectedIndex==0 || listBox1.SelectedIndex==2 || listBox1.SelectedIndex==3)
            {
                cfiyat = 4;
            }
                else if(listBox1.SelectedIndex==1)
            {
                cfiyat = 3;
            }
                // anayemek fiyat belirleme

                if(anayemek.SelectedIndex==0 && anayemekliste.SelectedIndex==0)
            {
                yfiyat = 11;
            }
                else if (anayemek.SelectedIndex==0 && anayemekliste.SelectedIndex==1)
            {
                yfiyat = 9;
            }
                else if(anayemek.SelectedIndex==0 && anayemekliste.SelectedIndex==2)
            {
                yfiyat = 11;
            }
                if(anayemek.SelectedIndex==1 && anayemekliste.SelectedIndex==0)
            {
                yfiyat = 10;
            }
                else if (anayemek.SelectedIndex==1 && anayemekliste.SelectedIndex==1)
            {
                yfiyat = 8;
            }
                else if (anayemek.SelectedIndex==1 && anayemekliste.SelectedIndex==2)
            {
                yfiyat = 12;
            }
                if(anayemek.SelectedIndex==2 && anayemekliste.SelectedIndex==0)
            {
                yfiyat = 8;
            }
               else if(anayemek.SelectedIndex==2 && anayemekliste.SelectedIndex==1)
            {
                yfiyat = 10;
            }
                else if (anayemek.SelectedIndex==2 && anayemekliste.SelectedIndex==2)
            {
                yfiyat = 12;
            }

              toplam = (yfiyat * yadet) + (ifiyat * iadet) + (cfiyat * cadet);
            string siparisicerigi = anayemekliste.SelectedItem.ToString() + " " +yemekadet.Text+"\n" +comboBox1.SelectedItem.ToString()+"  " +icecekadet.Text+"\n" + listBox1.SelectedItem.ToString()+" "+corbaadet.Text+ " \n"+"\n"+"Tutar:"+toplam;
            if(MessageBox.Show(siparisicerigi,"Siparişiniz",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
            {
                tutar.Text = "Tutar:"+toplam.ToString()+" tl";
            }
            else
            {
                tutar.Text = "Sipariş iptal edilmiştir.";
            }
        }
    }
}
