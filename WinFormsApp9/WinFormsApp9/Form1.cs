using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi= comboBox1.Items.Count;
            MessageBox.Show("ComboBox'ta eleman sayısı:"+sayi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }
    }
}
