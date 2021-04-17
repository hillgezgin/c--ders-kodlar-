using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum gunler
        {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte secim = Convert.ToByte(textBox1.Text);
            gunler gun;
            gun = (gunler)secim-1;
            MessageBox.Show(gun.ToString());
        }
    }
}
